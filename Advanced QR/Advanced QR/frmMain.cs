using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using FireSharp;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Diagnostics;
using System.IO;

namespace Advanced_QR
{
    public partial class frmMain : Form
    {

        IFirebaseClient client;

        IFirebaseConfig ifc = new FirebaseConfig
        {
            BasePath = "https://advancedqr-7528e.firebaseio.com/",
            AuthSecret = "mMapYlBucQAak2P3s1BK9CEIZJY6l1S2CzxhJFPq"
        };

        public frmMain()
        {
            InitializeComponent();
        }

        bool usedQR = false;

        private void btnGen_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtCode.Text) || (String.IsNullOrWhiteSpace(txtCode.Text)))
            {
                MessageBox.Show("Please enter a Text", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(txtCode.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode qCode = new QRCode(data);
                picQR.Image = qCode.GetGraphic(5);
                usedQR = true;
            }
        }

        private string logOut;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (usedQR == true)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save to...";
                sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                sfd.FileName = "QRCode";
                sfd.Filter = "PNG files (*.png)|*.png|All files (*.*)|*.*";
                try
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        picQR.Image.Save(sfd.FileName);
                        MessageBox.Show("Exported successfully!", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception e1)
                {
                    logOut = e1.ToString();
                }
            }
            else
            {
                MessageBox.Show("Please generate a QR-Code", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        string usrPc = Environment.MachineName;


        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {

                client = new FirebaseClient(ifc);

                FirebaseResponse res2 = client.Get("Users/" + usrPc);
                PcClass ResUser = res2.ResultAs<PcClass>();
                var CurUser = new PcClass()
                {
                    pcname = usrPc
                };

                if (!PcClass.IsEqual(ResUser, CurUser))
                {
                    var std2 = new PcClass()
                    {
                        pcname = usrPc,
                    };
                    var updater = client.Set("Users/" + usrPc, std2);
                }


                var res = client.Get("Users/" + usrPc);
                var std = new UserClass();
                std = res.ResultAs<UserClass>();

                if (std.activated == "True")
                {
                    exportToolStripMenuItem.Enabled = true;
                    activateToolStripMenuItem.Enabled = false;
                    this.Text = "Advanced QR - Premium";
                }
                else
                {
                    exportToolStripMenuItem.Enabled = false;
                    activateToolStripMenuItem.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Failed connection to Server!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void activateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmActivate = new frmActivate();
            frmActivate.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAbout = new frmAbout();
            frmAbout.ShowDialog();
        }

        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.google.com/");
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(Environment.CurrentDirectory + @"\https\index.html");
            }
            catch
            {
                MessageBox.Show("Something failed! - Please reinstall the Application", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

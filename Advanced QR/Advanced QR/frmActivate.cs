using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Windows.Forms;

namespace Advanced_QR
{
    public partial class frmActivate : Form
    {
        public frmActivate()
        {
            InitializeComponent();
        }

        IFirebaseClient client;

        IFirebaseConfig ifc = new FirebaseConfig
        {
            BasePath = "https://advancedqr-7528e.firebaseio.com/",
            AuthSecret = "mMapYlBucQAak2P3s1BK9CEIZJY6l1S2CzxhJFPq"
        };

        string usrPc = Environment.MachineName;

        private void btnActivate_Click(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);

                FirebaseResponse res = client.Get("Keys/" + txtKey.Text);
                CheckKey ResUser = res.ResultAs<CheckKey>();
                var CurUser = new CheckKey()
                {
                    key = txtKey.Text
                };

                if (string.IsNullOrEmpty(txtKey.Text) | string.IsNullOrWhiteSpace(txtKey.Text))
                {
                }
                else if (CheckKey.IsEqual(ResUser, CurUser))
                {
                    if (ResUser.used == "False")
                    {
                        var _res = client.Get("Keys/" + txtKey.Text);
                        var std = new CheckKey();
                        std = res.ResultAs<CheckKey>();

                        var _std = new CheckKey() 
                        {
                            key = txtKey.Text,
                            used = "True" 
                        };
                        var _updater = client.Update("Keys/" + txtKey.Text, _std);

                        var _std3 = new UserClass() 
                        { 
                            activated = "True"
                        };
                        var _updater2 = client.Update("Users/" + usrPc, _std3);

                        MessageBox.Show("Activated succssesfully!" + Environment.NewLine + "Please restart to unlock all functions", "Information!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();

                    }
                    else
                    {
                        MessageBox.Show("Wrong activation code!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong activation code!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Failed connection to Server!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

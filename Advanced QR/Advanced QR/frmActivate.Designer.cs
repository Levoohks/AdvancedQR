namespace Advanced_QR
{
    partial class frmActivate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmActivate));
            this.txtKey = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActivate = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtKey
            // 
            this.txtKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtKey.DefaultText = "";
            this.txtKey.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtKey.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtKey.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.DisabledState.Parent = this.txtKey;
            this.txtKey.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtKey.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.FocusedState.Parent = this.txtKey;
            this.txtKey.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtKey.HoverState.Parent = this.txtKey;
            this.txtKey.Location = new System.Drawing.Point(32, 122);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '\0';
            this.txtKey.PlaceholderText = "";
            this.txtKey.SelectedText = "";
            this.txtKey.ShadowDecoration.Parent = this.txtKey;
            this.txtKey.Size = new System.Drawing.Size(351, 36);
            this.txtKey.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(29, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // btnActivate
            // 
            this.btnActivate.BorderRadius = 3;
            this.btnActivate.CheckedState.Parent = this.btnActivate;
            this.btnActivate.CustomImages.Parent = this.btnActivate;
            this.btnActivate.FillColor = System.Drawing.Color.Gray;
            this.btnActivate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnActivate.ForeColor = System.Drawing.Color.White;
            this.btnActivate.HoverState.Parent = this.btnActivate;
            this.btnActivate.Location = new System.Drawing.Point(32, 164);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.ShadowDecoration.Parent = this.btnActivate;
            this.btnActivate.Size = new System.Drawing.Size(351, 45);
            this.btnActivate.TabIndex = 4;
            this.btnActivate.Text = "Activate Code";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // frmActivate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(53)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(415, 248);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmActivate";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnActivate;
    }
}
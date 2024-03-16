namespace login_gui_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnExit = new Guna.UI2.WinForms.Guna2Button();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            cbShowPass = new CheckBox();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Transparent;
            btnExit.BorderRadius = 16;
            btnExit.CustomizableEdges = customizableEdges1;
            btnExit.DisabledState.BorderColor = Color.DarkGray;
            btnExit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnExit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnExit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnExit.FillColor = Color.Red;
            btnExit.Font = new Font("Segoe UI", 9F);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(608, 9);
            btnExit.Name = "btnExit";
            btnExit.ShadowDecoration.BorderRadius = 16;
            btnExit.ShadowDecoration.Color = Color.Red;
            btnExit.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnExit.ShadowDecoration.Depth = 10;
            btnExit.ShadowDecoration.Enabled = true;
            btnExit.Size = new Size(38, 31);
            btnExit.TabIndex = 0;
            btnExit.Text = "x";
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderRadius = 23;
            btnLogin.CustomizableEdges = customizableEdges3;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.DodgerBlue;
            btnLogin.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(22, 244);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.BorderRadius = 23;
            btnLogin.ShadowDecoration.Color = Color.Red;
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnLogin.ShadowDecoration.Depth = 10;
            btnLogin.ShadowDecoration.Enabled = true;
            btnLogin.Size = new Size(161, 50);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Palatino Linotype", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(24, 102);
            label1.Name = "label1";
            label1.Size = new Size(85, 18);
            label1.TabIndex = 4;
            label1.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(25, 170);
            label2.Name = "label2";
            label2.Size = new Size(85, 18);
            label2.TabIndex = 5;
            label2.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Comic Sans MS", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(100, 32);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 7;
            label3.Text = "DEDSEC";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(11, -21);
            panel2.Name = "panel2";
            panel2.Size = new Size(101, 129);
            panel2.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.wrench;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(383, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(276, 251);
            panel1.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(25, 199);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(434, 27);
            txtPassword.TabIndex = 11;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(23, 130);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(434, 27);
            txtUsername.TabIndex = 12;
            // 
            // cbShowPass
            // 
            cbShowPass.Appearance = Appearance.Button;
            cbShowPass.BackColor = Color.White;
            cbShowPass.FlatAppearance.BorderSize = 0;
            cbShowPass.FlatStyle = FlatStyle.Flat;
            cbShowPass.Font = new Font("Bahnschrift", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbShowPass.Location = new Point(411, 200);
            cbShowPass.Name = "cbShowPass";
            cbShowPass.Size = new Size(47, 24);
            cbShowPass.TabIndex = 13;
            cbShowPass.Text = "Show";
            cbShowPass.UseVisualStyleBackColor = false;
            cbShowPass.CheckedChanged += cbShowPass_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(656, 313);
            Controls.Add(cbShowPass);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Controls.Add(panel2);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel2;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private CheckBox cbShowPass;
    }
}

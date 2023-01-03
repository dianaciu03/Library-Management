namespace Library_Individual
{
    partial class LoginForm
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
            this.tabControlLoginRegister = new System.Windows.Forms.TabControl();
            this.tabLogin = new System.Windows.Forms.TabPage();
            this.lblEmailPasswordIncorrect = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.tbEmailLogin = new System.Windows.Forms.TextBox();
            this.lblEmailLogin = new System.Windows.Forms.Label();
            this.lblTitleLogin = new System.Windows.Forms.Label();
            this.tabRegister = new System.Windows.Forms.TabPage();
            this.lblAccountAlreadyExists = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.tbPasswordRegister = new System.Windows.Forms.TextBox();
            this.lblPasswordRegister = new System.Windows.Forms.Label();
            this.tbEmailRegister = new System.Windows.Forms.TextBox();
            this.lblEmailRegister = new System.Windows.Forms.Label();
            this.tbIDRegister = new System.Windows.Forms.TextBox();
            this.lblIDRegister = new System.Windows.Forms.Label();
            this.tbNameRegister = new System.Windows.Forms.TextBox();
            this.lblTitleRegister = new System.Windows.Forms.Label();
            this.lblNameRegister = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControlLoginRegister.SuspendLayout();
            this.tabLogin.SuspendLayout();
            this.tabRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlLoginRegister
            // 
            this.tabControlLoginRegister.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlLoginRegister.Controls.Add(this.tabLogin);
            this.tabControlLoginRegister.Controls.Add(this.tabRegister);
            this.tabControlLoginRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlLoginRegister.Location = new System.Drawing.Point(211, 73);
            this.tabControlLoginRegister.Name = "tabControlLoginRegister";
            this.tabControlLoginRegister.Padding = new System.Drawing.Point(84, 10);
            this.tabControlLoginRegister.SelectedIndex = 0;
            this.tabControlLoginRegister.Size = new System.Drawing.Size(476, 528);
            this.tabControlLoginRegister.TabIndex = 0;
            // 
            // tabLogin
            // 
            this.tabLogin.BackColor = System.Drawing.Color.Wheat;
            this.tabLogin.Controls.Add(this.lblEmailPasswordIncorrect);
            this.tabLogin.Controls.Add(this.btnLogin);
            this.tabLogin.Controls.Add(this.tbPasswordLogin);
            this.tabLogin.Controls.Add(this.lblPasswordLogin);
            this.tabLogin.Controls.Add(this.tbEmailLogin);
            this.tabLogin.Controls.Add(this.lblEmailLogin);
            this.tabLogin.Controls.Add(this.lblTitleLogin);
            this.tabLogin.Location = new System.Drawing.Point(4, 4);
            this.tabLogin.Name = "tabLogin";
            this.tabLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogin.Size = new System.Drawing.Size(468, 473);
            this.tabLogin.TabIndex = 0;
            this.tabLogin.Text = "Login";
            // 
            // lblEmailPasswordIncorrect
            // 
            this.lblEmailPasswordIncorrect.AutoSize = true;
            this.lblEmailPasswordIncorrect.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailPasswordIncorrect.ForeColor = System.Drawing.Color.Red;
            this.lblEmailPasswordIncorrect.Location = new System.Drawing.Point(17, 364);
            this.lblEmailPasswordIncorrect.Name = "lblEmailPasswordIncorrect";
            this.lblEmailPasswordIncorrect.Size = new System.Drawing.Size(348, 28);
            this.lblEmailPasswordIncorrect.TabIndex = 6;
            this.lblEmailPasswordIncorrect.Text = "Email and/or password is incorrect!";
            this.lblEmailPasswordIncorrect.Visible = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(179, 417);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(103, 40);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.Location = new System.Drawing.Point(17, 218);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '*';
            this.tbPasswordLogin.Size = new System.Drawing.Size(431, 34);
            this.tbPasswordLogin.TabIndex = 4;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordLogin.Location = new System.Drawing.Point(17, 192);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(84, 23);
            this.lblPasswordLogin.TabIndex = 3;
            this.lblPasswordLogin.Text = "Password:";
            // 
            // tbEmailLogin
            // 
            this.tbEmailLogin.Location = new System.Drawing.Point(17, 112);
            this.tbEmailLogin.Name = "tbEmailLogin";
            this.tbEmailLogin.Size = new System.Drawing.Size(431, 34);
            this.tbEmailLogin.TabIndex = 2;
            // 
            // lblEmailLogin
            // 
            this.lblEmailLogin.AutoSize = true;
            this.lblEmailLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailLogin.Location = new System.Drawing.Point(17, 86);
            this.lblEmailLogin.Name = "lblEmailLogin";
            this.lblEmailLogin.Size = new System.Drawing.Size(55, 23);
            this.lblEmailLogin.TabIndex = 1;
            this.lblEmailLogin.Text = "Email:";
            // 
            // lblTitleLogin
            // 
            this.lblTitleLogin.AutoSize = true;
            this.lblTitleLogin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleLogin.Location = new System.Drawing.Point(184, 14);
            this.lblTitleLogin.Name = "lblTitleLogin";
            this.lblTitleLogin.Size = new System.Drawing.Size(85, 32);
            this.lblTitleLogin.TabIndex = 0;
            this.lblTitleLogin.Text = "Login ";
            // 
            // tabRegister
            // 
            this.tabRegister.BackColor = System.Drawing.Color.Wheat;
            this.tabRegister.Controls.Add(this.lblAccountAlreadyExists);
            this.tabRegister.Controls.Add(this.btnRegister);
            this.tabRegister.Controls.Add(this.tbPasswordRegister);
            this.tabRegister.Controls.Add(this.lblPasswordRegister);
            this.tabRegister.Controls.Add(this.tbEmailRegister);
            this.tabRegister.Controls.Add(this.lblEmailRegister);
            this.tabRegister.Controls.Add(this.tbIDRegister);
            this.tabRegister.Controls.Add(this.lblIDRegister);
            this.tabRegister.Controls.Add(this.tbNameRegister);
            this.tabRegister.Controls.Add(this.lblTitleRegister);
            this.tabRegister.Controls.Add(this.lblNameRegister);
            this.tabRegister.Location = new System.Drawing.Point(4, 4);
            this.tabRegister.Name = "tabRegister";
            this.tabRegister.Padding = new System.Windows.Forms.Padding(3);
            this.tabRegister.Size = new System.Drawing.Size(468, 473);
            this.tabRegister.TabIndex = 1;
            this.tabRegister.Text = "Register";
            // 
            // lblAccountAlreadyExists
            // 
            this.lblAccountAlreadyExists.AutoSize = true;
            this.lblAccountAlreadyExists.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAccountAlreadyExists.ForeColor = System.Drawing.Color.Red;
            this.lblAccountAlreadyExists.Location = new System.Drawing.Point(17, 374);
            this.lblAccountAlreadyExists.Name = "lblAccountAlreadyExists";
            this.lblAccountAlreadyExists.Size = new System.Drawing.Size(233, 28);
            this.lblAccountAlreadyExists.TabIndex = 11;
            this.lblAccountAlreadyExists.Text = "Account already exists!";
            this.lblAccountAlreadyExists.Visible = false;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.Location = new System.Drawing.Point(179, 417);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(103, 40);
            this.btnRegister.TabIndex = 10;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // tbPasswordRegister
            // 
            this.tbPasswordRegister.Location = new System.Drawing.Point(17, 322);
            this.tbPasswordRegister.Name = "tbPasswordRegister";
            this.tbPasswordRegister.Size = new System.Drawing.Size(431, 34);
            this.tbPasswordRegister.TabIndex = 9;
            // 
            // lblPasswordRegister
            // 
            this.lblPasswordRegister.AutoSize = true;
            this.lblPasswordRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordRegister.Location = new System.Drawing.Point(17, 296);
            this.lblPasswordRegister.Name = "lblPasswordRegister";
            this.lblPasswordRegister.Size = new System.Drawing.Size(84, 23);
            this.lblPasswordRegister.TabIndex = 8;
            this.lblPasswordRegister.Text = "Password:";
            // 
            // tbEmailRegister
            // 
            this.tbEmailRegister.Location = new System.Drawing.Point(17, 243);
            this.tbEmailRegister.Name = "tbEmailRegister";
            this.tbEmailRegister.Size = new System.Drawing.Size(431, 34);
            this.tbEmailRegister.TabIndex = 7;
            // 
            // lblEmailRegister
            // 
            this.lblEmailRegister.AutoSize = true;
            this.lblEmailRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmailRegister.Location = new System.Drawing.Point(17, 217);
            this.lblEmailRegister.Name = "lblEmailRegister";
            this.lblEmailRegister.Size = new System.Drawing.Size(55, 23);
            this.lblEmailRegister.TabIndex = 6;
            this.lblEmailRegister.Text = "Email:";
            // 
            // tbIDRegister
            // 
            this.tbIDRegister.Location = new System.Drawing.Point(17, 165);
            this.tbIDRegister.Name = "tbIDRegister";
            this.tbIDRegister.Size = new System.Drawing.Size(431, 34);
            this.tbIDRegister.TabIndex = 5;
            // 
            // lblIDRegister
            // 
            this.lblIDRegister.AutoSize = true;
            this.lblIDRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIDRegister.Location = new System.Drawing.Point(17, 139);
            this.lblIDRegister.Name = "lblIDRegister";
            this.lblIDRegister.Size = new System.Drawing.Size(31, 23);
            this.lblIDRegister.TabIndex = 4;
            this.lblIDRegister.Text = "ID:";
            // 
            // tbNameRegister
            // 
            this.tbNameRegister.Location = new System.Drawing.Point(17, 89);
            this.tbNameRegister.Name = "tbNameRegister";
            this.tbNameRegister.Size = new System.Drawing.Size(431, 34);
            this.tbNameRegister.TabIndex = 3;
            // 
            // lblTitleRegister
            // 
            this.lblTitleRegister.AutoSize = true;
            this.lblTitleRegister.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleRegister.Location = new System.Drawing.Point(179, 12);
            this.lblTitleRegister.Name = "lblTitleRegister";
            this.lblTitleRegister.Size = new System.Drawing.Size(114, 32);
            this.lblTitleRegister.TabIndex = 1;
            this.lblTitleRegister.Text = "Register ";
            // 
            // lblNameRegister
            // 
            this.lblNameRegister.AutoSize = true;
            this.lblNameRegister.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNameRegister.Location = new System.Drawing.Point(17, 63);
            this.lblNameRegister.Name = "lblNameRegister";
            this.lblNameRegister.Size = new System.Drawing.Size(60, 23);
            this.lblNameRegister.TabIndex = 0;
            this.lblNameRegister.Text = "Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(211, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(476, 65);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Midnight Reads";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library_Individual.Properties.Resources.libraryLogin;
            this.ClientSize = new System.Drawing.Size(907, 624);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tabControlLoginRegister);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.tabControlLoginRegister.ResumeLayout(false);
            this.tabLogin.ResumeLayout(false);
            this.tabLogin.PerformLayout();
            this.tabRegister.ResumeLayout(false);
            this.tabRegister.PerformLayout();
            this.ResumeLayout(false);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
        }

        #endregion

        private TabControl tabControlLoginRegister;
        private TabPage tabLogin;
        private TabPage tabRegister;
        private Label lblNameRegister;
        private Label lblEmailPasswordIncorrect;
        private Button btnLogin;
        private TextBox tbPasswordLogin;
        private Label lblPasswordLogin;
        private TextBox tbEmailLogin;
        private Label lblEmailLogin;
        private Label lblTitleLogin;
        private Label lblTitle;
        private TextBox tbPasswordRegister;
        private Label lblPasswordRegister;
        private TextBox tbEmailRegister;
        private Label lblEmailRegister;
        private TextBox tbIDRegister;
        private Label lblIDRegister;
        private TextBox tbNameRegister;
        private Label lblTitleRegister;
        private Label lblAccountAlreadyExists;
        private Button btnRegister;
    }
}

namespace Lumin_Shows
{
    partial class LoginForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userNamePicBox = new System.Windows.Forms.PictureBox();
            this.passwordPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.userPasswordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.closeFrmBtn = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.inputsPanel = new System.Windows.Forms.Panel();
            this.userNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNamePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.inputsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 24);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userNamePicBox
            // 
            this.userNamePicBox.BackColor = System.Drawing.Color.Transparent;
            this.userNamePicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userNamePicBox.BackgroundImage")));
            this.userNamePicBox.Location = new System.Drawing.Point(116, 64);
            this.userNamePicBox.Name = "userNamePicBox";
            this.userNamePicBox.Size = new System.Drawing.Size(58, 63);
            this.userNamePicBox.TabIndex = 1;
            this.userNamePicBox.TabStop = false;
            // 
            // passwordPicBox
            // 
            this.passwordPicBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("passwordPicBox.BackgroundImage")));
            this.passwordPicBox.Location = new System.Drawing.Point(116, 159);
            this.passwordPicBox.Name = "passwordPicBox";
            this.passwordPicBox.Size = new System.Drawing.Size(65, 52);
            this.passwordPicBox.TabIndex = 2;
            this.passwordPicBox.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 323);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(500, 26);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // userNameTxt
            // 
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.Location = new System.Drawing.Point(213, 98);
            this.userNameTxt.Multiline = true;
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(184, 32);
            this.userNameTxt.TabIndex = 4;
            this.userNameTxt.Tag = "user name";
            // 
            // userPasswordTxt
            // 
            this.userPasswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPasswordTxt.Location = new System.Drawing.Point(213, 180);
            this.userPasswordTxt.Multiline = true;
            this.userPasswordTxt.Name = "userPasswordTxt";
            this.userPasswordTxt.PasswordChar = '*';
            this.userPasswordTxt.Size = new System.Drawing.Size(184, 31);
            this.userPasswordTxt.TabIndex = 5;
            this.userPasswordTxt.Tag = "password";
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(166)))), ((int)(((byte)(68)))));
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.loginBtn.Location = new System.Drawing.Point(188, 234);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(225, 30);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Tag = "loginBtn";
            this.loginBtn.Text = "LOGIN";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(133)))), ((int)(((byte)(112)))));
            this.registerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.registerBtn.Location = new System.Drawing.Point(415, 286);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(85, 31);
            this.registerBtn.TabIndex = 7;
            this.registerBtn.Tag = "registerBtn";
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // closeFrmBtn
            // 
            this.closeFrmBtn.BackColor = System.Drawing.Color.DarkRed;
            this.closeFrmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFrmBtn.Location = new System.Drawing.Point(471, 3);
            this.closeFrmBtn.Name = "closeFrmBtn";
            this.closeFrmBtn.Size = new System.Drawing.Size(29, 23);
            this.closeFrmBtn.TabIndex = 8;
            this.closeFrmBtn.Tag = "closeFrmBtn";
            this.closeFrmBtn.Text = "X";
            this.closeFrmBtn.UseVisualStyleBackColor = false;
            this.closeFrmBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // inputsPanel
            // 
            this.inputsPanel.Controls.Add(this.userNameLbl);
            this.inputsPanel.Location = new System.Drawing.Point(188, 64);
            this.inputsPanel.Name = "inputsPanel";
            this.inputsPanel.Size = new System.Drawing.Size(240, 164);
            this.inputsPanel.TabIndex = 9;
            this.inputsPanel.Visible = false;
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameLbl.ForeColor = System.Drawing.Color.White;
            this.userNameLbl.Location = new System.Drawing.Point(22, 18);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(56, 13);
            this.userNameLbl.TabIndex = 10;
            this.userNameLbl.Text = "user name";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(11)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(499, 333);
            this.Controls.Add(this.closeFrmBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.userPasswordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.passwordPicBox);
            this.Controls.Add(this.userNamePicBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.inputsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginForm_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userNamePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.inputsPanel.ResumeLayout(false);
            this.inputsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox userNamePicBox;
        private System.Windows.Forms.PictureBox passwordPicBox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox userPasswordTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button closeFrmBtn;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Panel inputsPanel;
        private System.Windows.Forms.Label userNameLbl;
    }
}


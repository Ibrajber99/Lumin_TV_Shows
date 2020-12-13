namespace Lumin_Shows
{
    partial class ActorMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorMaintenance));
            this.ActorInfoGrp = new System.Windows.Forms.GroupBox();
            this.actorLogo = new System.Windows.Forms.PictureBox();
            this.actorDobLbl = new System.Windows.Forms.Label();
            this.createActorBtn = new System.Windows.Forms.Button();
            this.lNameTxt = new System.Windows.Forms.TextBox();
            this.middleNameTxt = new System.Windows.Forms.TextBox();
            this.fNameTxt = new System.Windows.Forms.TextBox();
            this.middleNameLbl = new System.Windows.Forms.Label();
            this.ActorDOBDatePicker = new System.Windows.Forms.DateTimePicker();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.lNameLbl = new System.Windows.Forms.Label();
            this.navBtnsPanel = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editActorBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addActorBtn = new System.Windows.Forms.Button();
            this.lastRecordBtn = new System.Windows.Forms.Button();
            this.nextRecordBtn = new System.Windows.Forms.Button();
            this.previousRecordBtn = new System.Windows.Forms.Button();
            this.firstRecordBtn = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.formStatusStripLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.closeFrmBtn = new System.Windows.Forms.Button();
            this.ActorInfoGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorLogo)).BeginInit();
            this.navBtnsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActorInfoGrp
            // 
            this.ActorInfoGrp.BackColor = System.Drawing.Color.DarkGray;
            this.ActorInfoGrp.Controls.Add(this.actorLogo);
            this.ActorInfoGrp.Controls.Add(this.actorDobLbl);
            this.ActorInfoGrp.Controls.Add(this.createActorBtn);
            this.ActorInfoGrp.Controls.Add(this.lNameTxt);
            this.ActorInfoGrp.Controls.Add(this.middleNameTxt);
            this.ActorInfoGrp.Controls.Add(this.fNameTxt);
            this.ActorInfoGrp.Controls.Add(this.middleNameLbl);
            this.ActorInfoGrp.Controls.Add(this.ActorDOBDatePicker);
            this.ActorInfoGrp.Controls.Add(this.fNameLbl);
            this.ActorInfoGrp.Controls.Add(this.lNameLbl);
            this.ActorInfoGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorInfoGrp.ForeColor = System.Drawing.Color.Black;
            this.ActorInfoGrp.Location = new System.Drawing.Point(0, 27);
            this.ActorInfoGrp.Name = "ActorInfoGrp";
            this.ActorInfoGrp.Size = new System.Drawing.Size(526, 210);
            this.ActorInfoGrp.TabIndex = 5;
            this.ActorInfoGrp.TabStop = false;
            this.ActorInfoGrp.Text = "Actor Information";
            // 
            // actorLogo
            // 
            this.actorLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("actorLogo.BackgroundImage")));
            this.actorLogo.Location = new System.Drawing.Point(429, 12);
            this.actorLogo.Name = "actorLogo";
            this.actorLogo.Size = new System.Drawing.Size(66, 59);
            this.actorLogo.TabIndex = 12;
            this.actorLogo.TabStop = false;
            // 
            // actorDobLbl
            // 
            this.actorDobLbl.AutoSize = true;
            this.actorDobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actorDobLbl.Location = new System.Drawing.Point(6, 146);
            this.actorDobLbl.Name = "actorDobLbl";
            this.actorDobLbl.Size = new System.Drawing.Size(75, 20);
            this.actorDobLbl.TabIndex = 11;
            this.actorDobLbl.Text = "Born On";
            // 
            // createActorBtn
            // 
            this.createActorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createActorBtn.ForeColor = System.Drawing.Color.Transparent;
            this.createActorBtn.Location = new System.Drawing.Point(417, 164);
            this.createActorBtn.Name = "createActorBtn";
            this.createActorBtn.Size = new System.Drawing.Size(98, 40);
            this.createActorBtn.TabIndex = 9;
            this.createActorBtn.Tag = "createActorBtn";
            this.createActorBtn.Text = "CREATE";
            this.createActorBtn.UseVisualStyleBackColor = true;
            this.createActorBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // lNameTxt
            // 
            this.lNameTxt.Location = new System.Drawing.Point(119, 108);
            this.lNameTxt.Name = "lNameTxt";
            this.lNameTxt.Size = new System.Drawing.Size(218, 22);
            this.lNameTxt.TabIndex = 8;
            this.lNameTxt.Tag = "lastName";
            // 
            // middleNameTxt
            // 
            this.middleNameTxt.Location = new System.Drawing.Point(119, 72);
            this.middleNameTxt.Name = "middleNameTxt";
            this.middleNameTxt.Size = new System.Drawing.Size(218, 22);
            this.middleNameTxt.TabIndex = 7;
            this.middleNameTxt.Tag = "middleName";
            // 
            // fNameTxt
            // 
            this.fNameTxt.Location = new System.Drawing.Point(119, 33);
            this.fNameTxt.Name = "fNameTxt";
            this.fNameTxt.Size = new System.Drawing.Size(218, 22);
            this.fNameTxt.TabIndex = 6;
            this.fNameTxt.Tag = "firstName";
            // 
            // middleNameLbl
            // 
            this.middleNameLbl.AutoSize = true;
            this.middleNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLbl.Location = new System.Drawing.Point(6, 72);
            this.middleNameLbl.Name = "middleNameLbl";
            this.middleNameLbl.Size = new System.Drawing.Size(112, 20);
            this.middleNameLbl.TabIndex = 2;
            this.middleNameLbl.Text = "Middle Name";
            // 
            // ActorDOBDatePicker
            // 
            this.ActorDOBDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorDOBDatePicker.Location = new System.Drawing.Point(119, 145);
            this.ActorDOBDatePicker.Name = "ActorDOBDatePicker";
            this.ActorDOBDatePicker.Size = new System.Drawing.Size(233, 20);
            this.ActorDOBDatePicker.TabIndex = 3;
            // 
            // fNameLbl
            // 
            this.fNameLbl.AutoSize = true;
            this.fNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameLbl.Location = new System.Drawing.Point(5, 34);
            this.fNameLbl.Name = "fNameLbl";
            this.fNameLbl.Size = new System.Drawing.Size(96, 20);
            this.fNameLbl.TabIndex = 0;
            this.fNameLbl.Text = "First Name";
            // 
            // lNameLbl
            // 
            this.lNameLbl.AutoSize = true;
            this.lNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameLbl.Location = new System.Drawing.Point(6, 108);
            this.lNameLbl.Name = "lNameLbl";
            this.lNameLbl.Size = new System.Drawing.Size(95, 20);
            this.lNameLbl.TabIndex = 1;
            this.lNameLbl.Text = "Last Name";
            // 
            // navBtnsPanel
            // 
            this.navBtnsPanel.BackColor = System.Drawing.Color.Transparent;
            this.navBtnsPanel.Controls.Add(this.cancelBtn);
            this.navBtnsPanel.Controls.Add(this.editActorBtn);
            this.navBtnsPanel.Controls.Add(this.deleteBtn);
            this.navBtnsPanel.Controls.Add(this.addActorBtn);
            this.navBtnsPanel.Controls.Add(this.lastRecordBtn);
            this.navBtnsPanel.Controls.Add(this.nextRecordBtn);
            this.navBtnsPanel.Controls.Add(this.previousRecordBtn);
            this.navBtnsPanel.Controls.Add(this.firstRecordBtn);
            this.navBtnsPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navBtnsPanel.Location = new System.Drawing.Point(12, 243);
            this.navBtnsPanel.Name = "navBtnsPanel";
            this.navBtnsPanel.Size = new System.Drawing.Size(501, 123);
            this.navBtnsPanel.TabIndex = 6;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancelBtn.Location = new System.Drawing.Point(405, 80);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(86, 37);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Tag = "cancelProcessBtn";
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // editActorBtn
            // 
            this.editActorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editActorBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.editActorBtn.Location = new System.Drawing.Point(272, 80);
            this.editActorBtn.Name = "editActorBtn";
            this.editActorBtn.Size = new System.Drawing.Size(86, 37);
            this.editActorBtn.TabIndex = 6;
            this.editActorBtn.Tag = "saveActorBtn";
            this.editActorBtn.Text = "Edit";
            this.editActorBtn.UseVisualStyleBackColor = true;
            this.editActorBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deleteBtn.Location = new System.Drawing.Point(134, 80);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(86, 37);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Tag = "deleteActorBtn";
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // addActorBtn
            // 
            this.addActorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addActorBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addActorBtn.Location = new System.Drawing.Point(15, 80);
            this.addActorBtn.Name = "addActorBtn";
            this.addActorBtn.Size = new System.Drawing.Size(86, 37);
            this.addActorBtn.TabIndex = 4;
            this.addActorBtn.Tag = "addActorBtn";
            this.addActorBtn.Text = "Add";
            this.addActorBtn.UseVisualStyleBackColor = true;
            this.addActorBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // lastRecordBtn
            // 
            this.lastRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastRecordBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lastRecordBtn.Location = new System.Drawing.Point(405, 14);
            this.lastRecordBtn.Name = "lastRecordBtn";
            this.lastRecordBtn.Size = new System.Drawing.Size(86, 37);
            this.lastRecordBtn.TabIndex = 3;
            this.lastRecordBtn.Tag = "lastButton";
            this.lastRecordBtn.Text = "Last";
            this.lastRecordBtn.UseVisualStyleBackColor = true;
            this.lastRecordBtn.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // nextRecordBtn
            // 
            this.nextRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextRecordBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextRecordBtn.Location = new System.Drawing.Point(272, 14);
            this.nextRecordBtn.Name = "nextRecordBtn";
            this.nextRecordBtn.Size = new System.Drawing.Size(86, 37);
            this.nextRecordBtn.TabIndex = 2;
            this.nextRecordBtn.Tag = "nextButton";
            this.nextRecordBtn.Text = "Next";
            this.nextRecordBtn.UseVisualStyleBackColor = true;
            this.nextRecordBtn.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // previousRecordBtn
            // 
            this.previousRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousRecordBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.previousRecordBtn.Location = new System.Drawing.Point(134, 14);
            this.previousRecordBtn.Name = "previousRecordBtn";
            this.previousRecordBtn.Size = new System.Drawing.Size(86, 37);
            this.previousRecordBtn.TabIndex = 1;
            this.previousRecordBtn.Tag = "previousButton";
            this.previousRecordBtn.Text = "Previous";
            this.previousRecordBtn.UseVisualStyleBackColor = true;
            this.previousRecordBtn.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // firstRecordBtn
            // 
            this.firstRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstRecordBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstRecordBtn.Location = new System.Drawing.Point(15, 14);
            this.firstRecordBtn.Name = "firstRecordBtn";
            this.firstRecordBtn.Size = new System.Drawing.Size(86, 37);
            this.firstRecordBtn.TabIndex = 0;
            this.firstRecordBtn.Tag = "firstButton";
            this.firstRecordBtn.Text = "First";
            this.firstRecordBtn.UseVisualStyleBackColor = true;
            this.firstRecordBtn.Click += new System.EventHandler(this.Navigation_Handler);
            // 
            // errProvider
            // 
            this.errProvider.ContainerControl = this;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formStatusStripLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(526, 25);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // formStatusStripLbl
            // 
            this.formStatusStripLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formStatusStripLbl.Name = "formStatusStripLbl";
            this.formStatusStripLbl.Size = new System.Drawing.Size(160, 20);
            this.formStatusStripLbl.Text = "toolStripStatusLabel1";
            // 
            // closeFrmBtn
            // 
            this.closeFrmBtn.BackColor = System.Drawing.Color.DarkRed;
            this.closeFrmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFrmBtn.Location = new System.Drawing.Point(490, -2);
            this.closeFrmBtn.Name = "closeFrmBtn";
            this.closeFrmBtn.Size = new System.Drawing.Size(36, 23);
            this.closeFrmBtn.TabIndex = 8;
            this.closeFrmBtn.Tag = "closeFormBtn";
            this.closeFrmBtn.Text = "X";
            this.closeFrmBtn.UseVisualStyleBackColor = false;
            this.closeFrmBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // ActorMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(526, 402);
            this.Controls.Add(this.closeFrmBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.navBtnsPanel);
            this.Controls.Add(this.ActorInfoGrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActorMaintenance";
            this.Text = "ActorMaintenance";
            this.Load += new System.EventHandler(this.ActorMaintenance_Load);
            this.ActorInfoGrp.ResumeLayout(false);
            this.ActorInfoGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorLogo)).EndInit();
            this.navBtnsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ActorInfoGrp;
        private System.Windows.Forms.TextBox lNameTxt;
        private System.Windows.Forms.TextBox middleNameTxt;
        private System.Windows.Forms.TextBox fNameTxt;
        private System.Windows.Forms.Label middleNameLbl;
        private System.Windows.Forms.DateTimePicker ActorDOBDatePicker;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Panel navBtnsPanel;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button editActorBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addActorBtn;
        private System.Windows.Forms.Button lastRecordBtn;
        private System.Windows.Forms.Button nextRecordBtn;
        private System.Windows.Forms.Button previousRecordBtn;
        private System.Windows.Forms.Button firstRecordBtn;
        private System.Windows.Forms.Button createActorBtn;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.Label actorDobLbl;
        private System.Windows.Forms.PictureBox actorLogo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel formStatusStripLbl;
        private System.Windows.Forms.Button closeFrmBtn;
    }
}
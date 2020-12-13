namespace Lumin_Shows
{
    partial class PDCompaniesMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDCompaniesMaintenance));
            this.pdCompInfoGrp = new System.Windows.Forms.GroupBox();
            this.pdCompanyPicBox = new System.Windows.Forms.PictureBox();
            this.createPdCompBtn = new System.Windows.Forms.Button();
            this.PdCompDescLbl = new System.Windows.Forms.Label();
            this.pdCompDescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.pdCompTxt = new System.Windows.Forms.TextBox();
            this.PdCompNameLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.editPdCompBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.addPdCompBtn = new System.Windows.Forms.Button();
            this.lastRecordBtn = new System.Windows.Forms.Button();
            this.nextRecordBtn = new System.Windows.Forms.Button();
            this.previousRecordBtn = new System.Windows.Forms.Button();
            this.firstRecordBtn = new System.Windows.Forms.Button();
            this.errProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.closeFrmBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.formStatusStripLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.pdCompInfoGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdCompanyPicBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdCompInfoGrp
            // 
            this.pdCompInfoGrp.BackColor = System.Drawing.Color.DarkGray;
            this.pdCompInfoGrp.Controls.Add(this.pdCompanyPicBox);
            this.pdCompInfoGrp.Controls.Add(this.createPdCompBtn);
            this.pdCompInfoGrp.Controls.Add(this.PdCompDescLbl);
            this.pdCompInfoGrp.Controls.Add(this.pdCompDescriptionTxt);
            this.pdCompInfoGrp.Controls.Add(this.pdCompTxt);
            this.pdCompInfoGrp.Controls.Add(this.PdCompNameLbl);
            this.pdCompInfoGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdCompInfoGrp.ForeColor = System.Drawing.Color.Black;
            this.pdCompInfoGrp.Location = new System.Drawing.Point(2, 34);
            this.pdCompInfoGrp.Name = "pdCompInfoGrp";
            this.pdCompInfoGrp.Size = new System.Drawing.Size(561, 241);
            this.pdCompInfoGrp.TabIndex = 0;
            this.pdCompInfoGrp.TabStop = false;
            this.pdCompInfoGrp.Text = "Production Company Information";
            // 
            // pdCompanyPicBox
            // 
            this.pdCompanyPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pdCompanyPicBox.BackgroundImage")));
            this.pdCompanyPicBox.Location = new System.Drawing.Point(487, 21);
            this.pdCompanyPicBox.Name = "pdCompanyPicBox";
            this.pdCompanyPicBox.Size = new System.Drawing.Size(65, 66);
            this.pdCompanyPicBox.TabIndex = 8;
            this.pdCompanyPicBox.TabStop = false;
            // 
            // createPdCompBtn
            // 
            this.createPdCompBtn.BackColor = System.Drawing.Color.Transparent;
            this.createPdCompBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createPdCompBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.createPdCompBtn.Location = new System.Drawing.Point(462, 196);
            this.createPdCompBtn.Name = "createPdCompBtn";
            this.createPdCompBtn.Size = new System.Drawing.Size(90, 39);
            this.createPdCompBtn.TabIndex = 5;
            this.createPdCompBtn.Tag = "createProdCompBtn";
            this.createPdCompBtn.Text = "CREATE";
            this.createPdCompBtn.UseVisualStyleBackColor = false;
            this.createPdCompBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // PdCompDescLbl
            // 
            this.PdCompDescLbl.AutoSize = true;
            this.PdCompDescLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdCompDescLbl.Location = new System.Drawing.Point(10, 100);
            this.PdCompDescLbl.Name = "PdCompDescLbl";
            this.PdCompDescLbl.Size = new System.Drawing.Size(129, 20);
            this.PdCompDescLbl.TabIndex = 7;
            this.PdCompDescLbl.Text = "DESCRIPTION";
            // 
            // pdCompDescriptionTxt
            // 
            this.pdCompDescriptionTxt.Location = new System.Drawing.Point(165, 81);
            this.pdCompDescriptionTxt.Name = "pdCompDescriptionTxt";
            this.pdCompDescriptionTxt.Size = new System.Drawing.Size(255, 89);
            this.pdCompDescriptionTxt.TabIndex = 6;
            this.pdCompDescriptionTxt.Text = "";
            // 
            // pdCompTxt
            // 
            this.pdCompTxt.Location = new System.Drawing.Point(165, 53);
            this.pdCompTxt.Name = "pdCompTxt";
            this.pdCompTxt.Size = new System.Drawing.Size(255, 22);
            this.pdCompTxt.TabIndex = 4;
            this.pdCompTxt.Tag = "PDCompName";
            // 
            // PdCompNameLbl
            // 
            this.PdCompNameLbl.AutoSize = true;
            this.PdCompNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdCompNameLbl.Location = new System.Drawing.Point(10, 55);
            this.PdCompNameLbl.Name = "PdCompNameLbl";
            this.PdCompNameLbl.Size = new System.Drawing.Size(59, 20);
            this.PdCompNameLbl.TabIndex = 3;
            this.PdCompNameLbl.Text = "NAME";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.editPdCompBtn);
            this.panel1.Controls.Add(this.deleteBtn);
            this.panel1.Controls.Add(this.addPdCompBtn);
            this.panel1.Controls.Add(this.lastRecordBtn);
            this.panel1.Controls.Add(this.nextRecordBtn);
            this.panel1.Controls.Add(this.previousRecordBtn);
            this.panel1.Controls.Add(this.firstRecordBtn);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 123);
            this.panel1.TabIndex = 7;
            // 
            // cancelBtn
            // 
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.cancelBtn.Location = new System.Drawing.Point(405, 80);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(86, 37);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Tag = "cancelProcessBtn";
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // editPdCompBtn
            // 
            this.editPdCompBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editPdCompBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.editPdCompBtn.Location = new System.Drawing.Point(272, 80);
            this.editPdCompBtn.Name = "editPdCompBtn";
            this.editPdCompBtn.Size = new System.Drawing.Size(86, 37);
            this.editPdCompBtn.TabIndex = 6;
            this.editPdCompBtn.Tag = "saveProdCompBtn";
            this.editPdCompBtn.Text = "Edit";
            this.editPdCompBtn.UseVisualStyleBackColor = true;
            this.editPdCompBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // deleteBtn
            // 
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.deleteBtn.Location = new System.Drawing.Point(134, 80);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(86, 37);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Tag = "deleteProdCompBtn";
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // addPdCompBtn
            // 
            this.addPdCompBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addPdCompBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.addPdCompBtn.Location = new System.Drawing.Point(15, 80);
            this.addPdCompBtn.Name = "addPdCompBtn";
            this.addPdCompBtn.Size = new System.Drawing.Size(86, 37);
            this.addPdCompBtn.TabIndex = 4;
            this.addPdCompBtn.Tag = "addProdCompBtn";
            this.addPdCompBtn.Text = "Add";
            this.addPdCompBtn.UseVisualStyleBackColor = true;
            this.addPdCompBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // lastRecordBtn
            // 
            this.lastRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastRecordBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.nextRecordBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.previousRecordBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            this.firstRecordBtn.ForeColor = System.Drawing.SystemColors.ControlLight;
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
            // closeFrmBtn
            // 
            this.closeFrmBtn.BackColor = System.Drawing.Color.DarkRed;
            this.closeFrmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFrmBtn.Location = new System.Drawing.Point(527, 1);
            this.closeFrmBtn.Name = "closeFrmBtn";
            this.closeFrmBtn.Size = new System.Drawing.Size(36, 27);
            this.closeFrmBtn.TabIndex = 9;
            this.closeFrmBtn.Tag = "closeFormBtn";
            this.closeFrmBtn.Text = "X";
            this.closeFrmBtn.UseVisualStyleBackColor = false;
            this.closeFrmBtn.Click += new System.EventHandler(this.RouteBtnsClickAction);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formStatusStripLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(566, 25);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // formStatusStripLbl
            // 
            this.formStatusStripLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formStatusStripLbl.Name = "formStatusStripLbl";
            this.formStatusStripLbl.Size = new System.Drawing.Size(160, 20);
            this.formStatusStripLbl.Text = "toolStripStatusLabel1";
            // 
            // PDCompaniesMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(566, 441);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.closeFrmBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pdCompInfoGrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PDCompaniesMaintenance";
            this.Text = "PDCompaniesMaintenance";
            this.Load += new System.EventHandler(this.PDCompaniesMaintenance_Load);
            this.pdCompInfoGrp.ResumeLayout(false);
            this.pdCompInfoGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdCompanyPicBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errProvider)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pdCompInfoGrp;
        private System.Windows.Forms.TextBox pdCompTxt;
        private System.Windows.Forms.Label PdCompNameLbl;
        private System.Windows.Forms.RichTextBox pdCompDescriptionTxt;
        private System.Windows.Forms.Label PdCompDescLbl;
        private System.Windows.Forms.Button createPdCompBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button editPdCompBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button addPdCompBtn;
        private System.Windows.Forms.Button lastRecordBtn;
        private System.Windows.Forms.Button nextRecordBtn;
        private System.Windows.Forms.Button previousRecordBtn;
        private System.Windows.Forms.Button firstRecordBtn;
        private System.Windows.Forms.ErrorProvider errProvider;
        private System.Windows.Forms.PictureBox pdCompanyPicBox;
        private System.Windows.Forms.Button closeFrmBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel formStatusStripLbl;
    }
}
namespace Lumin_Shows.BrowseForms
{
    partial class ProductionCompanyBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionCompanyBrowse));
            this.pdCompInfoGrp = new System.Windows.Forms.GroupBox();
            this.producedShowsGrp = new System.Windows.Forms.GroupBox();
            this.prodShowsInfoMessage = new System.Windows.Forms.Label();
            this.producedShowsCmb = new System.Windows.Forms.ComboBox();
            this.pdCompanyResultLbl = new System.Windows.Forms.Label();
            this.PdCompDescLbl = new System.Windows.Forms.Label();
            this.pdCompDescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.PdCompNameLbl = new System.Windows.Forms.Label();
            this.pdCompanyDgv = new System.Windows.Forms.DataGridView();
            this.PDCompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDCompanyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.closeFrmBtn = new System.Windows.Forms.Button();
            this.pdCompInfoGrp.SuspendLayout();
            this.producedShowsGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdCompanyDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionCompanyBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdCompInfoGrp
            // 
            this.pdCompInfoGrp.BackColor = System.Drawing.Color.DarkGray;
            this.pdCompInfoGrp.Controls.Add(this.producedShowsGrp);
            this.pdCompInfoGrp.Controls.Add(this.pdCompanyResultLbl);
            this.pdCompInfoGrp.Controls.Add(this.PdCompDescLbl);
            this.pdCompInfoGrp.Controls.Add(this.pdCompDescriptionTxt);
            this.pdCompInfoGrp.Controls.Add(this.PdCompNameLbl);
            this.pdCompInfoGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdCompInfoGrp.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pdCompInfoGrp.Location = new System.Drawing.Point(12, 12);
            this.pdCompInfoGrp.Name = "pdCompInfoGrp";
            this.pdCompInfoGrp.Size = new System.Drawing.Size(429, 293);
            this.pdCompInfoGrp.TabIndex = 1;
            this.pdCompInfoGrp.TabStop = false;
            this.pdCompInfoGrp.Text = "Production Company Information";
            // 
            // producedShowsGrp
            // 
            this.producedShowsGrp.Controls.Add(this.prodShowsInfoMessage);
            this.producedShowsGrp.Controls.Add(this.producedShowsCmb);
            this.producedShowsGrp.Location = new System.Drawing.Point(13, 176);
            this.producedShowsGrp.Name = "producedShowsGrp";
            this.producedShowsGrp.Size = new System.Drawing.Size(286, 100);
            this.producedShowsGrp.TabIndex = 9;
            this.producedShowsGrp.TabStop = false;
            this.producedShowsGrp.Text = "Produced Shows";
            // 
            // prodShowsInfoMessage
            // 
            this.prodShowsInfoMessage.AutoSize = true;
            this.prodShowsInfoMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodShowsInfoMessage.ForeColor = System.Drawing.Color.Red;
            this.prodShowsInfoMessage.Location = new System.Drawing.Point(54, 63);
            this.prodShowsInfoMessage.Name = "prodShowsInfoMessage";
            this.prodShowsInfoMessage.Size = new System.Drawing.Size(156, 18);
            this.prodShowsInfoMessage.TabIndex = 1;
            this.prodShowsInfoMessage.Text = "No Shows available";
            // 
            // producedShowsCmb
            // 
            this.producedShowsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.producedShowsCmb.FormattingEnabled = true;
            this.producedShowsCmb.Location = new System.Drawing.Point(7, 36);
            this.producedShowsCmb.Name = "producedShowsCmb";
            this.producedShowsCmb.Size = new System.Drawing.Size(273, 24);
            this.producedShowsCmb.TabIndex = 0;
            // 
            // pdCompanyResultLbl
            // 
            this.pdCompanyResultLbl.AutoSize = true;
            this.pdCompanyResultLbl.Location = new System.Drawing.Point(162, 55);
            this.pdCompanyResultLbl.Name = "pdCompanyResultLbl";
            this.pdCompanyResultLbl.Size = new System.Drawing.Size(51, 16);
            this.pdCompanyResultLbl.TabIndex = 8;
            this.pdCompanyResultLbl.Text = "label1";
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
            this.pdCompDescriptionTxt.ReadOnly = true;
            this.pdCompDescriptionTxt.Size = new System.Drawing.Size(255, 89);
            this.pdCompDescriptionTxt.TabIndex = 6;
            this.pdCompDescriptionTxt.Text = "";
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
            // pdCompanyDgv
            // 
            this.pdCompanyDgv.AllowUserToAddRows = false;
            this.pdCompanyDgv.AllowUserToDeleteRows = false;
            this.pdCompanyDgv.AutoGenerateColumns = false;
            this.pdCompanyDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pdCompanyDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pdCompanyDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PDCompanyName,
            this.pDCompanyIDDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.pdCompanyDgv.DataSource = this.productionCompanyBindingSource;
            this.pdCompanyDgv.Location = new System.Drawing.Point(447, 32);
            this.pdCompanyDgv.Name = "pdCompanyDgv";
            this.pdCompanyDgv.ReadOnly = true;
            this.pdCompanyDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pdCompanyDgv.Size = new System.Drawing.Size(341, 150);
            this.pdCompanyDgv.TabIndex = 2;
            this.pdCompanyDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PdCompanyDgv_CellClick);
            // 
            // PDCompanyName
            // 
            this.PDCompanyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PDCompanyName.DataPropertyName = "PDCompanyName";
            this.PDCompanyName.HeaderText = "PDCompanyName";
            this.PDCompanyName.Name = "PDCompanyName";
            this.PDCompanyName.ReadOnly = true;
            // 
            // pDCompanyIDDataGridViewTextBoxColumn
            // 
            this.pDCompanyIDDataGridViewTextBoxColumn.DataPropertyName = "PDCompanyID";
            this.pDCompanyIDDataGridViewTextBoxColumn.HeaderText = "PDCompanyID";
            this.pDCompanyIDDataGridViewTextBoxColumn.Name = "pDCompanyIDDataGridViewTextBoxColumn";
            this.pDCompanyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDCompanyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productionCompanyBindingSource
            // 
            this.productionCompanyBindingSource.DataSource = typeof(Models.ProductionCompany);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 322);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(160, 20);
            this.toolStripStatusLbl.Text = "toolStripStatusLabel1";
            // 
            // closeFrmBtn
            // 
            this.closeFrmBtn.BackColor = System.Drawing.Color.DarkRed;
            this.closeFrmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFrmBtn.Location = new System.Drawing.Point(771, 3);
            this.closeFrmBtn.Name = "closeFrmBtn";
            this.closeFrmBtn.Size = new System.Drawing.Size(29, 23);
            this.closeFrmBtn.TabIndex = 6;
            this.closeFrmBtn.Text = "X";
            this.closeFrmBtn.UseVisualStyleBackColor = false;
            this.closeFrmBtn.Click += new System.EventHandler(this.CloseFrmBtn_Click);
            // 
            // ProductionCompanyBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 347);
            this.Controls.Add(this.closeFrmBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pdCompanyDgv);
            this.Controls.Add(this.pdCompInfoGrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductionCompanyBrowse";
            this.Text = "ProductionCompanyBrowse";
            this.Load += new System.EventHandler(this.ProductionCompanyBrowse_Load);
            this.pdCompInfoGrp.ResumeLayout(false);
            this.pdCompInfoGrp.PerformLayout();
            this.producedShowsGrp.ResumeLayout(false);
            this.producedShowsGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pdCompanyDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionCompanyBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox pdCompInfoGrp;
        private System.Windows.Forms.Label PdCompDescLbl;
        private System.Windows.Forms.RichTextBox pdCompDescriptionTxt;
        private System.Windows.Forms.Label PdCompNameLbl;
        private System.Windows.Forms.Label pdCompanyResultLbl;
        private System.Windows.Forms.GroupBox producedShowsGrp;
        private System.Windows.Forms.ComboBox producedShowsCmb;
        private System.Windows.Forms.DataGridView pdCompanyDgv;
        private System.Windows.Forms.BindingSource productionCompanyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDCompIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.Button closeFrmBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PDCompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDCompanyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label prodShowsInfoMessage;
    }
}
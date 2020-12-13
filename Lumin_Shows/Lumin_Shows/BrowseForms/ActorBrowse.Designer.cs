namespace Lumin_Shows.BrowseForms
{
    partial class ActorBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActorBrowse));
            this.lNameLbl = new System.Windows.Forms.Label();
            this.fNameLbl = new System.Windows.Forms.Label();
            this.middleNameLbl = new System.Windows.Forms.Label();
            this.ActorInfoGrp = new System.Windows.Forms.GroupBox();
            this.actorStarringShowsGrp = new System.Windows.Forms.GroupBox();
            this.starredShowsInfoMessage = new System.Windows.Forms.Label();
            this.starredShowsCmb = new System.Windows.Forms.ComboBox();
            this.actordobResultLbl = new System.Windows.Forms.Label();
            this.actorDOBLbl = new System.Windows.Forms.Label();
            this.lNameResultLbl = new System.Windows.Forms.Label();
            this.middleNameResultLbl = new System.Windows.Forms.Label();
            this.fNameResultLbl = new System.Windows.Forms.Label();
            this.actorDgv = new System.Windows.Forms.DataGridView();
            this.actorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.middleNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfBirthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.closeFrmBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.ActorInfoGrp.SuspendLayout();
            this.actorStarringShowsGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // ActorInfoGrp
            // 
            this.ActorInfoGrp.BackColor = System.Drawing.Color.DarkGray;
            this.ActorInfoGrp.Controls.Add(this.actorStarringShowsGrp);
            this.ActorInfoGrp.Controls.Add(this.actordobResultLbl);
            this.ActorInfoGrp.Controls.Add(this.actorDOBLbl);
            this.ActorInfoGrp.Controls.Add(this.lNameResultLbl);
            this.ActorInfoGrp.Controls.Add(this.middleNameResultLbl);
            this.ActorInfoGrp.Controls.Add(this.fNameResultLbl);
            this.ActorInfoGrp.Controls.Add(this.middleNameLbl);
            this.ActorInfoGrp.Controls.Add(this.fNameLbl);
            this.ActorInfoGrp.Controls.Add(this.lNameLbl);
            this.ActorInfoGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActorInfoGrp.ForeColor = System.Drawing.Color.Black;
            this.ActorInfoGrp.Location = new System.Drawing.Point(12, 0);
            this.ActorInfoGrp.Name = "ActorInfoGrp";
            this.ActorInfoGrp.Size = new System.Drawing.Size(479, 208);
            this.ActorInfoGrp.TabIndex = 6;
            this.ActorInfoGrp.TabStop = false;
            this.ActorInfoGrp.Text = "Author Information";
            // 
            // actorStarringShowsGrp
            // 
            this.actorStarringShowsGrp.Controls.Add(this.starredShowsInfoMessage);
            this.actorStarringShowsGrp.Controls.Add(this.starredShowsCmb);
            this.actorStarringShowsGrp.Location = new System.Drawing.Point(273, 40);
            this.actorStarringShowsGrp.Name = "actorStarringShowsGrp";
            this.actorStarringShowsGrp.Size = new System.Drawing.Size(200, 100);
            this.actorStarringShowsGrp.TabIndex = 8;
            this.actorStarringShowsGrp.TabStop = false;
            this.actorStarringShowsGrp.Text = "Starring Shows";
            // 
            // starredShowsInfoMessage
            // 
            this.starredShowsInfoMessage.AutoSize = true;
            this.starredShowsInfoMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starredShowsInfoMessage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.starredShowsInfoMessage.Location = new System.Drawing.Point(13, 69);
            this.starredShowsInfoMessage.Name = "starredShowsInfoMessage";
            this.starredShowsInfoMessage.Size = new System.Drawing.Size(156, 18);
            this.starredShowsInfoMessage.TabIndex = 2;
            this.starredShowsInfoMessage.Text = "No Shows available";
            // 
            // starredShowsCmb
            // 
            this.starredShowsCmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.starredShowsCmb.FormattingEnabled = true;
            this.starredShowsCmb.Location = new System.Drawing.Point(16, 34);
            this.starredShowsCmb.Name = "starredShowsCmb";
            this.starredShowsCmb.Size = new System.Drawing.Size(170, 24);
            this.starredShowsCmb.TabIndex = 0;
            // 
            // actordobResultLbl
            // 
            this.actordobResultLbl.AutoSize = true;
            this.actordobResultLbl.Location = new System.Drawing.Point(142, 157);
            this.actordobResultLbl.Name = "actordobResultLbl";
            this.actordobResultLbl.Size = new System.Drawing.Size(51, 16);
            this.actordobResultLbl.TabIndex = 7;
            this.actordobResultLbl.Text = "label3";
            // 
            // actorDOBLbl
            // 
            this.actorDOBLbl.AutoSize = true;
            this.actorDOBLbl.Location = new System.Drawing.Point(7, 157);
            this.actorDOBLbl.Name = "actorDOBLbl";
            this.actorDOBLbl.Size = new System.Drawing.Size(61, 16);
            this.actorDOBLbl.TabIndex = 6;
            this.actorDOBLbl.Text = "Born on";
            // 
            // lNameResultLbl
            // 
            this.lNameResultLbl.AutoSize = true;
            this.lNameResultLbl.Location = new System.Drawing.Point(142, 112);
            this.lNameResultLbl.Name = "lNameResultLbl";
            this.lNameResultLbl.Size = new System.Drawing.Size(51, 16);
            this.lNameResultLbl.TabIndex = 5;
            this.lNameResultLbl.Text = "label3";
            // 
            // middleNameResultLbl
            // 
            this.middleNameResultLbl.AutoSize = true;
            this.middleNameResultLbl.Location = new System.Drawing.Point(142, 76);
            this.middleNameResultLbl.Name = "middleNameResultLbl";
            this.middleNameResultLbl.Size = new System.Drawing.Size(51, 16);
            this.middleNameResultLbl.TabIndex = 4;
            this.middleNameResultLbl.Text = "label2";
            // 
            // fNameResultLbl
            // 
            this.fNameResultLbl.AutoSize = true;
            this.fNameResultLbl.Location = new System.Drawing.Point(142, 40);
            this.fNameResultLbl.Name = "fNameResultLbl";
            this.fNameResultLbl.Size = new System.Drawing.Size(51, 16);
            this.fNameResultLbl.TabIndex = 3;
            this.fNameResultLbl.Text = "label1";
            // 
            // actorDgv
            // 
            this.actorDgv.AllowUserToAddRows = false;
            this.actorDgv.AllowUserToDeleteRows = false;
            this.actorDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actorDgv.AutoGenerateColumns = false;
            this.actorDgv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.actorDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.actorDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.actorIDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.middleNameDataGridViewTextBoxColumn,
            this.fullNameDataGridViewTextBoxColumn,
            this.dateOfBirthDataGridViewTextBoxColumn});
            this.actorDgv.DataSource = this.actorBindingSource;
            this.actorDgv.Location = new System.Drawing.Point(506, 46);
            this.actorDgv.Name = "actorDgv";
            this.actorDgv.ReadOnly = true;
            this.actorDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.actorDgv.Size = new System.Drawing.Size(422, 150);
            this.actorDgv.TabIndex = 7;
            this.actorDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActorListDgv_CellClick);
            // 
            // actorIDDataGridViewTextBoxColumn
            // 
            this.actorIDDataGridViewTextBoxColumn.DataPropertyName = "ActorID";
            this.actorIDDataGridViewTextBoxColumn.HeaderText = "ActorID";
            this.actorIDDataGridViewTextBoxColumn.Name = "actorIDDataGridViewTextBoxColumn";
            this.actorIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.actorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // middleNameDataGridViewTextBoxColumn
            // 
            this.middleNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.middleNameDataGridViewTextBoxColumn.DataPropertyName = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.HeaderText = "MiddleName";
            this.middleNameDataGridViewTextBoxColumn.Name = "middleNameDataGridViewTextBoxColumn";
            this.middleNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fullNameDataGridViewTextBoxColumn
            // 
            this.fullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName";
            this.fullNameDataGridViewTextBoxColumn.HeaderText = "FullName";
            this.fullNameDataGridViewTextBoxColumn.Name = "fullNameDataGridViewTextBoxColumn";
            this.fullNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fullNameDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            this.dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            this.dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            this.dateOfBirthDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateOfBirthDataGridViewTextBoxColumn.Visible = false;
            // 
            // actorBindingSource
            // 
            this.actorBindingSource.DataSource = typeof(Models.Actor);
            // 
            // closeFrmBtn
            // 
            this.closeFrmBtn.BackColor = System.Drawing.Color.DarkRed;
            this.closeFrmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeFrmBtn.Location = new System.Drawing.Point(911, 0);
            this.closeFrmBtn.Name = "closeFrmBtn";
            this.closeFrmBtn.Size = new System.Drawing.Size(36, 23);
            this.closeFrmBtn.TabIndex = 9;
            this.closeFrmBtn.Tag = "closeFormBtn";
            this.closeFrmBtn.Text = "X";
            this.closeFrmBtn.UseVisualStyleBackColor = false;
            this.closeFrmBtn.Click += new System.EventHandler(this.CloseFrmBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 211);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(949, 25);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLbl
            // 
            this.toolStripStatusLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.toolStripStatusLbl.Name = "toolStripStatusLbl";
            this.toolStripStatusLbl.Size = new System.Drawing.Size(160, 20);
            this.toolStripStatusLbl.Text = "toolStripStatusLabel1";
            // 
            // ActorBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(949, 236);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.closeFrmBtn);
            this.Controls.Add(this.actorDgv);
            this.Controls.Add(this.ActorInfoGrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActorBrowse";
            this.Text = "ActorBrowse";
            this.Load += new System.EventHandler(this.ActorBrowse_Load);
            this.ActorInfoGrp.ResumeLayout(false);
            this.ActorInfoGrp.PerformLayout();
            this.actorStarringShowsGrp.ResumeLayout(false);
            this.actorStarringShowsGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.actorDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actorBindingSource)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lNameLbl;
        private System.Windows.Forms.Label fNameLbl;
        private System.Windows.Forms.Label middleNameLbl;
        private System.Windows.Forms.GroupBox ActorInfoGrp;
        private System.Windows.Forms.Label actorDOBLbl;
        private System.Windows.Forms.Label lNameResultLbl;
        private System.Windows.Forms.Label middleNameResultLbl;
        private System.Windows.Forms.Label fNameResultLbl;
        private System.Windows.Forms.Label actordobResultLbl;
        private System.Windows.Forms.DataGridView actorDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn actorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn middleNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource actorBindingSource;
        private System.Windows.Forms.GroupBox actorStarringShowsGrp;
        private System.Windows.Forms.ComboBox starredShowsCmb;
        private System.Windows.Forms.Button closeFrmBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.Label starredShowsInfoMessage;
    }
}
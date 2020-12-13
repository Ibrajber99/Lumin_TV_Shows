namespace Lumin_Shows.Browse_Forms
{
    partial class TVShowsBrowse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TVShowsBrowse));
            this.ShowInfoGrp = new System.Windows.Forms.GroupBox();
            this.prodCompPicBox = new System.Windows.Forms.PictureBox();
            this.releaseDatePicBox = new System.Windows.Forms.PictureBox();
            this.showNamePicBox = new System.Windows.Forms.PictureBox();
            this.showReleaseDateResultLbl = new System.Windows.Forms.Label();
            this.tvShowNameResultLbl = new System.Windows.Forms.Label();
            this.seasonResultLbl = new System.Windows.Forms.Label();
            this.pdCompResultLbl = new System.Windows.Forms.Label();
            this.showCastGrp = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TvShowDescriptionTxt = new System.Windows.Forms.RichTextBox();
            this.showSpecsGrp = new System.Windows.Forms.GroupBox();
            this.streamingPlatPicBox = new System.Windows.Forms.PictureBox();
            this.showPlatformresultLbl = new System.Windows.Forms.Label();
            this.ratingPicBox = new System.Windows.Forms.PictureBox();
            this.generePicBox = new System.Windows.Forms.PictureBox();
            this.showRatingResultLbl = new System.Windows.Forms.Label();
            this.showGenreResultLbl = new System.Windows.Forms.Label();
            this.seasonsLBl = new System.Windows.Forms.Label();
            this.tvShowsDgv = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.infoToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.closeFrmBtn = new System.Windows.Forms.Button();
            this.showCastLstBox = new System.Windows.Forms.ListBox();
            this.showIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numOfSeasonsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDCompanyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.platformIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tVShowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ShowInfoGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodCompPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseDatePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showNamePicBox)).BeginInit();
            this.showCastGrp.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.showSpecsGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamingPlatPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvShowsDgv)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tVShowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ShowInfoGrp
            // 
            this.ShowInfoGrp.BackColor = System.Drawing.Color.White;
            this.ShowInfoGrp.Controls.Add(this.prodCompPicBox);
            this.ShowInfoGrp.Controls.Add(this.releaseDatePicBox);
            this.ShowInfoGrp.Controls.Add(this.showNamePicBox);
            this.ShowInfoGrp.Controls.Add(this.showReleaseDateResultLbl);
            this.ShowInfoGrp.Controls.Add(this.tvShowNameResultLbl);
            this.ShowInfoGrp.Controls.Add(this.seasonResultLbl);
            this.ShowInfoGrp.Controls.Add(this.pdCompResultLbl);
            this.ShowInfoGrp.Controls.Add(this.showCastGrp);
            this.ShowInfoGrp.Controls.Add(this.groupBox3);
            this.ShowInfoGrp.Controls.Add(this.showSpecsGrp);
            this.ShowInfoGrp.Controls.Add(this.seasonsLBl);
            this.ShowInfoGrp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowInfoGrp.Location = new System.Drawing.Point(0, 1);
            this.ShowInfoGrp.Name = "ShowInfoGrp";
            this.ShowInfoGrp.Size = new System.Drawing.Size(725, 547);
            this.ShowInfoGrp.TabIndex = 2;
            this.ShowInfoGrp.TabStop = false;
            this.ShowInfoGrp.Text = "Show Information";
            // 
            // prodCompPicBox
            // 
            this.prodCompPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prodCompPicBox.BackgroundImage")));
            this.prodCompPicBox.Location = new System.Drawing.Point(415, 75);
            this.prodCompPicBox.Name = "prodCompPicBox";
            this.prodCompPicBox.Size = new System.Drawing.Size(34, 34);
            this.prodCompPicBox.TabIndex = 17;
            this.prodCompPicBox.TabStop = false;
            this.prodCompPicBox.Tag = "ProductionCompLogo";
            this.prodCompPicBox.MouseHover += new System.EventHandler(this.ShowMessageOnPicBoxMouseHover);
            // 
            // releaseDatePicBox
            // 
            this.releaseDatePicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("releaseDatePicBox.BackgroundImage")));
            this.releaseDatePicBox.Location = new System.Drawing.Point(415, 31);
            this.releaseDatePicBox.Name = "releaseDatePicBox";
            this.releaseDatePicBox.Size = new System.Drawing.Size(34, 34);
            this.releaseDatePicBox.TabIndex = 16;
            this.releaseDatePicBox.TabStop = false;
            this.releaseDatePicBox.Tag = "releaseDateLogo";
            this.releaseDatePicBox.MouseHover += new System.EventHandler(this.ShowMessageOnPicBoxMouseHover);
            // 
            // showNamePicBox
            // 
            this.showNamePicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showNamePicBox.BackgroundImage")));
            this.showNamePicBox.Location = new System.Drawing.Point(12, 35);
            this.showNamePicBox.Name = "showNamePicBox";
            this.showNamePicBox.Size = new System.Drawing.Size(28, 30);
            this.showNamePicBox.TabIndex = 15;
            this.showNamePicBox.TabStop = false;
            this.showNamePicBox.Tag = "showNamelogo";
            this.showNamePicBox.MouseHover += new System.EventHandler(this.ShowMessageOnPicBoxMouseHover);
            // 
            // showReleaseDateResultLbl
            // 
            this.showReleaseDateResultLbl.AutoSize = true;
            this.showReleaseDateResultLbl.Location = new System.Drawing.Point(479, 49);
            this.showReleaseDateResultLbl.Name = "showReleaseDateResultLbl";
            this.showReleaseDateResultLbl.Size = new System.Drawing.Size(47, 16);
            this.showReleaseDateResultLbl.TabIndex = 14;
            this.showReleaseDateResultLbl.Text = "Label";
            // 
            // tvShowNameResultLbl
            // 
            this.tvShowNameResultLbl.AutoSize = true;
            this.tvShowNameResultLbl.Location = new System.Drawing.Point(93, 49);
            this.tvShowNameResultLbl.Name = "tvShowNameResultLbl";
            this.tvShowNameResultLbl.Size = new System.Drawing.Size(47, 16);
            this.tvShowNameResultLbl.TabIndex = 13;
            this.tvShowNameResultLbl.Text = "Label";
            // 
            // seasonResultLbl
            // 
            this.seasonResultLbl.AutoSize = true;
            this.seasonResultLbl.Location = new System.Drawing.Point(93, 93);
            this.seasonResultLbl.Name = "seasonResultLbl";
            this.seasonResultLbl.Size = new System.Drawing.Size(47, 16);
            this.seasonResultLbl.TabIndex = 12;
            this.seasonResultLbl.Text = "Label";
            // 
            // pdCompResultLbl
            // 
            this.pdCompResultLbl.AutoSize = true;
            this.pdCompResultLbl.Location = new System.Drawing.Point(479, 93);
            this.pdCompResultLbl.Name = "pdCompResultLbl";
            this.pdCompResultLbl.Size = new System.Drawing.Size(47, 16);
            this.pdCompResultLbl.TabIndex = 11;
            this.pdCompResultLbl.Text = "Label";
            // 
            // showCastGrp
            // 
            this.showCastGrp.Controls.Add(this.showCastLstBox);
            this.showCastGrp.Location = new System.Drawing.Point(504, 279);
            this.showCastGrp.Name = "showCastGrp";
            this.showCastGrp.Size = new System.Drawing.Size(203, 145);
            this.showCastGrp.TabIndex = 5;
            this.showCastGrp.TabStop = false;
            this.showCastGrp.Text = "Show Cast";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TvShowDescriptionTxt);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(26, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 125);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Description";
            // 
            // TvShowDescriptionTxt
            // 
            this.TvShowDescriptionTxt.Location = new System.Drawing.Point(15, 23);
            this.TvShowDescriptionTxt.Name = "TvShowDescriptionTxt";
            this.TvShowDescriptionTxt.ReadOnly = true;
            this.TvShowDescriptionTxt.Size = new System.Drawing.Size(672, 96);
            this.TvShowDescriptionTxt.TabIndex = 0;
            this.TvShowDescriptionTxt.Tag = "description";
            this.TvShowDescriptionTxt.Text = "";
            // 
            // showSpecsGrp
            // 
            this.showSpecsGrp.Controls.Add(this.streamingPlatPicBox);
            this.showSpecsGrp.Controls.Add(this.showPlatformresultLbl);
            this.showSpecsGrp.Controls.Add(this.ratingPicBox);
            this.showSpecsGrp.Controls.Add(this.generePicBox);
            this.showSpecsGrp.Controls.Add(this.showRatingResultLbl);
            this.showSpecsGrp.Controls.Add(this.showGenreResultLbl);
            this.showSpecsGrp.Location = new System.Drawing.Point(26, 279);
            this.showSpecsGrp.Name = "showSpecsGrp";
            this.showSpecsGrp.Size = new System.Drawing.Size(472, 251);
            this.showSpecsGrp.TabIndex = 8;
            this.showSpecsGrp.TabStop = false;
            this.showSpecsGrp.Text = "SPECIFICATIONS";
            // 
            // streamingPlatPicBox
            // 
            this.streamingPlatPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("streamingPlatPicBox.BackgroundImage")));
            this.streamingPlatPicBox.Location = new System.Drawing.Point(33, 180);
            this.streamingPlatPicBox.Name = "streamingPlatPicBox";
            this.streamingPlatPicBox.Size = new System.Drawing.Size(62, 52);
            this.streamingPlatPicBox.TabIndex = 22;
            this.streamingPlatPicBox.TabStop = false;
            this.streamingPlatPicBox.Tag = "streamingPlatformLogo";
            this.streamingPlatPicBox.MouseHover += new System.EventHandler(this.ShowMessageOnPicBoxMouseHover);
            // 
            // showPlatformresultLbl
            // 
            this.showPlatformresultLbl.AutoSize = true;
            this.showPlatformresultLbl.Location = new System.Drawing.Point(143, 216);
            this.showPlatformresultLbl.Name = "showPlatformresultLbl";
            this.showPlatformresultLbl.Size = new System.Drawing.Size(47, 16);
            this.showPlatformresultLbl.TabIndex = 21;
            this.showPlatformresultLbl.Text = "Label";
            // 
            // ratingPicBox
            // 
            this.ratingPicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ratingPicBox.BackgroundImage")));
            this.ratingPicBox.Location = new System.Drawing.Point(33, 95);
            this.ratingPicBox.Name = "ratingPicBox";
            this.ratingPicBox.Size = new System.Drawing.Size(62, 50);
            this.ratingPicBox.TabIndex = 20;
            this.ratingPicBox.TabStop = false;
            this.ratingPicBox.Tag = "ratingLogo";
            this.ratingPicBox.MouseHover += new System.EventHandler(this.ShowMessageOnPicBoxMouseHover);
            // 
            // generePicBox
            // 
            this.generePicBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("generePicBox.BackgroundImage")));
            this.generePicBox.Location = new System.Drawing.Point(33, 21);
            this.generePicBox.Name = "generePicBox";
            this.generePicBox.Size = new System.Drawing.Size(62, 52);
            this.generePicBox.TabIndex = 19;
            this.generePicBox.TabStop = false;
            this.generePicBox.Tag = "genreLogo";
            this.generePicBox.MouseHover += new System.EventHandler(this.ShowMessageOnPicBoxMouseHover);
            // 
            // showRatingResultLbl
            // 
            this.showRatingResultLbl.AutoSize = true;
            this.showRatingResultLbl.Location = new System.Drawing.Point(143, 129);
            this.showRatingResultLbl.Name = "showRatingResultLbl";
            this.showRatingResultLbl.Size = new System.Drawing.Size(47, 16);
            this.showRatingResultLbl.TabIndex = 13;
            this.showRatingResultLbl.Text = "Label";
            // 
            // showGenreResultLbl
            // 
            this.showGenreResultLbl.AutoSize = true;
            this.showGenreResultLbl.Location = new System.Drawing.Point(143, 57);
            this.showGenreResultLbl.Name = "showGenreResultLbl";
            this.showGenreResultLbl.Size = new System.Drawing.Size(47, 16);
            this.showGenreResultLbl.TabIndex = 12;
            this.showGenreResultLbl.Text = "Label";
            // 
            // seasonsLBl
            // 
            this.seasonsLBl.AutoSize = true;
            this.seasonsLBl.Location = new System.Drawing.Point(7, 93);
            this.seasonsLBl.Name = "seasonsLBl";
            this.seasonsLBl.Size = new System.Drawing.Size(80, 16);
            this.seasonsLBl.TabIndex = 2;
            this.seasonsLBl.Text = "SEASONS";
            // 
            // tvShowsDgv
            // 
            this.tvShowsDgv.AllowUserToAddRows = false;
            this.tvShowsDgv.AllowUserToDeleteRows = false;
            this.tvShowsDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvShowsDgv.AutoGenerateColumns = false;
            this.tvShowsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tvShowsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.showIDDataGridViewTextBoxColumn,
            this.showNameDataGridViewTextBoxColumn,
            this.releaseDateDataGridViewTextBoxColumn,
            this.showDescriptionDataGridViewTextBoxColumn,
            this.numOfSeasonsDataGridViewTextBoxColumn,
            this.pDCompanyIDDataGridViewTextBoxColumn,
            this.genreIDDataGridViewTextBoxColumn,
            this.ratingIDDataGridViewTextBoxColumn,
            this.platformIDDataGridViewTextBoxColumn});
            this.tvShowsDgv.DataSource = this.tVShowBindingSource;
            this.tvShowsDgv.Location = new System.Drawing.Point(731, 109);
            this.tvShowsDgv.Name = "tvShowsDgv";
            this.tvShowsDgv.ReadOnly = true;
            this.tvShowsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tvShowsDgv.Size = new System.Drawing.Size(335, 150);
            this.tvShowsDgv.TabIndex = 3;
            this.tvShowsDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TvShowsDgvCellClickAction);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1066, 25);
            this.statusStrip1.TabIndex = 4;
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
            this.closeFrmBtn.Location = new System.Drawing.Point(1037, 1);
            this.closeFrmBtn.Name = "closeFrmBtn";
            this.closeFrmBtn.Size = new System.Drawing.Size(29, 23);
            this.closeFrmBtn.TabIndex = 5;
            this.closeFrmBtn.Text = "X";
            this.closeFrmBtn.UseVisualStyleBackColor = false;
            this.closeFrmBtn.Click += new System.EventHandler(this.CloseFormBtnAction);
            // 
            // showCastLstBox
            // 
            this.showCastLstBox.FormattingEnabled = true;
            this.showCastLstBox.ItemHeight = 16;
            this.showCastLstBox.Location = new System.Drawing.Point(6, 33);
            this.showCastLstBox.Name = "showCastLstBox";
            this.showCastLstBox.Size = new System.Drawing.Size(191, 100);
            this.showCastLstBox.TabIndex = 18;
            // 
            // showIDDataGridViewTextBoxColumn
            // 
            this.showIDDataGridViewTextBoxColumn.DataPropertyName = "ShowID";
            this.showIDDataGridViewTextBoxColumn.HeaderText = "ShowID";
            this.showIDDataGridViewTextBoxColumn.Name = "showIDDataGridViewTextBoxColumn";
            this.showIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.showIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // showNameDataGridViewTextBoxColumn
            // 
            this.showNameDataGridViewTextBoxColumn.DataPropertyName = "ShowName";
            this.showNameDataGridViewTextBoxColumn.HeaderText = "ShowName";
            this.showNameDataGridViewTextBoxColumn.Name = "showNameDataGridViewTextBoxColumn";
            this.showNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // releaseDateDataGridViewTextBoxColumn
            // 
            this.releaseDateDataGridViewTextBoxColumn.DataPropertyName = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.HeaderText = "ReleaseDate";
            this.releaseDateDataGridViewTextBoxColumn.Name = "releaseDateDataGridViewTextBoxColumn";
            this.releaseDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.releaseDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // showDescriptionDataGridViewTextBoxColumn
            // 
            this.showDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.showDescriptionDataGridViewTextBoxColumn.DataPropertyName = "ShowDescription";
            this.showDescriptionDataGridViewTextBoxColumn.HeaderText = "ShowDescription";
            this.showDescriptionDataGridViewTextBoxColumn.Name = "showDescriptionDataGridViewTextBoxColumn";
            this.showDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numOfSeasonsDataGridViewTextBoxColumn
            // 
            this.numOfSeasonsDataGridViewTextBoxColumn.DataPropertyName = "NumOfSeasons";
            this.numOfSeasonsDataGridViewTextBoxColumn.HeaderText = "NumOfSeasons";
            this.numOfSeasonsDataGridViewTextBoxColumn.Name = "numOfSeasonsDataGridViewTextBoxColumn";
            this.numOfSeasonsDataGridViewTextBoxColumn.ReadOnly = true;
            this.numOfSeasonsDataGridViewTextBoxColumn.Visible = false;
            // 
            // pDCompanyIDDataGridViewTextBoxColumn
            // 
            this.pDCompanyIDDataGridViewTextBoxColumn.DataPropertyName = "PDCompanyID";
            this.pDCompanyIDDataGridViewTextBoxColumn.HeaderText = "PDCompanyID";
            this.pDCompanyIDDataGridViewTextBoxColumn.Name = "pDCompanyIDDataGridViewTextBoxColumn";
            this.pDCompanyIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.pDCompanyIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // genreIDDataGridViewTextBoxColumn
            // 
            this.genreIDDataGridViewTextBoxColumn.DataPropertyName = "GenreID";
            this.genreIDDataGridViewTextBoxColumn.HeaderText = "GenreID";
            this.genreIDDataGridViewTextBoxColumn.Name = "genreIDDataGridViewTextBoxColumn";
            this.genreIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.genreIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ratingIDDataGridViewTextBoxColumn
            // 
            this.ratingIDDataGridViewTextBoxColumn.DataPropertyName = "RatingID";
            this.ratingIDDataGridViewTextBoxColumn.HeaderText = "RatingID";
            this.ratingIDDataGridViewTextBoxColumn.Name = "ratingIDDataGridViewTextBoxColumn";
            this.ratingIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ratingIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // platformIDDataGridViewTextBoxColumn
            // 
            this.platformIDDataGridViewTextBoxColumn.DataPropertyName = "PlatformID";
            this.platformIDDataGridViewTextBoxColumn.HeaderText = "PlatformID";
            this.platformIDDataGridViewTextBoxColumn.Name = "platformIDDataGridViewTextBoxColumn";
            this.platformIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.platformIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tVShowBindingSource
            // 
            this.tVShowBindingSource.DataSource = typeof(Models.TVShow);
            // 
            // TVShowsBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1066, 576);
            this.Controls.Add(this.closeFrmBtn);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tvShowsDgv);
            this.Controls.Add(this.ShowInfoGrp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TVShowsBrowse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Browse TV Shows";
            this.Load += new System.EventHandler(this.TVShowsBrowse_Load);
            this.ShowInfoGrp.ResumeLayout(false);
            this.ShowInfoGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodCompPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.releaseDatePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showNamePicBox)).EndInit();
            this.showCastGrp.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.showSpecsGrp.ResumeLayout(false);
            this.showSpecsGrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.streamingPlatPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ratingPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tvShowsDgv)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tVShowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn showTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showSeasonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn producCompIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox ShowInfoGrp;
        private System.Windows.Forms.Label pdCompResultLbl;
        private System.Windows.Forms.GroupBox showCastGrp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox TvShowDescriptionTxt;
        private System.Windows.Forms.GroupBox showSpecsGrp;
        private System.Windows.Forms.Label seasonsLBl;
        private System.Windows.Forms.Label seasonResultLbl;
        private System.Windows.Forms.Label tvShowNameResultLbl;
        private System.Windows.Forms.Label showRatingResultLbl;
        private System.Windows.Forms.Label showGenreResultLbl;
        private System.Windows.Forms.Label showReleaseDateResultLbl;
        private System.Windows.Forms.DataGridView tvShowsDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn showIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn showDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numOfSeasonsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDCompanyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn platformIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tVShowBindingSource;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl;
        private System.Windows.Forms.PictureBox showNamePicBox;
        private System.Windows.Forms.PictureBox prodCompPicBox;
        private System.Windows.Forms.PictureBox releaseDatePicBox;
        private System.Windows.Forms.PictureBox ratingPicBox;
        private System.Windows.Forms.PictureBox generePicBox;
        private System.Windows.Forms.Label showPlatformresultLbl;
        private System.Windows.Forms.PictureBox streamingPlatPicBox;
        private System.Windows.Forms.ToolTip infoToolTip;
        private System.Windows.Forms.Button closeFrmBtn;
        private System.Windows.Forms.ListBox showCastLstBox;
    }
}
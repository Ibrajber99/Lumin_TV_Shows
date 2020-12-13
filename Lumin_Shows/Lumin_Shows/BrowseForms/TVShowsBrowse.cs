using Lumin_Shows.FormHelpers;
using Models;
using SQLFactories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lumin_Shows.Browse_Forms
{
    using FM = FormHelpers.FormHelpers;

    public partial class TVShowsBrowse : Form
    {
        private TVShow currentShow;

        public TVShowsBrowse()
        {
            InitializeComponent();
        }

        #region Form Event Listening Functions
        private void TVShowsBrowse_Load(object sender, EventArgs e)
        {
            try
            {
                ShowInfoGrp.Visible = false;
                InitializeObjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
                "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            FM.SetToolStripMsg("Ready....",
                toolStripStatusLbl, Color.Black);
        }

        private void CloseFormBtnAction(object sender, EventArgs e)
        {
            try
            {
                Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
                "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Event listener to show small message popup when hovernig over picture boxes.
        private void ShowMessageOnPicBoxMouseHover(object sender, EventArgs e)
        {

            try
            {
                var picBox = (PictureBox)sender;

                switch (picBox.Tag)
                {
                    case "showNamelogo":
                        SetToolTipMsg("Show Name", showNamePicBox);
                        break;
                    case "releaseDateLogo":
                        SetToolTipMsg("Release Date", releaseDatePicBox);
                        break;
                    case "ProductionCompLogo":
                        SetToolTipMsg("Production company", prodCompPicBox);
                        break;
                    case "genreLogo":
                        SetToolTipMsg("Genre", generePicBox);
                        break;
                    case "ratingLogo":
                        SetToolTipMsg("Rating", ratingPicBox);
                        break;
                    case "streamingPlatformLogo":
                        SetToolTipMsg("Streaming platform", streamingPlatPicBox);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
                "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TvShowsDgvCellClickAction(object sender, DataGridViewCellEventArgs e)
        {
            ShowInfoGrp.Visible = true;
            try
            {
                currentShow = GetSelectedTVShow();
                FillTvShowFeilds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
                 "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            FM.SetToolStripMsg($"Showing {currentShow.ShowName}",
                toolStripStatusLbl, Color.White);
        }
        #endregion

        #region Getters and Setters
        private TVShow GetSelectedTVShow()
        {
            TVShow tmpTvShow;
            var selectedRow = tvShowsDgv.SelectedRows[0];
            var selectedShow = selectedRow.DataBoundItem;

            if (selectedShow is TVShow)
            {
                tmpTvShow = (TVShow)selectedShow;
                return tmpTvShow;
            }
            return null;
        }

        private async void InitializeObjects()
        {
            currentShow = new TVShow();
            tVShowBindingSource.DataSource = await
                TVShowFactory.CreateTVShowRepo().GetAsyncTVShowsList();
        }

        private void FillTvShowFeilds()
        {
            setShowTextFeilds();

            setShowCastLstBox();
            setProductionCompany();
            setShowGenre();
            setShowRating();
            setShowStreamingPlatfrom();
        }

        private void setShowTextFeilds()
        {
            showReleaseDateResultLbl.Text = currentShow.ReleaseDate.ToString();
            seasonResultLbl.Text = currentShow.NumOfSeasons;
            TvShowDescriptionTxt.Text = currentShow.ShowDescription;
            tvShowNameResultLbl.Text = currentShow.ShowName;
        }

        private void setShowCastLstBox()
        {
            TVShowHelper.SetShowCastlstBox
                (showCastLstBox, currentShow);

        }

        private void setProductionCompany()
        {
            pdCompResultLbl.Text =
                ProductionCompanyFactory.CreateProductionCompanyRepo().
                GetProductionCompanyByID(currentShow.PDCompanyID).PDCompanyName;
        }

        private void setShowGenre()
        {
            showGenreResultLbl.Text =
               ShowGenreFactory.CreateShowGenreRepo().
               GetGenreName(currentShow.GenreID);
        }

        private void setShowRating()
        {
            showRatingResultLbl.Text =
           ShowRatingFactory.CreateShowRatingRepo().
           GetRatingDescription(currentShow.RatingID);
        }

        private void setShowStreamingPlatfrom()
        {
            showPlatformresultLbl.Text =
                StreamingPlatformFactory.CreateStreamingPlatformRepo().
                GetStreamingPlatformName(currentShow.PlatformID);
        }

        private void SetToolTipMsg(string msg, Control ctrl)
        {
            FM.SetStatusToolTipMsg(msg, infoToolTip, ctrl);
        }
        #endregion

    }
}

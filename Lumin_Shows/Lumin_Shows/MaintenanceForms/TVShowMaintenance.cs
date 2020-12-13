using Lumin_Shows.FormHelpers;
using Lumin_Shows.MaintenanceForms;
using Models;
using SQLFactories;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace Lumin_Shows
{
    using FM = FormHelpers.FormHelpers;
    public partial class TVShowMaintenance : Form
    {
        #region Local Scope variables
        private ITVShowRepo tvShowRepo;
        private TVShow currentShow;
        private BindingList<TVShow> TVShowList;
        private int currentRecord;
        private int firstRecord;
        private int lastRecord;
        private FormState formState;
        #endregion

        public TVShowMaintenance()
        {
            InitializeComponent();
        }

        private void TVShowMaintenance_Load(object sender, EventArgs e)
        {
            try
            {
                tvShowRepo = TVShowFactory.CreateTVShowRepo();
                TVShowList = new BindingList<TVShow>
                (tvShowRepo.GetShowsList());

                formState = FormState.View;
                UpdateCurrentFormState();
                UpdateNavigationInToolStrip();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
             "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #region Functions for TV Show Operations
        private void RouteBtnsClickAction(object sender, EventArgs e)
        {

            try
            {
                var btn = (Button)sender;

                switch (btn.Tag)
                {
                    case "addTvShowBtn":
                        formState = FormState.Add;
                        UpdateCurrentFormState();
                        break;
                    case "cancelProcessBtn":
                        formState = FormState.View;
                        UpdateCurrentFormState();
                        break;
                    case "createTvShowBtn":
                        CreateTvShow();
                        break;
                    case "deleteShowBtn":
                        DeleteTvShow();
                        break;
                    case "saveTvShowBtn":
                        SaveTvShow();
                        break;
                    case "addActorBtn":
                        AddActor();
                        break;
                    case "removeActorBtn":
                        DeleteActor();
                        break;
                    case "closeFormBtn":
                        Hide();
                        break;
                }
            }
            catch(Exception ex)
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
            "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CreateTvShow()
        {
            //Validate Show feilds and selected cast
            if (TVShowHelper.ValidateTVShowInputFeilds(errProvider, TvShowTitleTxt, TvShowprodCompCmb,
               TvShowDescriptionTxt, TvShowgenreCmb, TvShowratingCmb, TvShowplatformCmb) &&
               TVShowHelper.ValidateActorSelection(errProvider, currentShow.showCast, actorCmb))
            {
                int rowsAffected = 0;

                SetCurrentShowFromFeilds();
                try
                {
                    rowsAffected = tvShowRepo.Create(currentShow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(),
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (rowsAffected == 1)
                {
                    MessageBox.Show("Record inserted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Something Went Wrong", "Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ClearControlFields();
                UpdatedTVShowList();

                formState = FormState.View;
                UpdateCurrentFormState();
            }
        }

        private void SaveTvShow()
        {
            if (editTvShowBtn.Text.Equals("Save"))
            {
                //Validate Show feilds and selected cast
                if (TVShowHelper.ValidateTVShowInputFeilds(errProvider, TvShowTitleTxt, TvShowprodCompCmb,
                     TvShowDescriptionTxt, TvShowgenreCmb, TvShowratingCmb, TvShowplatformCmb) &&
                     (TVShowHelper.ValidateActorSelection(errProvider, currentShow.showCast, actorCmb)))
                {
                    int rowsAffected = 0;
                    SetCurrentShowFromFeilds();

                    try
                    {
                        rowsAffected = tvShowRepo.Save(currentShow);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.GetType().ToString(),
                        "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("TV Show saved successfully", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong", "Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            formState = FormState.Edit;
            UpdateCurrentFormState();
        }

        private void DeleteTvShow()
        {
            if (TVShowList.Count > 0)
            {
                int rowsAffected = 0;

                try
                {
                    rowsAffected = tvShowRepo.Delete(currentShow);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(),
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Deleting multiple records at once in the stored proc
                //the result wont be 1
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Show Deleted successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ClearControlFields();
                UpdatedTVShowList();

                formState = FormState.View;
                UpdateCurrentFormState();
                FirstRecordBtnAction();
            }
        }

        private void AddActor()
        {
            if (actorCmb.SelectedValue != DBNull.Value)
            {
                if (formState == FormState.Add)
                {
                    AddActorToNewShow();
                }
                else
                {
                    AddActorToExistingShow();
                }
            }
            else
            {
                MessageBox.Show("Pick a Valid selection", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteActor()
        {
            if (insertedActorsCmb.SelectedIndex > -1)
            {
                if (formState == FormState.Edit)
                    RemoveActorFromExistingShow();
                else
                    RemoveActorFromNewShow();

                MessageBox.Show("Actor removed from cast", "Success",
                  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Pick a Valid selection", "Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetCurrentShowFromFeilds()
        {
            TVShowHelper.GetTvShowFromFeilds(TvShowTitleTxt, TvShowReleaseDate,
                TvShowDescriptionTxt, TvShowSeasonsSpinner, TvShowprodCompCmb,
                TvShowgenreCmb, TvShowratingCmb, TvShowplatformCmb, currentShow);

        }

        private void AddActorToExistingShow()
        {
            string targetActorId = actorCmb.SelectedValue.ToString();
            if (currentShow.showCast.Exists(x => x.ActorID == targetActorId))
            {
                MessageBox.Show("Actor has already been added to the Cast", "Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int rowsAffected = 0;

                try
                {
                    rowsAffected = tvShowRepo.
                    AddActorToExistingShow(currentShow, targetActorId);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(),
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (rowsAffected == 1)
                {
                    MessageBox.Show("Actor has been added", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


                UpdatedTVShowList();
                LoadCurrentRecord();
            }

        }

        private void AddActorToNewShow()
        {
            Actor tmpActor = new Actor();
            tmpActor.ActorID = actorCmb.SelectedValue.ToString();
            tmpActor.FullName = actorCmb.Text.ToString();

            if (currentShow.showCast.Exists(x => x.ActorID == tmpActor.ActorID))
            {
                MessageBox.Show("Actor has already been added to the Cast", "Failed",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                currentShow.showCast.Add(tmpActor);
                SetCurrentCast();
                MessageBox.Show("Actor has been added", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemoveActorFromExistingShow()
        {
            try
            {
                string targetActorId = insertedActorsCmb.SelectedValue.ToString();
                tvShowRepo.RemoveActorFromExistingShow(currentShow, targetActorId);

                UpdatedTVShowList();
                LoadCurrentRecord();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
                 "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RemoveActorFromNewShow()
        {
            currentShow.showCast.RemoveAll(actor => actor.ActorID ==
            insertedActorsCmb.SelectedValue.ToString());
            SetCurrentCast();

        }

        private void DetermineShowInfoView()
        {
            if (TVShowList.Count > 0)
            {
                firstRecord = 0;
                lastRecord = TVShowList.Count - 1;
                currentRecord = firstRecord;
                createShowBtn.Visible = false;
                cancelBtn.Enabled = false;
                SetShowInformationGrpAccessability(true);
                LoadCurrentRecord();
            }
            else
            {
                SetShowInformationGrpAccessability(false);
            }
        }

        #endregion


        #region Form state manager and it's helper functions
        private void UpdateCurrentFormState()
        {
            switch (formState)
            {
                case FormState.View:
                    OnFormStateView();
                    break;
                case FormState.Add:
                    OnFormStateAdd();
                    break;
                case FormState.Edit:
                    OnFormStateEdit();
                    break;
            }
        }

        private void OnFormStateAdd()
        {
            currentShow = new TVShow();
            firstRecordBtn.Enabled = false;
            previousRecordBtn.Enabled = false;
            nextRecordBtn.Enabled = false;
            lastRecordBtn.Enabled = false;
            deleteBtn.Enabled = false;
            editTvShowBtn.Enabled = false;
            addTvShowBtn.Enabled = false;
            cancelBtn.Enabled = true;
            createShowBtn.Visible = true;
            ClearSelectedActorsCmb();
            SetShowInformationGrpAccessability(true);
            ClearControlFields();
            FM.SetToolStripMsg("Adding TV Show",
                formStatusStripLbl, Color.Green);
            LoadFrmCmbs();

        }

        private void OnFormStateView()
        {

            addTvShowBtn.Enabled = true;
            firstRecordBtn.Enabled = TVShowList.Count > 0;
            previousRecordBtn.Enabled = TVShowList.Count > 0;
            nextRecordBtn.Enabled = TVShowList.Count > 0;
            lastRecordBtn.Enabled = TVShowList.Count > 0;
            editTvShowBtn.Enabled = TVShowList.Count > 0;
            deleteBtn.Enabled = false;
            cancelBtn.Enabled = false;
            editTvShowBtn.Text = "Edit";
            LoadFrmCmbs();
            DetermineShowInfoView();
            LoadCurrentRecord();
            SetShowInformationGrpAccessability(false);
            UpdateNavigationInToolStrip();
        }

        private void OnFormStateEdit()
        {
            firstRecordBtn.Enabled = false;
            previousRecordBtn.Enabled = false;
            nextRecordBtn.Enabled = false;
            lastRecordBtn.Enabled = false;
            addTvShowBtn.Enabled = false;
            cancelBtn.Enabled = true;
            deleteBtn.Enabled = true;
            editTvShowBtn.Enabled = true;
            editTvShowBtn.Text = "Save";
            SetShowInformationGrpAccessability(true);

            FM.SetToolStripMsg($"Editing {currentShow.ShowName}",
           formStatusStripLbl, Color.DarkTurquoise);
        }
        #endregion


        #region Navigation Handler and all of it's helper methods
        private void Navigation_Handler(object sender, EventArgs e)
        {
            try
            {
                Button b = (Button)sender;
                switch (b.Tag)
                {
                    case "firstButton":
                        FirstRecordBtnAction();
                        break;
                    case "previousButton":
                        PreviousRecordBtnAction();
                        break;
                    case "nextButton":
                        NextRecordBtnAction();
                        break;
                    case "lastButton":
                        LastRecordBtnAction();
                        break;
                }

                NexPrevBtnManagment();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
            "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void FirstRecordBtnAction()
        {
            currentRecord = firstRecord;
            LoadCurrentRecord();
            UpdateNavigationInToolStrip();
        }

        private void LastRecordBtnAction()
        {
            lastRecord = TVShowList.Count - 1;
            currentRecord = lastRecord;
            LoadCurrentRecord();
            UpdateNavigationInToolStrip();
        }

        private void NextRecordBtnAction()
        {
            currentRecord++;
            if (currentRecord > lastRecord)
            {
                currentRecord = lastRecord;
            }
            LoadCurrentRecord();
            UpdateNavigationInToolStrip();
        }

        private void PreviousRecordBtnAction()
        {
            currentRecord--;
            if (currentRecord < firstRecord)
            {
                currentRecord = firstRecord;
            }
            LoadCurrentRecord();
            UpdateNavigationInToolStrip();
        }

        private void NexPrevBtnManagment()
        {
            previousRecordBtn.Enabled = currentRecord > firstRecord;
            nextRecordBtn.Enabled = currentRecord < lastRecord;
        }
        #endregion


        #region Getters and Setters
        private void UpdatedTVShowList()
        {
            try
            {
                TVShowList = new BindingList<TVShow>(tvShowRepo.GetShowsList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
                "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Gets all Show Specifications 
        //and sets them in the comboboxes
        private void LoadFrmCmbs()
        {
            GetUniversalActors();
            GetProdcutionCompanies();
            GetGenres();
            GetRating();
            GetPlatform();
        }

        private void ClearSelectedActorsCmb()
        {
            insertedActorsCmb.DataSource = null;
            insertedActorsCmb.Items.Clear();
        }

        private void GetProdcutionCompanies()
        {
            FM.FillListControl
            (TvShowprodCompCmb, "PDCompanyName", "PDCompanyID",
            ProductionCompanyFactory.CreateProductionCompanyRepo().
            GetProductionCompaniesTable(),
            true, "Select a Production Company");
        }

        private void GetUniversalActors()
        {
            FM.FillListControl(actorCmb, "FullName", "ActorID",
            ActorFactory.CreateActorRepo().GetActorsTable(),
            true, "Select an Actor");
        }

        private void GetGenres()
        {
            FM.FillListControl(TvShowgenreCmb, "GenreName", "GenreID",
            ShowGenreFactory.CreateShowGenreRepo().GetGenres(),
            true, "Select a Genre");
        }

        private void GetRating()
        {
            FM.FillListControl(TvShowratingCmb, "RatingDescription",
            "RatingID",ShowRatingFactory.
            CreateShowRatingRepo().GetRatings(),
            true, "Select a Rating");
        }

        private void GetPlatform()
        {
            FM.FillListControl(TvShowplatformCmb, "PlatformName",
            "PlatformID",StreamingPlatformFactory.
            CreateStreamingPlatformRepo().GetStreamingPlatforms(),
            true, "Select a Platform");
        }

        private void LoadCurrentRecord()
        {
            if (TVShowList.Count > 0)
            {
                currentShow = TVShowList.ElementAt(currentRecord);

                TvShowTitleTxt.Text = currentShow.ShowName;
                TvShowDescriptionTxt.Text = currentShow.ShowDescription;
                SetCurrentGenre(currentShow.GenreID);
                SetCurrentRating(currentShow.RatingID);
                SetCurrentPlatform(currentShow.PlatformID);
                SetCurrentProdCompany(currentShow.PDCompanyID);
                SetCurrentCast();
                SetCurrentReleaseDate();
            }
        }

        //Setters for the Comboboxes when showing an existing show
        private void SetCurrentGenre(string genereValue)
        {
            TvShowgenreCmb.SelectedValue = genereValue;
        }

        private void SetCurrentRating(string ratingValue)
        {
            TvShowratingCmb.SelectedValue = ratingValue;
        }

        private void SetCurrentPlatform(string platformValue)
        {
            TvShowplatformCmb.SelectedValue = platformValue;
        }

        private void SetCurrentProdCompany(string prodCompValue)
        {
            TvShowprodCompCmb.SelectedValue = prodCompValue;
        }

        private void SetCurrentCast()
        {
            TVShowHelper.SetShowCastCmb
                (insertedActorsCmb, currentShow);
        }

        private void SetCurrentReleaseDate()
        {
            TvShowReleaseDate.Value = currentShow.ReleaseDate;
        }

        //Form Controls related functions
        private void SetShowInformationGrpAccessability(bool status)
        {
            ShowInfoGrp.Enabled = status;
        }

        private void UpdateNavigationInToolStrip()
        {
            FM.SetToolStripMsg
            ($"Maintain TV Shows {currentRecord + 1} out of {TVShowList.Count}",
            formStatusStripLbl, Color.DarkOrchid);
        }

        private void SetToolTipMsg(string msg, Control ctrl)
        {
            FM.SetStatusToolTipMsg(msg, infoToolTip, ctrl);
        }

        private void ClearControlFields()
        {
            FM.ClearControls(ShowInfoGrp.Controls);
        }

        #endregion


    }
}

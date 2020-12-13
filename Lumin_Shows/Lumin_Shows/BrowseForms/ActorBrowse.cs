using Lumin_Shows.FormHelpers;
using Models;
using SQLFactories;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lumin_Shows.BrowseForms
{
    using FM = FormHelpers.FormHelpers;

    public partial class ActorBrowse : Form
    {
        private Actor currentActor;
        public ActorBrowse()
        {
            InitializeComponent();
        }

        #region Form Event listening Functions
        private void ActorBrowse_Load(object sender, EventArgs e)
        {
            try
            {
                DisableInitialControlsVisibility();
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

        private void CloseFrmBtn_Click(object sender, EventArgs e)
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

        private void ActorListDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ActorInfoGrp.Visible = true;
            try
            {
                currentActor = GetSelectedActor();
                FillActorFeilds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
                "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FM.SetToolStripMsg($"Showing {currentActor.FullName}",
               toolStripStatusLbl, Color.White);
        }
        #endregion

        #region Getters and Setters
        private async void InitializeObjects()
        {
            currentActor = new Actor();
            actorBindingSource.DataSource = 
                await ActorFactory.CreateActorRepo().GetAsyncActorList();
        }

        private void DisableInitialControlsVisibility()
        {
            starredShowsInfoMessage.Visible = false;
            ActorInfoGrp.Visible = false;
        }

        private Actor GetSelectedActor()
        {
            Actor actorTmp;
            var selectedRow = actorDgv.SelectedRows[0];
            var selectedShow = selectedRow.DataBoundItem;

            if (selectedShow is Actor)
            {
                actorTmp = (Actor)selectedShow;
                return actorTmp;
            }
            return null;
        }

        private void FillActorFeilds()
        {
            setActorTextfeilds();
            setActorSatrredShows();
            DisableCmbifEmpty();
        }

        private void setActorTextfeilds()
        {
            fNameResultLbl.Text = currentActor.FirstName;
            lNameResultLbl.Text = currentActor.LastName;
            actordobResultLbl.Text = currentActor.DateOfBirth.Date.ToShortDateString();

            middleNameResultLbl.Text = String.IsNullOrEmpty
               (currentActor.MiddleName) ? "N/A"
               : currentActor.MiddleName;

        }

        private void setActorSatrredShows()
        {
            ActorHelper.SetActorStarredShowsCmb
            (ActorFactory.CreateActorRepo().GetActorPlayedShows
            (currentActor.ActorID),starredShowsCmb);
        }

        private void DisableCmbifEmpty()
        {
            starredShowsCmb.Visible = starredShowsCmb.Items.Count > 0;
            starredShowsInfoMessage.Visible = starredShowsCmb.Items.Count < 1;
        }
        #endregion

    }
}

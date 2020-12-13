using Models;
using SQLFactories;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Lumin_Shows.FormHelpers;
using Lumin_Shows.MaintenanceForms;

namespace Lumin_Shows
{
    using FM = FormHelpers.FormHelpers;

    public partial class ActorMaintenance : Form
    {
        #region Local scope variables
        private IActorRepo actorRepo;
        private BindingList<Actor> ActorList;
        private Actor currentActor;
        private int currentRecord;
        private int firstRecord;
        private int lastRecord;
        private FormState formState;
        #endregion

        public ActorMaintenance()
        {
            InitializeComponent();

        }
        private void ActorMaintenance_Load(object sender, EventArgs e)
        {
            try
            {
                actorRepo = ActorFactory.CreateActorRepo();
                UpdateActorsList();
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

        #region Functions for Actor Operations
        private void RouteBtnsClickAction(object sender, EventArgs e)
        {
            try
            {
                var btn = (Button)sender;
                switch (btn.Tag)
                {
                    case "addActorBtn":
                        formState = FormState.Add;
                        UpdateCurrentFormState();
                        break;
                    case "cancelProcessBtn":
                        formState = FormState.View;
                        UpdateCurrentFormState();
                        break;
                    case "createActorBtn":
                        CreateActor();
                        break;
                    case "deleteActorBtn":
                        DeleteActor();
                        break;
                    case "saveActorBtn":
                        SaveActor();
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

        private void CreateActor()
        {
            if (ActorHelper.ValidateActorInputFields(fNameTxt, lNameTxt, errProvider))
            {
                SetCurrentActorFromFeilds();
                int rowsAffected = 0;

                try
                {
                    rowsAffected = actorRepo.Create(currentActor);
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

                ClearControlFeilds();
                UpdateActorsList();
                formState = FormState.View;
                UpdateCurrentFormState();

            }
        }

        private void DeleteActor()
        {
            if (ActorList.Count > 0)
            {
                int rowsAffected = 0;

                try
                {
                    rowsAffected = actorRepo.Delete(currentActor);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(),
                     "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //Deleting multiple records at once in the stored proc
                //the result wont be exactly 1
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Actor has been deleted", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete an Acotr. Actor Is starring in TVshow(s)",
                        "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                ClearControlFeilds();
                formState = FormState.View;
                UpdateCurrentFormState();

                FirstRecordBtnAction();
            }
        }

        private void SaveActor()
        {
            if (editActorBtn.Text.Equals("Save"))
            {
                if (ActorHelper.ValidateActorInputFields(fNameTxt, lNameTxt, errProvider))
                {
                    SetCurrentActorFromFeilds();
                    int rowsAffected = 0;

                    try
                    {
                        rowsAffected = actorRepo.Save(currentActor);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.GetType().ToString(),
                         "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Actor saved successfully", "Success",
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

        //checks if actor list is not empty to load the first record
        private void DetermineActorInfoView()
        {
            if (ActorList.Count > 0)
            {
                firstRecord = 0;
                lastRecord = ActorList.Count - 1;
                currentRecord = firstRecord;
                createActorBtn.Visible = false;
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
            currentActor = new Actor();
            firstRecordBtn.Enabled = false;
            previousRecordBtn.Enabled = false;
            nextRecordBtn.Enabled = false;
            lastRecordBtn.Enabled = false;
            deleteBtn.Enabled = false;
            cancelBtn.Enabled = true;
            createActorBtn.Visible = true;
            editActorBtn.Enabled = false;
            addActorBtn.Enabled = false;
            SetShowInformationGrpAccessability(true);
            FM.ClearControls(ActorInfoGrp.Controls);
            FM.SetToolStripMsg("Adding Actor",
                formStatusStripLbl, Color.Green);
        }

        private void OnFormStateView()
        {

            addActorBtn.Enabled = true;
            firstRecordBtn.Enabled = ActorList.Count > 0;
            previousRecordBtn.Enabled = ActorList.Count > 0;
            nextRecordBtn.Enabled = ActorList.Count > 0;
            lastRecordBtn.Enabled = ActorList.Count > 0;
            editActorBtn.Enabled = ActorList.Count > 0;
            deleteBtn.Enabled = false;
            cancelBtn.Enabled = false;
            editActorBtn.Text = "Edit";
            DetermineActorInfoView();
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
            addActorBtn.Enabled = false;
            cancelBtn.Enabled = true;
            deleteBtn.Enabled = true;
            editActorBtn.Enabled = true;
            editActorBtn.Text = "Save";
            SetShowInformationGrpAccessability(true);
            FM.SetToolStripMsg($"Editing {currentActor.FullName}",
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
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
              "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            NexPrevBtnManagment();
        }

        private void SetCurrentActorFromFeilds()
        {
            ActorHelper.GetActorFromFeilds
            (fNameTxt, lNameTxt, middleNameTxt,
            ActorDOBDatePicker, currentActor);
        }

        private void FirstRecordBtnAction()
        {
            currentRecord = firstRecord;
            LoadCurrentRecord();
            UpdateNavigationInToolStrip();
        }

        private void LastRecordBtnAction()
        {
            lastRecord = ActorList.Count - 1;
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
        private void UpdateActorsList()
        {
            try
            {
                ActorList = new BindingList<Actor>
                        ( actorRepo.GetActorsList());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
                "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LoadCurrentRecord()
        {
            if (ActorList.Count > 0)
            {
                currentActor = ActorList.ElementAt(currentRecord);
                fNameTxt.Text = currentActor.FirstName;
                lNameTxt.Text = currentActor.LastName;
                middleNameTxt.Text = currentActor.MiddleName;
                SetActorDOB();
            }
        }

        private void SetShowInformationGrpAccessability(bool status)
        {
            ActorInfoGrp.Enabled = status;
        }

        private void SetActorDOB()
        {
            ActorDOBDatePicker.Value = currentActor.DateOfBirth;
        }

        private void UpdateNavigationInToolStrip()
        {
            FM.SetToolStripMsg
            ($"Maintain TV Shows {currentRecord + 1} out of {ActorList.Count}",
            formStatusStripLbl, Color.White);
        }

        private void ClearControlFeilds()
        {
            FM.ClearControls(ActorInfoGrp.Controls);
        }
        #endregion
    }
}

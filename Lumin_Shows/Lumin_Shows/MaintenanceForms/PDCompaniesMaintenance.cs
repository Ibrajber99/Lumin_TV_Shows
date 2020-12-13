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
    public partial class PDCompaniesMaintenance : Form
    {
        #region Local scope variables
        private IProductionCompanyRepo pdCompanyRepo;
        private BindingList<ProductionCompany> PdCompaniesList;
        private ProductionCompany currentPDCompany;
        private int currentRecord;
        private int firstRecord;
        private int lastRecord;
        private FormState formState;
        #endregion

        public PDCompaniesMaintenance()
        {
            InitializeComponent();
        }

        private void PDCompaniesMaintenance_Load(object sender, EventArgs e)
        {
            try
            {
                pdCompanyRepo = ProductionCompanyFactory.CreateProductionCompanyRepo();
                UpdateProductionCompList();
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

        #region Functions for Production company Operations
        private void RouteBtnsClickAction(object sender, EventArgs e)
        {
            try
            {
                var btn = (Button)sender;

                switch (btn.Tag)
                {
                    case "addProdCompBtn":
                        formState = FormState.Add;
                        UpdateCurrentFormState();
                        break;
                    case "cancelProcessBtn":
                        formState = FormState.View;
                        UpdateCurrentFormState();
                        break;
                    case "createProdCompBtn":
                        CreateProductionCompany();
                        break;
                    case "deleteProdCompBtn":
                        DeleteProductionCompany();
                        break;
                    case "saveProdCompBtn":
                        SaveProductionCompany();
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

        private void CreateProductionCompany()
        {
            if (ProductionCompanyHelper.ValidatePdCompanyFields(pdCompTxt, errProvider))
            {
                SetCurrentPdCompanyFromFeilds();
                int rowsAffected = 0;

                try
                {
                    rowsAffected = pdCompanyRepo.Create(currentPDCompany);
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
                UpdateProductionCompList();

                formState = FormState.View;
                UpdateCurrentFormState();
            }
        }

        private void DeleteProductionCompany()
        {
            if (PdCompaniesList.Count > 0)
            {
                int rowsAffected = 0;

                try
                {
                    rowsAffected = pdCompanyRepo.Delete(currentPDCompany);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(),
                     "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                if (rowsAffected > 0)
                {
                    MessageBox.Show("Production Company has been deleted", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to delete Production Company is associated with existing TV Show(s)",
                        "Fail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                UpdateProductionCompList();
                ClearControlFeilds();

                formState = FormState.View;
                UpdateCurrentFormState();

                FirstRecordBtnAction();
            }
        }

        private void SaveProductionCompany()
        {
            if (editPdCompBtn.Text.Equals("Save"))
            {
                if (ProductionCompanyHelper.ValidatePdCompanyFields(pdCompTxt, errProvider))
                {
                    SetCurrentPdCompanyFromFeilds();
                    int rowsAffected = 0;

                    try
                    {
                        rowsAffected = pdCompanyRepo.Save(currentPDCompany);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.GetType().ToString(),
                         "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    if (rowsAffected == 1)
                    {
                        MessageBox.Show("Production Company saved successfully", "Success",
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

        private void DeterminePdCompanyInfoView()
        {
            if (PdCompaniesList.Count > 0)
            {
                firstRecord = 0;
                lastRecord = PdCompaniesList.Count - 1;
                currentRecord = firstRecord;
                createPdCompBtn.Visible = false;
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
            currentPDCompany = new ProductionCompany();
            firstRecordBtn.Enabled = false;
            previousRecordBtn.Enabled = false;
            nextRecordBtn.Enabled = false;
            lastRecordBtn.Enabled = false;
            deleteBtn.Enabled = false;
            cancelBtn.Enabled = true;
            createPdCompBtn.Visible = true;
            editPdCompBtn.Enabled = false;
            addPdCompBtn.Enabled = false;
            SetShowInformationGrpAccessability(true);
            FM.ClearControls(pdCompInfoGrp.Controls);
            FM.SetToolStripMsg("Adding Production Company",
                formStatusStripLbl, Color.Green);
        }

        private void OnFormStateView()
        {

            addPdCompBtn.Enabled = true;
            firstRecordBtn.Enabled = PdCompaniesList.Count > 0;
            previousRecordBtn.Enabled = PdCompaniesList.Count > 0;
            nextRecordBtn.Enabled = PdCompaniesList.Count > 0;
            lastRecordBtn.Enabled = PdCompaniesList.Count > 0;
            editPdCompBtn.Enabled = PdCompaniesList.Count > 0;
            deleteBtn.Enabled = false;
            cancelBtn.Enabled = false;
            editPdCompBtn.Text = "Edit";
            DeterminePdCompanyInfoView();
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
            addPdCompBtn.Enabled = false;
            cancelBtn.Enabled = true;
            deleteBtn.Enabled = true;
            editPdCompBtn.Enabled = true;
            editPdCompBtn.Text = "Save";
            SetShowInformationGrpAccessability(true);

            FM.SetToolStripMsg($"Editing {currentPDCompany.PDCompanyName}",
           formStatusStripLbl, Color.DarkRed);
        }
        #endregion


        #region  Navigation Handler and all of it's helper methods
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
              "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            
        }

        private void SetCurrentPdCompanyFromFeilds()
        {
            ProductionCompanyHelper.GetPDCompanyFromFeilds
                (pdCompTxt, pdCompDescriptionTxt, currentPDCompany);
        }

        private void FirstRecordBtnAction()
        {
            currentRecord = firstRecord;
            LoadCurrentRecord();
            UpdateNavigationInToolStrip();
        }

        private void LastRecordBtnAction()
        {
            lastRecord = PdCompaniesList.Count - 1;
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

        private void LoadCurrentRecord()
        {
            if (PdCompaniesList.Count > 0)
            {
                currentPDCompany = PdCompaniesList.ElementAt(currentRecord);
                pdCompTxt.Text = currentPDCompany.PDCompanyName;
                pdCompDescriptionTxt.Text = currentPDCompany.Description;
            }
        }
        #endregion


        #region Getters and Setters
        private void UpdateProductionCompList()
        {
            PdCompaniesList = new BindingList<ProductionCompany>
               (pdCompanyRepo.GetProductionCompanies());
        }

        private void SetShowInformationGrpAccessability(bool status)
        {
            pdCompInfoGrp.Enabled = status;
        }

        private void UpdateNavigationInToolStrip()
        {
            FM.SetToolStripMsg
            ($"Maintain TV Shows {currentRecord + 1} out of {PdCompaniesList.Count}",
            formStatusStripLbl, Color.Black);
        }
        private void ClearControlFeilds()
        {
            FM.ClearControls(pdCompInfoGrp.Controls);
        }
        #endregion
    }
}

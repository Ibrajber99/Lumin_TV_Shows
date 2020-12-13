using Lumin_Shows.FormHelpers;
using Models;
using SQLFactories;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace Lumin_Shows.BrowseForms
{

    using FM = FormHelpers.FormHelpers;
    public partial class ProductionCompanyBrowse : Form
    {
        private ProductionCompany currentProdComp;
        public ProductionCompanyBrowse()
        {
            InitializeComponent();
        }

        #region Form Event listening Functions
        private void ProductionCompanyBrowse_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeObjectsAsync();
                DisableInitialControlsVisibility();

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

        private void PdCompanyDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pdCompInfoGrp.Visible = true;
            try
            {
                currentProdComp = GetSelectedProductionComp();
                FillProductionCompanyFeilds();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetType().ToString(),
                "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            FM.SetToolStripMsg
               ($"Showing {currentProdComp.PDCompanyName}",
               toolStripStatusLbl, Color.White);
        }
        #endregion

        #region Getters and Setters
        private async void InitializeObjectsAsync()
        {
            currentProdComp = new ProductionCompany();
            productionCompanyBindingSource.DataSource =await ProductionCompanyFactory.
                CreateProductionCompanyRepo().GetAsyncProdCompanies();
        }

        private void DisableInitialControlsVisibility()
        {
            pdCompInfoGrp.Visible = false;
            prodShowsInfoMessage.Visible = false;
        }

        private ProductionCompany GetSelectedProductionComp()
        {
            ProductionCompany tmpPdComp;
            var selectedRow = pdCompanyDgv.SelectedRows[0];
            var selectedShow = selectedRow.DataBoundItem;

            if (selectedShow is ProductionCompany)
            {
                tmpPdComp = (ProductionCompany)selectedShow;
                return tmpPdComp;
            }
            return null;
        }

        private void FillProductionCompanyFeilds()
        {
            setPdCompTextFeilds();
            setPDCompProducedShows();
            DisableCmbifEmpty();
        }

        private void setPdCompTextFeilds()
        {
            pdCompanyResultLbl.Text = currentProdComp.PDCompanyName;
            pdCompDescriptionTxt.Text = currentProdComp.Description;
        }

        private void setPDCompProducedShows()
        {
            ProductionCompanyHelper.SetProducedShowsCmb(ProductionCompanyFactory.
                CreateProductionCompanyRepo().GetProducedShows(currentProdComp.PDCompanyID),
                producedShowsCmb);
        }

        //Disable the produced shows combo box if no shows available
        private void DisableCmbifEmpty()
        {
            producedShowsCmb.Visible = producedShowsCmb.Items.Count > 0;
            prodShowsInfoMessage.Visible = producedShowsCmb.Items.Count < 1;
        }
        #endregion
    }
}

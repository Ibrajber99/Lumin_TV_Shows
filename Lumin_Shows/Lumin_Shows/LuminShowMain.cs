using Lumin_Shows.SplashScreen;
using Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lumin_Shows
{
    public partial class LuminShowMain : Form
    {
        static User currentUser;
        public LuminShowMain()
        {
            InitializeComponent();
            new LuminShowsSplashScreen().ShowDialog();
            SetUserLableValue();
        }

        private void LuminShowMain_Load(object sender, EventArgs e)
        {
            HideNavBarSubMenus();
        }

        #region Child Forms Related Functions
        private void ShowNewFormBtns(object sender, EventArgs e)
        {
            var m = (Button)sender;
            Form childForm = GetLinkedChildForm(m.Tag.ToString());
            if (childForm != null)
            {
                foreach (Form f in MdiChildren)
                {

                    if (IsSameFormType(f, childForm))
                    {
                        f.Activate();
                        return;
                    }
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
            DetermineChildFormPosition(childForm);
        }

        private void ShowNewFormToolStrips(object sender, EventArgs e)
        {
            var m = (ToolStripMenuItem)sender;
            Form childForm = GetLinkedChildForm(m.Tag.ToString());
            if (childForm != null)
            {
                foreach (Form f in MdiChildren)
                {

                    if (IsSameFormType(f, childForm))
                    {
                        f.Activate();
                        return;
                    }
                }
            }
            childForm.MdiParent = this;
            childForm.Show();
            DetermineChildFormPosition(childForm);
        }

        private Form GetLinkedChildForm(string m)
        {
   
            Form childForm = null;
            ClearChildFroms();
            switch (m)
            {
                case "pdCompaniesMaintain":
                case "pRODUCTIONCOMPANIESToolStripMenuMaintain":
                    childForm = new PDCompaniesMaintenance();
                    childForm.Tag = "pdCompaniesMaintain";
                    break;
                case "tvShowsMaintain":
                case "tVSHOWSToolStripMenuItemMaintain":
                    childForm = new TVShowMaintenance();
                    childForm.Tag = "tvShowsMaintain";
                    break;
                case "actorsMaintain":
                case "aCTORSToolStripMenuMaintain":
                    childForm = new ActorMaintenance();
                    childForm.Tag = "actorsMaintain";
                    break;
                case "tvShowBrowse":
                case "tVSHOWSToolStripMenuItem":
                    childForm = new Browse_Forms.TVShowsBrowse();
                    childForm.Tag = "tvShowBrowse";
                    break;
                case "actorsBrowse":
                case "aCTORSToolStripMenuItem":
                    childForm = new BrowseForms.ActorBrowse();
                    childForm.Tag = "actorsBrowse";
                    break;
                case "pdCompaniesBrowse":
                case "pRODUCTIONCOMPANIESToolStripMenuItem":
                    childForm = new BrowseForms.ProductionCompanyBrowse();
                    childForm.Tag = "pdCompaniesBrowse";
                    break;
            }
            return childForm;
        }

        private void DetermineChildFormPosition(Form childForm)
        {
            switch (childForm.Tag)
            {
                case "pdCompaniesMaintain":
                    childForm.Location = new Point(550, 150);
                    break;
                case "tvShowsMaintain":
                    childForm.Location = new Point(470, 40);
                    break;
                case "actorsMaintain":
                    childForm.Location = new Point(550, 150);
                    break;
                case "tvShowBrowse":
                    childForm.Location = new Point(430, 40);
                    break;
                case "actorsBrowse":
                    childForm.Location = new Point(500, 150);
                    break;
                case "pdCompaniesBrowse":
                    childForm.Location = new Point(500, 150);
                    break;
            }
        }

        private void ClearChildFroms()
        {
            foreach (Form c in MdiChildren)
            {
                c.Close();
            }
        }

        private bool IsSameFormType(Form f, Form childForm)
        {
            return f.GetType() == childForm.GetType();
        }
        #endregion

        #region MDI Parent related Functions
        private void HideNavBarSubMenus()
        {
            childBrowsePanel.Visible = false;
            childMaintainPanel.Visible = false;
        }

        private void BrowseBtn_Click(object sender, EventArgs e)
        {
            childBrowsePanel.Visible = true;
            childMaintainPanel.Visible = false;
        }

        private void MaintainBtn_Click(object sender, EventArgs e)
        {
            childMaintainPanel.Visible = true;
            childBrowsePanel.Visible = false;
        }
        #endregion

        public static void GetUser(User user)
        {
            currentUser = user;
            if(currentUser == null)
            {
                currentUser = new User();
            }
        }

        public void SetUserLableValue()
        {
            if (currentUser != null)
            {
                userNameLbl.Text +=
                    currentUser.UserName.ToUpper();
            }
        }
        

    }
}

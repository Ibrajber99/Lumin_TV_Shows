using Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;



namespace Lumin_Shows.FormHelpers
{
    internal static class ProductionCompanyHelper
    {
        public static void GetPDCompanyFromFeilds
            (TextBox pdCompName, RichTextBox pdCompDescription, ProductionCompany pdComp)
        {
            pdComp.PDCompanyName = pdCompName.Text;
            pdComp.Description = pdCompDescription.Text;
        }

        public static bool ValidatePdCompanyFields
            (TextBox pdCompName,ErrorProvider errProvider)
        {
            if (FormHelpers.checkIfTextEmpty(pdCompName.Text))
            {
                errProvider.SetError(pdCompName, $"{pdCompName.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            return true;
        }

        public static void SetProducedShowsCmb(List<TVShow> tvShowList, ComboBox cmb)
        {
            BindingList<TVShow> producedShows =
             new BindingList<TVShow>(tvShowList);

            cmb.DataSource = producedShows;
            cmb.DisplayMember = "ShowName";
            cmb.ValueMember = "ShowID";
        }
    }
}

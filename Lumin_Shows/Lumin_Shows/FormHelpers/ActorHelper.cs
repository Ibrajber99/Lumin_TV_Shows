using Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;


namespace Lumin_Shows.FormHelpers
{
    internal static class ActorHelper
    {
        public static bool ValidateActorInputFields
            (TextBox firstName,TextBox lastName,ErrorProvider errProvider)
        {

            if (FormHelpers.checkIfTextEmpty(firstName.Text))
            {
                errProvider.SetError(firstName, $"{firstName.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            if (FormHelpers.checkIfTextEmpty(lastName.Text))
            {
                errProvider.SetError(lastName, $"{lastName.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            return true;
        }

        public static void GetActorFromFeilds
            (TextBox firstName, TextBox lastName,TextBox middleName,DateTimePicker dob,Actor actor)
        {
            actor.FirstName = firstName.Text;
            actor.LastName = lastName.Text;
            actor.MiddleName = middleName.Text;
            actor.DateOfBirth = dob.Value;
            actor.FullName = actor.FirstName + ' ' + actor.LastName;
        }

        public static void SetActorStarredShowsCmb(List<TVShow>tvShowList,ComboBox cmb)
        {
            BindingList<TVShow> showCastDS =
             new BindingList<TVShow>(tvShowList);

            cmb.DataSource = showCastDS;
            cmb.DisplayMember = "ShowName";
            cmb.ValueMember = "ShowID";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Models;



namespace Lumin_Shows.FormHelpers
{
    internal static class TVShowHelper
    {
        public static bool ValidateTVShowInputFeilds
            (ErrorProvider errProvider, TextBox showTitle, ComboBox productionCompanCbm
            , RichTextBox description, ComboBox genreCmb, ComboBox ratingCmb,
            ComboBox platformCmb)
        {
            if (FormHelpers.checkIfTextEmpty(showTitle.Text))
            {
                errProvider.SetError(showTitle, $"{showTitle.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            if (FormHelpers.checkIfTextEmpty(description.Text))
            {
                errProvider.SetError(description, $"{description.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            if (FormHelpers.checkComboBoxBindingVal(productionCompanCbm))
            {
                errProvider.SetError(productionCompanCbm, $"{productionCompanCbm.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            if (FormHelpers.checkComboBoxBindingVal(genreCmb))
            {
                errProvider.SetError(genreCmb, $"{genreCmb.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            if (FormHelpers.checkComboBoxBindingVal(ratingCmb))
            {
                errProvider.SetError(ratingCmb, $"{ratingCmb.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            if (FormHelpers.checkComboBoxBindingVal(platformCmb))
            {
                errProvider.SetError(platformCmb, $"{platformCmb.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            return true;
        }

        public static bool ValidateActorSelection
            (ErrorProvider errProvider, List<Actor> castMemebrs,ComboBox actorsList)
        {
            if(castMemebrs.Count < 1)
            {
                errProvider.SetError(actorsList, $"Need 1 Actor to create a Show");
                return false;
            }
            else
            {
                errProvider.Clear();
                return true;
            }
        }

        public static void GetTvShowFromFeilds(TextBox showTitle,DateTimePicker releaseDate, RichTextBox description,
            NumericUpDown showSeasons,ComboBox productionCompanCbm, ComboBox genreCmb, ComboBox ratingCmb,
            ComboBox platformCmb,TVShow currentShow)
        {
            currentShow.ShowName = showTitle.Text;
            currentShow.ReleaseDate = releaseDate.Value;
            currentShow.ShowDescription = description.Text;
            currentShow.NumOfSeasons = showSeasons.Value.ToString();
            currentShow.PDCompanyID = productionCompanCbm.SelectedValue.ToString();
            currentShow.GenreID = genreCmb.SelectedValue.ToString();
            currentShow.RatingID = ratingCmb.SelectedValue.ToString();
            currentShow.PlatformID = platformCmb.SelectedValue.ToString();
        }

        public static void SetShowCastCmb(ComboBox cmb, TVShow show)
        {
            BindingList<Actor> showCastDS =
              new BindingList<Actor>(show.showCast);
            cmb.DataSource = showCastDS;
            cmb.DisplayMember = "FullName";
            cmb.ValueMember = "ActorID";
        }

        internal static void SetShowCastlstBox(ListBox lstBox, TVShow show)
        {
            BindingList<Actor> showCastDS =
              new BindingList<Actor>(show.showCast);
            lstBox.DataSource = showCastDS;
            lstBox.DisplayMember = "FullName";
            lstBox.ValueMember = "ActorID";
        }
    }
}

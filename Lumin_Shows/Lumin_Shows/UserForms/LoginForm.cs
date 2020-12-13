using Lumin_Shows.FormHelpers;
using Lumin_Shows.UserForms;
using Models;
using SQLFactories;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;



namespace Lumin_Shows
{
    public partial class LoginForm : Form
    {
        #region Helpers for allowing darg on borderless form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        public delegate void PassUserData(User currUser);

        private IUserRepo userRepo;
        private User currentUser;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            userRepo = UserFactory.CreateUserRepo();
            currentUser = new User();
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void RouteBtnsClickAction(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Tag)
            {
                case "loginBtn":
                    ValidateUser();
                    break;
                case "registerBtn":
                    OpenRegistrationForm();
                    break;
                case "closeFrmBtn":
                    Close();
                    break;
            }
        }

        private void ValidateUser()
        {
            if (UserHelper.ValidateUserInputFields
               (userNameTxt, userPasswordTxt, errProvider))
            {
                int rowsAffected = 0;
                UserHelper.GetUserFromFields
                    (userNameTxt, userPasswordTxt, currentUser);
                UserHelper.SetUserEncryptedPassword(currentUser);

                try
                {
                    rowsAffected = userRepo.GetUser(currentUser);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(),
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                DetermineRegisterationOutCome(rowsAffected);
            }
        }

        private void DetermineRegisterationOutCome(int rowsAffected)
        {

            if (rowsAffected == 1)
            {
                MessageBox.Show("Welcome to Lumin Shows",
                   "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenLuminShows();
            }
            else
            {
                MessageBox.Show("Something went wrong",
                  "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearControlFeilds();
            }
        }

        private void OpenLuminShows()
        {
            Hide();
            PassUserData passUser = new PassUserData(LuminShowMain.GetUser);
            passUser(currentUser);
            new LuminShowMain().ShowDialog();
            Close();
        }

        private void OpenRegistrationForm()
        {
            Hide();
            new RegisterForm().ShowDialog();
            Close();
        }

        private void ClearControlFeilds()
        {
            FormHelpers.FormHelpers.
                ClearControls(inputsPanel.Controls);
        }

    }
}

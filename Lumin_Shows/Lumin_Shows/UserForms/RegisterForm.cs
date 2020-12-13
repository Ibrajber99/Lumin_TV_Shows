using Lumin_Shows.FormHelpers;
using Models;
using SQLFactories;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace Lumin_Shows.UserForms
{
    public partial class RegisterForm : Form
    {
        #region Helpers for allowing drag on borderless form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        #endregion

        private IUserRepo userRepo;
        private User currentUser;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            userRepo = UserFactory.CreateUserRepo();
            currentUser = new User();
        }

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
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
                case "registerBtn":
                    RegisterUser();
                    break;

                case "closeFrmBtn":
                    Close();
                    break;
            }
        }

        private void RegisterUser()
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
                    rowsAffected = userRepo.Create(currentUser);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.GetType().ToString(),
                    "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                DeterminRegisterationOutCome(rowsAffected);
            }
        }

        private void DeterminRegisterationOutCome(int rowsAffected)
        {
            switch (rowsAffected)
            {
                case 1:
                    MessageBox.Show("Registration Completed",
                    "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    OpenLoginForm();
                    break;
                case -1:
                    MessageBox.Show("Credentials matched our records." +
                        "Please try with different values",
                   "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControlFeilds();
                    break;
                case 0:
                    MessageBox.Show("Something went wrong",
                   "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearControlFeilds();
                    break;
            }
        }

        private void OpenLoginForm()
        {
            Hide();
            new LoginForm().ShowDialog();
            Close();
        }

        private void ClearControlFeilds()
        {
            FormHelpers.FormHelpers.
                ClearControls(inputsPanel.Controls);
        }
    }
}

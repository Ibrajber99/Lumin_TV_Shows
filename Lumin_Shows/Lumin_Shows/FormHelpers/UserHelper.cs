using Models;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;


namespace Lumin_Shows.FormHelpers
{
    internal static class UserHelper
    {
        public static string Encrypt(string password)
        {
            var encryptedPassword = string.Empty;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] data = sha256Hash.ComputeHash
                    (Encoding.UTF8.GetBytes(password));

                foreach (var byteHash in data)
                {
                    encryptedPassword += byteHash.ToString();
                }
                return encryptedPassword;
            }
        }

        public static bool ValidateUserInputFields
           (TextBox userName, TextBox password, ErrorProvider errProvider)
        {

            if (FormHelpers.checkIfTextEmpty(userName.Text))
            {
                errProvider.SetError(userName, $"{userName.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            if (FormHelpers.checkIfTextEmpty(password.Text))
            {
                errProvider.SetError(password, $"{password.Tag} is required");
                return false;
            }
            else
            {
                errProvider.Clear();
            }

            return true;
        }

        public static void GetUserFromFields
            (TextBox userName,TextBox userPassword,User user)
        {
            user.UserName = userName.Text;
            user.Userpassword = userPassword.Text;
        } 

        public static void SetUserEncryptedPassword(User user)
        {
            user.Userpassword = Encrypt(user.Userpassword);
        }
    }
}

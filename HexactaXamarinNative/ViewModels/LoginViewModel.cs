using System;
using System.Threading.Tasks;
using System.Windows.Input;
using HexactaXamarinNative;

namespace Frontend.Core.Areas.Login.ViewModel
{
    public class LoginViewModel  
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public ICommand LoginCommand { get; set; }

        public LoginViewModel()
        {
            LoginCommand = new Command(DoLogin);
        }

        public void ValidateUsernameInput()
        {
        }

        public void ValidatePasswordInput()
        {
        }

        private void InitValidations()
        {
        }

        private void DoLogin()
        {
           
        }
    }
}

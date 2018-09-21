using Android.App;
using Android.OS;
using Frontend.Core.Areas.Login.ViewModel;

namespace HexactaXamarinNative.Droid.Activities
{
    [Activity(Label = "LoginActivity")]
    public class LoginActivity : Activity
    {
        private readonly LoginViewModel loginViewModel;

        public LoginActivity()
        {
            this.loginViewModel = new LoginViewModel();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);

            // Create your application here
        }
    }
}

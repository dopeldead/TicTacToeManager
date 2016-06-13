using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using TicTacToeManager.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToeManager.Droid
{
	[Activity (Label = "TicTacToeManager.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
            if (!DataContext.Init())
            {
                throw new InvalidOperationException("Couldn't load Json");
            }
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);
            FindViewById<EditText>(Resource.Id.Main_EditText_userName).Text = Settings.UserName;
            FindViewById<Button>(Resource.Id.Main_Button_LogIn).Click += TryLogIn;

        }

        private void TryLogIn(object sender, EventArgs e)
        {
            User user = ((List<User>)DataContext.Users).FirstOrDefault(u => u.UserName == FindViewById<EditText>(Resource.Id.Main_EditText_userName).Text.Trim());
            if (user != null)
            {
                Settings.UserName = user.UserName;
                var intent = new Intent(this, typeof(ProfileActivity));
               
                StartActivity(intent);
                this.Finish();
            }
            else
            {
                //display error popup
                new AlertDialog.Builder(this)
                   .SetMessage(Resource.String.wrongUsername)
                   .SetNeutralButton(Resource.String.close, (alertSender, alertEv) => { ((AlertDialog)alertSender).Dispose(); })
                   .SetCancelable(true)
                   .Show();
            }
        }
    }
}



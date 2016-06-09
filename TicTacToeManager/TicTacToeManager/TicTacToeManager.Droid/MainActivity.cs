﻿using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

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
		}
	}
}



using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace Whoopee
{
    [Activity(Label = "Whoopee", MainLauncher = true, Icon = "@drawable/icon", Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.MyButton);

            //button.Click += delegatebt { button.Text = string.Format("{0} clicks!", count++); };

            Button btnNewGame;

            btnNewGame = FindViewById<Button>(Resource.Id.btnNewGame);
            btnNewGame.Click += BtnNewGame_Click;
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            Intent nextActivity = new Intent(this, typeof(GamePage));
            StartActivity(nextActivity);
        }
    }
}


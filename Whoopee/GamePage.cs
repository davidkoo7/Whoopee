using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Whoopee
{
    [Activity(Label = "GamePage", Theme = "@android:style/Theme.Black.NoTitleBar.Fullscreen")]
    public class GamePage : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application he
            SetContentView(Resource.Layout.GamePage);

            Random r = new Random();
            TextView firstNum;
            TextView secondNum;

            Button btnNum1;
            Button btnNum2;
            Button btnNum3;

            TextView tvResult;
            
            firstNum = FindViewById<TextView>(Resource.Id.tvFirstNum);
            secondNum = FindViewById<TextView>(Resource.Id.tvSecondNum);

            btnNum1 = FindViewById<Button>(Resource.Id.btnFirstNum);
            btnNum2 = FindViewById<Button>(Resource.Id.btnSecondNum);
            btnNum3 = FindViewById<Button>(Resource.Id.btnThirdNum);

            tvResult = FindViewById<TextView>(Resource.Id.tvResult);

            firstNum.Text = r.Next(1, 10).ToString();
            secondNum.Text = r.Next(11, 20).ToString();

            btnNum1.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + 5 ).ToString();
            btnNum2.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text)).ToString();
            btnNum3.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) - 5).ToString();
        }
    }
}
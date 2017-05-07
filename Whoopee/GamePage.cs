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
        Random r = new Random();
        TextView firstNum;
        TextView secondNum;

        Button btnNum1;
        Button btnNum2;
        Button btnNum3;

        TextView tvResult;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            // Create your application he
            SetContentView(Resource.Layout.GamePage);

            firstNum = FindViewById<TextView>(Resource.Id.tvFirstNum);
            secondNum = FindViewById<TextView>(Resource.Id.tvSecondNum);

            btnNum1 = FindViewById<Button>(Resource.Id.btnFirstNum);
            btnNum2 = FindViewById<Button>(Resource.Id.btnSecondNum);
            btnNum3 = FindViewById<Button>(Resource.Id.btnThirdNum);
            tvResult = FindViewById<TextView>(Resource.Id.tvResult);



            startGame(firstNum,secondNum,btnNum1,btnNum2,btnNum3,tvResult);
            btnNum2.Click += BtnNum2_Click;
            btnNum3.Click += BtnNum3_Click;
            btnNum1.Click += BtnNum1_Click;

        }


        private void BtnNum3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btnNum3.Text) == (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text)))
            {
                tvResult.Visibility = ViewStates.Visible;
                tvResult.Text = "Correct";
                startGame(firstNum, secondNum, btnNum1, btnNum2, btnNum3, tvResult);

            }
            else
            {
                tvResult.Visibility = ViewStates.Visible;
                tvResult.Text = "Incorrect";
            }
        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btnNum2.Text) == (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text)))
            {
                tvResult.Visibility = ViewStates.Visible;
                tvResult.Text = "Correct";
                startGame(firstNum, secondNum, btnNum1, btnNum2, btnNum3, tvResult);

            }
            else
            {
                tvResult.Visibility = ViewStates.Visible;
                tvResult.Text = "Incorrect";
            }
        }

        private void BtnNum1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(btnNum1.Text) == (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text)))
            {
                tvResult.Visibility = ViewStates.Visible;
                tvResult.Text = "Correct";
                startGame(firstNum, secondNum, btnNum1, btnNum2, btnNum3, tvResult);

            }
            else
            {
                tvResult.Visibility = ViewStates.Visible;
                tvResult.Text = "Incorrect";
            }
        }

        private void startGame(TextView firstNum, TextView secondNum, Button btnNum1, Button btnNum2, Button btnNum3, TextView tvResult)
        {

            firstNum.Text = r.Next(1, 10).ToString();
            secondNum.Text = r.Next(11, 20).ToString();

            Random rr = new Random();

            int roll = rr.Next(1, 3);
            
            if (roll == 1)
            {
                btnNum1.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text)).ToString();
                btnNum2.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + r.Next(-10,20)).ToString();
                btnNum3.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + r.Next(-10,20)).ToString();

            }
            else if (roll== 2)
            {
                btnNum1.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + r.Next(-10, 20)).ToString();
                btnNum2.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text)).ToString();
                btnNum3.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + r.Next(-10, 20)).ToString();

            }
            else
            {
                btnNum1.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + r.Next(-10, 20)).ToString();
                btnNum2.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + r.Next(-10, 20)).ToString();
                btnNum3.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text)).ToString();

            }


        }

      
    }

   
}
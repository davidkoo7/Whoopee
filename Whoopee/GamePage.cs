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
using Android.Preferences;

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
        TextView tvLevel;

        ISharedPreferences d;
        ISharedPreferencesEditor editor;

        int iHighScore;

        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            
            SetContentView(Resource.Layout.GamePage);

            d = PreferenceManager.GetDefaultSharedPreferences(this); // getting access from Preference manager
            editor = d.Edit();

            iHighScore = d.GetInt("highScore", 0);

            firstNum = FindViewById<TextView>(Resource.Id.tvFirstNum);
            secondNum = FindViewById<TextView>(Resource.Id.tvSecondNum);

            btnNum1 = FindViewById<Button>(Resource.Id.btnFirstNum);
            btnNum2 = FindViewById<Button>(Resource.Id.btnSecondNum);
            btnNum3 = FindViewById<Button>(Resource.Id.btnThirdNum);
            tvResult = FindViewById<TextView>(Resource.Id.tvResult);
            tvLevel = FindViewById<TextView>(Resource.Id.tvLevel);


            startGame(firstNum, secondNum, btnNum1, btnNum2, btnNum3, tvResult);
            btnNum2.Click += BtnNum2_Click;
            btnNum3.Click += BtnNum2_Click;
            btnNum1.Click += BtnNum2_Click;


        }

        private void BtnNum2_Click(object sender, EventArgs e)
        {


            if ((sender == btnNum2) && (Convert.ToInt32(btnNum2.Text) == (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text))))
            {
                tvResult.Visibility = ViewStates.Visible;
                tvResult.Text = "Correct";
                startGame(firstNum, secondNum, btnNum1, btnNum2, btnNum3, tvResult);
                tvLevel.Text = (Convert.ToInt32(tvLevel.Text) + 1).ToString();
            }
            else if ((sender == btnNum3) && (Convert.ToInt32(btnNum3.Text) == (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text))))
            {
                tvResult.Visibility = ViewStates.Visible;
                tvResult.Text = "Correct";
                startGame(firstNum, secondNum, btnNum1, btnNum2, btnNum3, tvResult);
                tvLevel.Text = (Convert.ToInt32(tvLevel.Text) + 1).ToString();

            }
            else if ((sender == btnNum1) && (Convert.ToInt32(btnNum1.Text) == (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text))))
            {
                tvResult.Visibility = ViewStates.Visible;
                tvResult.Text = "Correct";
                startGame(firstNum, secondNum, btnNum1, btnNum2, btnNum3, tvResult);
                tvLevel.Text = (Convert.ToInt32(tvLevel.Text) + 1).ToString();
            }
            else
            {
                tvResult.Visibility = ViewStates.Visible;
                tvResult.Text = "Incorrect";
                tvLevel.Text = "1";
            }

            if (Convert.ToInt32(tvLevel.Text) > iHighScore)
            {
                editor.PutInt("highScore", Convert.ToInt32(tvLevel.Text));
            }
        }


        private void startGame(TextView firstNum, TextView secondNum, Button btnNum1, Button btnNum2, Button btnNum3, TextView tvResult)
        {

            firstNum.Text = r.Next(1, 10).ToString();
            secondNum.Text = r.Next(11, 20).ToString();

            Random rr = new Random();

            int roll = rr.Next(1, 4);

            if (roll == 1)
            {
                btnNum1.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text)).ToString();
                btnNum2.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + randomIntExceptZero(-10, 20)).ToString();
                btnNum3.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + randomIntExceptZero(-10, 20)).ToString();

            }
            else if (roll == 2)
            {
                btnNum1.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + randomIntExceptZero(-10, 20)).ToString();
                btnNum2.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text)).ToString();
                btnNum3.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + randomIntExceptZero(-10, 20)).ToString();

            }
            else if(roll == 3)
            {
                btnNum1.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + randomIntExceptZero(-10, 20)).ToString();
                btnNum2.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text) + randomIntExceptZero(-10, 20)).ToString();
                btnNum3.Text = (Convert.ToInt32(firstNum.Text) + Convert.ToInt32(secondNum.Text)).ToString();

            }


        }

        private int randomIntExceptZero(int min, int max)
        {
            int result = r.Next(min, max);
            if (result == 0)
                result += 1;
            return result;
        }

    }

    }
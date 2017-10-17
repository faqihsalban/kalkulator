using Android.App;
using Android.Widget;
using Android.OS;

namespace android.kalkulator
{
    [Activity(Label = "android.kalkulator", MainLauncher = true)]
    public class MainActivity : Activity
    {
        string num1;
        string num2;
        string operato;

        //int count = 1;
        void deleteOne(TextView layar)
        {
            layar.Text = layar.Text.Remove(layar.Text.Length - 1);
        }
        void deleteAll(TextView layar)
        {
            layar.Text = "";
        }
        void tampil(TextView layar,string a)
        {
            layar.Text += string.Format("{0}", a);
        }
        void setOperato(string operat)
        {
            operato = operat;
        }

        void initComponent()
        {
            num1 = null;
            num2 = null;
            operato = null; 
        }



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Find Resource Element
            Button button1 = FindViewById<Button>(Resource.Id.button1);
            Button button2 = FindViewById<Button>(Resource.Id.button2);
            Button button3 = FindViewById<Button>(Resource.Id.button3);
            Button button4 = FindViewById<Button>(Resource.Id.button4);
            Button button5 = FindViewById<Button>(Resource.Id.button5);
            Button button6 = FindViewById<Button>(Resource.Id.button6);
            Button button7 = FindViewById<Button>(Resource.Id.button7);
            Button button8 = FindViewById<Button>(Resource.Id.button8);
            Button button9 = FindViewById<Button>(Resource.Id.button9);
            Button button0 = FindViewById<Button>(Resource.Id.button0);
            Button buttonDel = FindViewById<Button>(Resource.Id.buttonDel);
            Button buttonC = FindViewById<Button>(Resource.Id.buttonC);

            Button buttonPlus = FindViewById<Button>(Resource.Id.buttonPlus);
            Button buttonMin = FindViewById<Button>(Resource.Id.buttonMin);
            Button buttonMult = FindViewById<Button>(Resource.Id.buttonKali);
            Button buttonDiv = FindViewById<Button>(Resource.Id.buttonBagi);
            Button buttonEq = FindViewById<Button>(Resource.Id.buttonSamadengan);


            TextView textview1 = FindViewById<TextView>(Resource.Id.textView);
            textview1.Text = "";


            buttonPlus.Click += delegate
            {
                operato = "+";
                tampil(textview1,(buttonPlus.Text));
            };
            buttonMin.Click += delegate
            {
                operato = "-";
                tampil(textview1, (buttonMin.Text));
            };
            buttonMult.Click += delegate
            {
                operato = "*";
                tampil(textview1, (buttonMult.Text));
            };
            buttonDiv.Click += delegate
            {
                operato = "/";
                tampil(textview1, (buttonDiv.Text));
            };
            buttonEq.Click += delegate
            {
                float result = 5;
                if (operato != null)
                {
                    if(operato == "+")
                    {
                        result = float.Parse(num1) + float.Parse(num2);
                    }
                    else if (operato == "-")
                    {
                        result = float.Parse(num1) - float.Parse(num2);
                    }
                    else if (operato == "*")
                    {
                        result = float.Parse(num1) * float.Parse(num2);
                    }
                    else if (operato == "/")
                    {
                        result = float.Parse(num1) / float.Parse(num2);
                    }
                }

                
                tampil(textview1,string.Format(" = {0}", result.ToString()));
            };




            buttonC.Click += delegate
            {
                operato = null;
                num1 = null;
                num2 = null;
                deleteAll(textview1);
            };

            buttonDel.Click += delegate 
            {
                deleteOne(textview1);
            };
         
            button1.Click += delegate
            {
                
                if(string.IsNullOrEmpty(operato)) num1 += 1;
                else num2 += 1;

                tampil(textview1,(button1.Text));
            };

            button2.Click += delegate
            {
                if (string.IsNullOrEmpty(operato)) num1 += 2;
                else num2 += 2;
                tampil(textview1, (button2.Text));
            };

            button3.Click += delegate
            {
                if (string.IsNullOrEmpty(operato)) num1 += 3;
                else num2 += 3;
                tampil(textview1, (button3.Text));
            };
            button4.Click += delegate
            {
                if (string.IsNullOrEmpty(operato)) num1 += 4;
                else num2 += 4;
                tampil(textview1, (button4.Text));
            };
            button5.Click += delegate
            {
                if (string.IsNullOrEmpty(operato)) num1 += 5;
                else num2 += 5;
                tampil(textview1, (button5.Text));
            };
            button6.Click += delegate
            {
                if (string.IsNullOrEmpty(operato)) num1 += 6;
                else num2 += 6;
                tampil(textview1, (button6.Text));
            };
            button7.Click += delegate
            {
                if (string.IsNullOrEmpty(operato)) num1 +=7;
                else num2 += 7;
                tampil(textview1, (button7.Text));
            };
            button8.Click += delegate
            {
                if (string.IsNullOrEmpty(operato)) num1 += 8;
                else num2 += 8;
                tampil(textview1, (button8.Text));

            };
            button9.Click += delegate
            {
                if (string.IsNullOrEmpty(operato)) num1 += 9;
                else num2 += 9;
                tampil(textview1, (button9.Text));

            };
            button0.Click += delegate
            {
                if (string.IsNullOrEmpty(operato)) num1 += 0;
                else num2 += 0;
                tampil(textview1, (button0.Text));

            };

        }
    }
}


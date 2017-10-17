using Android.App;
using Android.Widget;
using Android.OS;

namespace android.kalkulator
{
    [Activity(Label = "android.kalkulator", MainLauncher = true)]
    public class MainActivity : Activity
    {
        //int count = 1;
        void deleteOne(TextView layar)
        {
            layar.Text = layar.Text.Remove(layar.Text.Length - 1);
        }
        void tampil(TextView layar,int a)
        {
            layar.Text += string.Format("{0}", a);
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

            TextView textview1 = FindViewById<TextView>(Resource.Id.textView);
            textview1.Text = "0";


            buttonDel.Click += delegate {
                deleteOne(textview1);

            };
            
            button1.Click += delegate
            {
                tampil(textview1,int.Parse(button1.Text));
            };

            button2.Click += delegate
            {
                tampil(textview1, int.Parse(button2.Text));
            };

            button3.Click += delegate
            {
                tampil(textview1, int.Parse(button3.Text));
            };
            button4.Click += delegate
            {
                tampil(textview1, int.Parse(button4.Text));
            };
            button5.Click += delegate
            {
                tampil(textview1, int.Parse(button5.Text));
            };
            button6.Click += delegate
            {
                tampil(textview1, int.Parse(button6.Text));
            };
            button7.Click += delegate
            {
                tampil(textview1, int.Parse(button7.Text));
            };
            button8.Click += delegate
            {
                tampil(textview1, int.Parse(button8.Text));

            };
            button9.Click += delegate
            {
                tampil(textview1, int.Parse(button9.Text));

            };
            button0.Click += delegate
            {
                tampil(textview1, int.Parse(button0.Text));

            };

        }
    }
}


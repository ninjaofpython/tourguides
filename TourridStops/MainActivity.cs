using Android.App;
using Android.Widget;
using Android.OS;

namespace TourridStops
{
	[Activity(Label = "TourridStops", MainLauncher = true)]
	public class MainActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);


			Button button1 = FindViewById<Button>(Resource.Id.callButton1);
			Button button2 = FindViewById<Button>(Resource.Id.callButton2);

			button2.Click += delegate { button.Text = string.Format("{0}// clicks!", count++); };
		}
	}
}


using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace BorgarverkApp
{
	[Activity(Label = "BorgarverkApp", MainLauncher = true, Icon = "@mipmap/icon", Theme="@style/MyTheme")]
	public class MainActivity : AppCompatActivity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			/*Spinner carSpinner = FindViewById<Spinner>(Resource.Id.carSpinner);*/
		}
	}
}


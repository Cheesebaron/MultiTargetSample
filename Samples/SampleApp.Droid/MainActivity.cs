using Android.App;
using Android.OS;
using Android.Support.V7.App;
using MultiTargetLib;

namespace SampleApp.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var androidClass = new AndroidClass(this);
            var commonClass = new CommonClass();
        }
	}
}


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;

namespace BroadcastReceiverNoam
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView tv;
        BroadcastBattery broadCastBattery;
        BluetoothReciever bluetoothReceiver;
        FlightModeReceiver flightModeReceiver;
        Usbc1 usbc1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            tv = (TextView)FindViewById(Resource.Id.tv);
            broadCastBattery = new BroadcastBattery(tv);
            bluetoothReceiver = new BluetoothReciever();
            flightModeReceiver = new FlightModeReceiver();
            usbc1 = new Usbc1();
        }
        protected override void OnResume()
        {
            base.OnResume();
            RegisterReceiver(broadCastBattery, new IntentFilter(Intent.ActionBatteryChanged));
            RegisterReceiver(bluetoothReceiver, new IntentFilter("android.bluetooth.adapter.action.STATE_CHANGED"));
            RegisterReceiver(flightModeReceiver, new IntentFilter("android.intent.action.AIRPLANE_MODE"));
            RegisterReceiver(usbc1, new IntentFilter("android.intent.action.ACTION_POWER_CONNECTED"));
        }
        protected override void OnPause()
        {
            base.OnPause();
            UnregisterReceiver(broadCastBattery);
            UnregisterReceiver(bluetoothReceiver);
            UnregisterReceiver(flightModeReceiver);
            UnregisterReceiver(usbc1);

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        


    }
}
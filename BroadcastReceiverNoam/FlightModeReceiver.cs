using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BroadcastReceiverNoam
{
    [BroadcastReceiver]
    public class FlightModeReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            string action = intent.Action;
            if (action.Equals("android.intent.action.AIRPLANE_MODE"))
            {
                Toast.MakeText(context, "AIRPLANE_MODE", ToastLength.Short).Show();
            }
        }
    }
}
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
    public class Usbc1 : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            string action = intent.Action;
            if (action.Equals("android.intent.action.ACTION_POWER_CONNECTED"))
            {
                Toast.MakeText(context, "android.intent.action.ACTION_POWER_CONNECTED", ToastLength.Short).Show();
            }
        }
    }
}
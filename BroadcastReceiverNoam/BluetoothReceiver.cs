using Android.App;
using Android.Bluetooth;
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
    public class BluetoothReciever : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            string action = intent.Action;
            if (action.Equals(BluetoothAdapter.ActionStateChanged))
            {
                int state = intent.GetIntExtra(BluetoothAdapter.ExtraState, BluetoothAdapter.Error);
                Toast.MakeText(context, "Received state !" + state, ToastLength.Short).Show();
            }
        }
    }
}
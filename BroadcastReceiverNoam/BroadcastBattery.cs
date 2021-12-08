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
    public class BroadcastBattery : BroadcastReceiver
    {
        TextView tv;
        public BroadcastBattery()
        {
        }
        public BroadcastBattery(TextView tv)
        {
            this.tv = tv;
        }
        public override void OnReceive(Context context, Intent intent)
        {
            int battery = intent.GetIntExtra("level", 0);
            if (battery>75)
            {
                tv.SetBackgroundColor(Android.Graphics.Color.Green);
            }
            else if (battery<74 && battery > 50)
            {
                tv.SetBackgroundColor(Android.Graphics.Color.Orange);
            }
            else if (battery < 50)
            {
                tv.SetBackgroundColor(Android.Graphics.Color.Red);
            }
        }

    }
}
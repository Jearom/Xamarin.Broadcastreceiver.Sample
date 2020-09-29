
using Android.App;
using Android.Content;
using Android.Util;
using Content = Android.Content;

namespace Xamarin.Broadcastreceiver.Sample
{
    [BroadcastReceiver(Enabled = true, Exported = false)]
    [IntentFilter(new[] { Content.Intent.ActionBootCompleted })]
    public class RebootReceiver : BroadcastReceiver
    {
        public override void OnReceive(Context context, Intent intent)
        {
            Log.Debug("Tag", "Receiver tetiklendi.");
        }
    }
}
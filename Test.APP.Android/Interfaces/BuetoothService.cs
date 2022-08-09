using System.Collections;
using System.Threading.Tasks;

using Android;
using Android.Content.PM;
using Android.OS;

using Test.APP.Droid.Interfaces;
using Test.APP.Interfaces;

using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(BuetoothService))]
namespace Test.APP.Droid.Interfaces
{
    public class BuetoothService : IBluetoothService
    {
        public Task<PermissionStatus> CheckStatusAsync()
        {
            if (Build.VERSION.SdkInt >= BuildVersionCodes.S)
            {
                if (MainActivity.Instance.CheckSelfPermission(Manifest.Permission.BluetoothScan) == (int)Permission.Granted)
                {
                    return Task.FromResult(PermissionStatus.Granted);
                }
            }
            else
            {
                if (MainActivity.Instance.CheckSelfPermission(Manifest.Permission.AccessFineLocation) == (int)Permission.Granted)
                {
                    return Task.FromResult(PermissionStatus.Granted);
                }
            }

            return Task.FromResult(PermissionStatus.Denied);

        }
        public Task<PermissionStatus> RequestAsync()
        {
            var permissions = new ArrayList();
            if (Build.VERSION.SdkInt >= BuildVersionCodes.S)
            {
                //if Android version bigger that Android12
                permissions.Add(Manifest.Permission.BluetoothScan);
                permissions.Add(Manifest.Permission.BluetoothConnect);
                permissions.Add(Manifest.Permission.BluetoothAdvertise);
            }
            else
            {
                // Android version less than  Android12             
                permissions.Add(Manifest.Permission.AccessFineLocation);
            }
            var requestPermission = (string[])permissions.ToArray(typeof(string));

        }
    }
}
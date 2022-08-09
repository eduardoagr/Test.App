
using System.Threading.Tasks;

using CoreBluetooth;

using Test.APP.Interfaces;
using Test.APP.iOS.Interfaces;

using Xamarin.Essentials;
using Xamarin.Forms;

[assembly: Dependency(typeof(BluetoothService))]
namespace Test.APP.iOS.Interfaces
{
    public class BluetoothService : IBluetoothService
    {
        public Task<PermissionStatus> CheckStatusAsync()
        {
            switch (CBManager.Authorization)
            {
                case CBManagerAuthorization.AllowedAlways:
                    return Task.FromResult(PermissionStatus.Granted);
                case CBManagerAuthorization.Restricted:
                    return Task.FromResult(PermissionStatus.Restricted);
                case CBManagerAuthorization.NotDetermined:
                    return Task.FromResult(PermissionStatus.Unknown);
                default:
                    return Task.FromResult(PermissionStatus.Denied);


            }
        }

        public Task<PermissionStatus> RequestAsync()
        {
            // Creating an instance of CBCentralManager will present the permission dialog.
            new CBCentralManager();
            return CheckStatusAsync();
        }
    }
}
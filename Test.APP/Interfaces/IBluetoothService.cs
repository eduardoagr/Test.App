
using System.Threading.Tasks;

using Xamarin.Essentials;

namespace Test.APP.Interfaces
{
    // Xamarin essentials, does not provide a way to ask for Bluetooth permission
    public interface IBluetoothService
    {
        Task<PermissionStatus> CheckStatusAsync();
        Task<PermissionStatus> RequestAsync();

    }
}

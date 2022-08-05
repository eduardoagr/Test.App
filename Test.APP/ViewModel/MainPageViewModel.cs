using System.Collections.Generic;
using System.Diagnostics;

using PropertyChanged;

using Test.APP.Fonts;
using Test.APP.Model;

using Xamarin.Forms;

namespace Test.APP.ViewModel
{
    [AddINotifyPropertyChangedInterface]
    public class MainPageViewModel
    {
        //Is good practice putting command at the end
        #region Button commands
        public Command PermissionCommand
        {
            get; set;
        }

        public Command LockCommand
        {
            get; set;
        }

        public Command UnlockComand
        {
            get; set;
        }

        public Command QueryCommand
        {
            get; set;
        }

        #endregion

        #region Public Variables

        // We use a list, because out data is not going to change
        public List<CustomButton> CustomButtons
        {
            get; set;
        }

        #endregion

        #region Constructor
        public MainPageViewModel()
        {
            //Because command are usually used to preform actions, we put action at the end
            PermissionCommand = new Command(PermissionAction);
            LockCommand = new Command(lockAction);
            UnlockComand = new Command(UnlockAction);
            QueryCommand = new Command(QueryAction);
            Initialize();
        }

        //Is important to follow the same visual representation as our UI
        private void PermissionAction()
        {
            Debug.WriteLine("Permission");
        }

        private void lockAction()
        {
            Debug.WriteLine("Lock");
        }
        private void UnlockAction()
        {
            Debug.WriteLine("UnLock");
        }
        private void QueryAction()
        {
            Debug.WriteLine("Query");
        }



        #endregion

        private void Initialize()
        {
            /* Is a very bad practice to use "Magical hard coded string"
             * in a big application, we would consider
             * making a "Constants" folder
             */

            CustomButtons = new List<CustomButton>
            {
                new CustomButton {
                    Text = "Permisos",
                    IsEnable = true,
                    IconColor = Color.FromHex("#a3a300"),
                    Icon = fontAwesome.Key,
                    Command = PermissionCommand
                },

                new CustomButton {
                    Text = "Lock",
                    IsEnable = false,
                    Icon = fontAwesome.Lock,
                    IconColor = Color.FromHex("#0C2D48"),
                    Command = LockCommand
                },

                new CustomButton {
                    Text = "Unlock",
                    IsEnable = false,
                    Icon = fontAwesome.UnlockKeyhole,
                    IconColor = Color.FromHex("#145DA0"),
                    Command = UnlockComand
                },

                new CustomButton {
                    Text = "Query",
                    IsEnable = false,
                    Icon = fontAwesome.MagnifyingGlass,
                    IconColor = Color.DarkRed,
                    Command = QueryCommand
                }
            };
        }
    }
}

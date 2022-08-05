
using Xamarin.Forms;

namespace Test.APP.Model
{
    public class CustomButton
    {
        public Color Color
        {
            get; set;
        }

        public string Text
        {
            get; set;
        }

        public string Icon
        {
            get; set;
        }

        public Color IconColor
        {
            get; set;
        }
        public Command Command
        {
            get; set;
        }

        private bool _IsEnable;
        public bool IsEnable
        {
            get => _IsEnable;
            set
            {
                if (_IsEnable != value)
                {
                    _IsEnable = value;
                    SetColor();
                }
            }
        }

        private void SetColor()
        {
            if (IsEnable)
            {
                Color = Color.CornflowerBlue;
            }
            else
            {
                Color = Color.DarkGray;
            }
        }
    }
}

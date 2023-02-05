using System.Windows.Controls;

namespace fullRandomEHWPF
{
    class Switcher
    {
        public static void SwitchCheckBox(CheckBox checkBox)
        {
            switch (checkBox.IsChecked)
            {
                case true:
                    checkBox.IsChecked = false;
                    break;
                case false:
                    checkBox.IsChecked = true;
                    break;
            }
        }
        public static void SwitchCheckBox(CheckBox checkBox1, CheckBox checkBox2)
        {
            switch (checkBox1.IsChecked)
            {
                case true:
                    checkBox1.IsChecked = false;
                    break;
                case false:
                    checkBox1.IsChecked = true;
                    checkBox2.IsChecked = false;
                    break;
            }
        }
    }
}

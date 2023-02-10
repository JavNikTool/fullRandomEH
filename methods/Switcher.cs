using System.Windows.Controls;

namespace fullRandomEHWPF
{
    class Switcher
    {
        public static void SwitchCheckBox(CheckBox checkBox)
        {
            checkBox.IsChecked = checkBox.IsChecked == true ? checkBox.IsChecked = false : checkBox.IsChecked = true;
        }

        public static void SwitchCheckBox(CheckBox checkBox1, CheckBox checkBox2)
        {
            checkBox1.IsChecked = checkBox1.IsChecked == true ? checkBox1.IsChecked = false : checkBox1.IsChecked = true;
            checkBox2.IsChecked = false; 
        }
    }
}

namespace fullRandomEHWPF
{

    public partial class MainWindow
    {
        public bool FormValidationCheck()
        {
            return (Question2_check1.IsChecked == true || Question2_check2.IsChecked == true) && CheckBoxStatuses.Contains(true);
        }
    }
}

using System;
using System.Windows;
using System.Windows.Input;

namespace fullRandomEHWPF
{
    public partial class MainWindow
    {

        public void CloseWindowButton_Click(object sender, RoutedEventArgs e) // кнопка выхода
        {
            MessageBoxResult Result = MessageBox.Show("Закрыть приложение ?", "Выход", MessageBoxButton.YesNo);
            if (Result == MessageBoxResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        public void MinimizeWindowButton_Click(object sender, RoutedEventArgs e) // кнопка выхода
        {
            window.WindowState = window.WindowState == WindowState.Normal ? WindowState.Maximized : WindowState.Normal;
        }

        private void Check1_Checked(object sender, RoutedEventArgs e) // чек первого чекбокса
        {
            Question1_grid.MaxHeight = 850;
            Question1_grid.Visibility = Visibility.Visible;
            ContentWindow.Height += Question1_grid.Height;

        }

        private void Check1_Unchecked(object sender, RoutedEventArgs e) // анчек первого чекбокса
        {
            ContentWindow.Height -= Question1_grid.Height;
            Question1_grid.Visibility = Visibility.Collapsed;
            Question1_grid.MaxHeight = 0;
        }

        private void Check2_Checked(object sender, RoutedEventArgs e) // чек второго чекбокса
        {
            wrap2.Height = 40;
            wrap2.Visibility = Visibility.Visible;
            ContentWindow.Height += wrap2.Height;
        }
        private void Check2_Unchecked(object sender, RoutedEventArgs e) // анчек второго чекбокса
        {
            ContentWindow.Height -= wrap2.Height;
            wrap2.Visibility = Visibility.Collapsed;
            wrap2.Height = 0;
        }
        public void Question2_text1_MouseDown(object sender, MouseButtonEventArgs e) // запуск метода переключения чекбоксов во втором вопросе при нажатии на текстбокс
        {
            Switcher.SwitchCheckBox(Question2_check1, Question2_check2);
        }

        public void Question2_text2_MouseDown(object sender, MouseButtonEventArgs e) // запуск метода переключения чекбоксов во втором вопросе при нажатии на текстбокс
        {
            Switcher.SwitchCheckBox(Question2_check2, Question2_check1);
        }

        private void Question2_check1_Checked(object sender, RoutedEventArgs e)
        {
            Question2_check2.IsChecked = false;
        }

        private void Question2_check2_Checked(object sender, RoutedEventArgs e)
        {
            Question2_check1.IsChecked = false;
        }
        private void Question1_Check1_Click(object sender, RoutedEventArgs e)
        {
            Question1_Check1.IsChecked = true;
        }
        private void ImgDops00_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Question1_Check1.IsChecked = true;
        }
        private void ImgDops01_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.SwitchCheckBox(Question1_Check2);
        }
        private void ImgDops02_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.SwitchCheckBox(Question1_Check3);
        }
        private void ImgDops03_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.SwitchCheckBox(Question1_Check4);
        }
        private void ImgDops04_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.SwitchCheckBox(Question1_Check5);
        }
        private void ImgDops05_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.SwitchCheckBox(Question1_Check6);
        }
        private void ImgDops06_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.SwitchCheckBox(Question1_Check7);
        }
        private void ImgDops07_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.SwitchCheckBox(Question1_Check8);
        }
        private void ImgDops08_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.SwitchCheckBox(Question1_Check9);
        }
        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Switcher.SwitchCheckBox(Check1);
        }
        private void TextBlock2_MD(object sender, MouseButtonEventArgs e)
        {
            Switcher.SwitchCheckBox(Check2);
        }
        private void CollapsedWrap_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Action_wrapp.Visibility = Visibility.Collapsed;
        }


        private void Action_wrapp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape)
                Action_wrapp.Visibility = Visibility.Collapsed;
        }

    }
}

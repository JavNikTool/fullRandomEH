using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using static fullRandomEHWPF.materials.Detectives;
using static fullRandomEHWPF.materials.Monsters;
using static fullRandomEHWPF.materials.Preludes;

namespace fullRandomEHWPF
{

    public partial class MainWindow : Window
    {
        List<bool> CheckBoxStatuses = new List<bool>();
        List<string> MonstersList = new List<string>();
        List<string> DetectivesList = new List<string>();
        List<string> PreludesList = new List<string>();


        public MainWindow()
        {
            InitializeComponent();
            InitializingTheMonsterArray();
            InitializingTheDetectivArray();
            InitializingThePreludesArray();

        }

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            FillingTheListWithCheckBoxStatuses();

            if (FormValidationCheck())
            {
                GetRandomMonster();
                GetRandomDetectives();
                GetRandomPreludes();
                Action_wrapp.Visibility = Visibility.Visible;
            }
            else
                MessageBox.Show("Пожалуйста, выберете параметры и попробуйте еще раз");
        }

        private void FillingTheList(int i, string[][] array, List<string> list)
        {
            for (int q = 0; q < array[i].Length; q++)
            {
                CheckBox? CheckBoxName = FindName("Question1_Check" + (i + 1)) as CheckBox;
                if (CheckBoxName.IsChecked.Value == true)
                    list.Add(array[i][q]);
                else
                    break;
            }
        }

        public int GetRandomNumber(List<String> list)
        {
            Random random = new Random();
            return random.Next(0, list.Count);
        }
        private void FillingTheListWithCheckBoxStatuses()
        {
            CheckBoxStatuses.Clear();
            for (int i = 1; i < 10; i++)
            {
                CheckBox? CheckBoxName = FindName("Question1_Check" + i) as CheckBox;
                CheckBoxStatuses.Add(CheckBoxName.IsChecked.Value);
            }
        }

        private void GetRandomPreludes()
        {
            if (Question2_check1.IsChecked == true)
            {
                for (int i = 0; i < PreludesArray.Length; i++)
                {
                    if (i == 1 || i == 0)
                        continue;
                    else
                        FillingTheList(i, PreludesArray, PreludesList);
                }
                if (PreludesList.Count != 0)
                    TextBlockActionPreludes.Text = "Ваша прелюдия: \n" + PreludesList[GetRandomNumber(PreludesList)];
                PreludesList.Clear();
            }
            else
                TextBlockActionPreludes.Text = "";
        }

        private void GetRandomMonster()
        {
            for (int i = 0; i < MonstersArray.Length; i++)
            {
                FillingTheList(i, MonstersArray, MonstersList);
            }
            TextBlockActionMonster.Text = "Древний, которого вам нужно победить: \n" + MonstersList[GetRandomNumber(MonstersList)];
            MonstersList.Clear();
        }

        private void GetRandomDetectives()
        {
            for (int i = 0; i < DetectivArray.Length; i++)
            {
                if (i == 1)
                    continue;
                else
                    FillingTheList(i, DetectivArray, DetectivesList);
            }

            if (int.Parse(PlayersCount.Text) == 1)
                TextBlockActionDetective.Text = "Ваш сыщик: \n" + DetectivesList[GetRandomNumber(DetectivesList)];
            else
                GetPlayersCount();

            DetectivesList.Clear();
        }

        private void GetPlayersCount()
        {

            TextBlockActionDetective.Text = "Ваши сыщики:";
            for (int i = 0; i < int.Parse(PlayersCount.Text); i++)
            {
                int RandomDetectiv = GetRandomNumber(DetectivesList);
                string RandomDetectivFromList = DetectivesList[RandomDetectiv];
                TextBlockActionDetective.Text += $" \n {i + 1}. " + RandomDetectivFromList;
                DetectivesList.RemoveAt(RandomDetectiv);
            }

        }
    }


}

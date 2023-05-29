using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static WpfApp1.Olympyada;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        string[,] People = new string[100, 3];

        int i = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != string.Empty || Family.Text != string.Empty || Score.Text != string.Empty)
            {
                    string name = Name.Text;
                    string family = Family.Text;
                    string score = Score.Text;
                    People[i, 0] = name;
                    People[i, 1] = family;
                    People[i, 2] = score;
                    allPeople.Items.Add($"{People[i, 0]} {People[i, 1]} {People[i, 2]}\n");
                    i++;
                
            }

            else
            {
                MessageBox.Show("Введите корректные значения", Title, MessageBoxButton.OK);
            }
        }

        private void ButtonShow(object sender, RoutedEventArgs e)
        {
            for(int j = 0; j < i; j++)
            {
                if (Convert.ToInt32(People[j,2]) >= 30)
                {
                    bestpeople.Items.Add($"{People[j, 0]} {People[j, 1]} {People[j, 2]}\n");
                }
            }
        }
    }
}

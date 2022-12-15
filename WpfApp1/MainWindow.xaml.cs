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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string TextFromBeginWindow { get; set; }
        public int ToCaseBeginWindow { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AboutWindow aboutWindow = new AboutWindow();
            aboutWindow.ShowDialog();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            BeginWindow beginWindow = new BeginWindow();
            beginWindow.Owner = this;
            beginWindow.ShowDialog();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            switch (ToCaseBeginWindow)
            {
                case 0:
                    MessageBox.Show("Не выбран вариант перевода к верхему или нижнему регистру!");
                    break;
                case 1:
                    MessageBox.Show(TextFromBeginWindow.ToLower());
                    break;
                case 2:
                    MessageBox.Show(TextFromBeginWindow.ToUpper());
                    break;
            }
        }
    }
}

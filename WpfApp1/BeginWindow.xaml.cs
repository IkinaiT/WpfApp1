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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для BeginWindow.xaml
    /// </summary>
    public partial class BeginWindow : Window
    {
        public BeginWindow()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = this.Owner as MainWindow;
            if (main != null)
            {
                main.TextFromBeginWindow = TextBox1.Text;
                if(RadioButton1.IsChecked == true)
                {
                    main.ToCaseBeginWindow = 1;
                }
                else if(RadioButton2.IsChecked == true)
                {
                    main.ToCaseBeginWindow = 2;
                }
                else
                {
                    main.ToCaseBeginWindow = 0;
                }
            }

            main.WorkButton.IsEnabled = !string.IsNullOrEmpty(TextBox1.Text);

            this.Close();
        }
    }
}

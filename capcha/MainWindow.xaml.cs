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

namespace capcha
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

        string GetCapcha()
        {
            Random random = new Random();
            string str = string.Empty;
            string getStr = string.Empty;
            str = "1234567890";
            for (int i = 65; i < 91; i++)
            {
                str += (char)i;
            }


            for (int i = 0; i < 5; i++)
            {
                getStr += str[random.Next(36)];
            }
            return getStr;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            tbCapcha.Text = GetCapcha();
        }
    }
}

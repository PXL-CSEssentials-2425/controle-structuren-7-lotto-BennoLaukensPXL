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

namespace _7Lotto
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        StringBuilder sb = new StringBuilder();
        private void startButton_Click(object sender, RoutedEventArgs e)
        {
            sb.Clear();
            sb.AppendLine($"De 6 LOTTO-getallen zijn:");
            sb.AppendLine();
            for (int number = 1; number <= 6; number++)
            {
                int lottoNumber = rnd.Next(1, 46);
                sb.AppendLine($"Getal {number}: {lottoNumber}");
            }

            resultTextBox.Text = sb.ToString();
        }

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            resultTextBox.Clear();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

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

namespace SamlingsProgram
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

        private void solveOne(object sender, RoutedEventArgs e)
        {
            Calculations calc = new Calculations();
            if (solOneInput.Text.Length > 0)
            {
                OutputText.Text = string.Empty;
                int[] newCalc = calc.SolutionOne(Convert.ToInt32(solOneInput.Text));
                int totalSum = 0;
                for (int i = 0; i < newCalc.Length; i++)
                {
                    totalSum += newCalc[i];
                    if (newCalc[i] != 0)
                        OutputText.Text += newCalc[i] + "\n";
                }
                
                OutputText.Text += "Totalsumma: " + totalSum;
            }
        }

        private void solveTwo_Click(object sender, RoutedEventArgs e)
        {
            Calculations calc = new Calculations();
            if (solTwoInput.Text.Length > 0)
            {
                OutputText.Text = string.Empty;
                int[] newCalc = calc.SolutionTwo(Convert.ToInt32(solTwoInput.Text));
                int totalSum = 0;
                for(int i = 0;i < newCalc.Length;i++)
                {
                    totalSum += newCalc[i];
                    if (newCalc[i] != 0)
                        OutputText.Text += newCalc[i] + "\r\n";
                }
                OutputText.Text += "Totalsumma: " + totalSum;
            }
        }
    }
}

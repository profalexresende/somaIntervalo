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

namespace somaIntervalo
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

        private void btnFatorial_Click(object sender, RoutedEventArgs e)
        {
            double num1, num2, somat=0;

            num1 = Convert.ToDouble(txtNumero1.Text);
            num2 = Convert.ToDouble(txtNumero2.Text);

            if (num1 < num2)
            {
                for (double cont = num1; cont <= num2; cont++)
                {
                    somat = somat + cont;
                }
            }
            lblResultado.Content = somat.ToString();
        }
    }
}

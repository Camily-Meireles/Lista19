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

namespace Ex01
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string esc;
            Console.WriteLine("Esolha se q para quadrado e r para retângulo");
            esc = Console.ReadLine();
            if (esc == "q")
            {

                Console.WriteLine("Digite o valor do lado");
                Quadrado q = new Quadrado(double.Parse(Console.ReadLine()));
                Console.WriteLine(q);

            }
            else if (esc == "r")
            {
                int b, h;
                Console.WriteLine("Digite a base");
                b = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura");
                h = int.Parse(Console.ReadLine());
                Retangulo r = new Retangulo(b, h);
                Console.WriteLine(r);
            }


        }
    }
}

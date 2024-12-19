using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnResh_Clicked(object sender, RoutedEventArgs e)
        {
            bool f1, f2, f3;
            int a, b, c;
            int answer = 0;
            f1 = Int32.TryParse(tbfirst.Text , out a);
            f2 = Int32.TryParse(tbtwo.Text, out b);
            f3 = Int32.TryParse(tbthree.Text, out c);


            if (f1 != true && f2 != true && f3 != true)
            {
                MessageBox.Show("Введите правильные значения сторон");
            }
            else
            {
                if (rbSquare.IsChecked == true)
                {
                    answer = square(a);
                    rezult.Text = Convert.ToString(answer);
                }
                if (rbrectangle.IsChecked == true)
                {
                    answer = rectangle(a, b);
                    rezult.Text = Convert.ToString(answer);
                }
                if (rbtriangle.IsChecked == true)
                {
                    answer = trirectangle(a, b, c);
                    rezult.Text = Convert.ToString(answer);
                }
            }


        }

        int square(int a)
        {
            int answer = 0;
            answer = 4 * a;
            return answer;
        }

        int rectangle(int a, int b) 
        {
            int answer = 0;
            answer = 2 * (a + b);
            return answer;
        }

        int trirectangle(int a, int b, int c)
        {
            int answer = 0;
            answer = a + b + c;
            return answer;
        }


        private void btninfo_Clicked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа считает периметр фигуры");
        }

        private void btnexit_Clicked(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       

        
    }
}
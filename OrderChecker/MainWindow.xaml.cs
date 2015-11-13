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

namespace OrderChecker
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

        private void UserInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void CheckOrder_Click(object sender, RoutedEventArgs e)
        {
            var myOrder = new Order(this.UserInput.Text);
            this.Response.Text = (myOrder.Check());
            //this.textBox.Text = (myOrder.printList());
        }
        /*
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        } */
    }
}

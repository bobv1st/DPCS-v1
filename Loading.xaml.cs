using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace sussybakka
{
    /// <summary>
    /// Interaction logic for Loading.xaml
    /// </summary>
    public partial class Loading : Window
    {
        public Loading()
        {
            InitializeComponent();
            
            Main.Content = new Loading_Page();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MinimiseButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

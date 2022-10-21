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
using System.Windows.Threading;
namespace sussybakka
{
    /// <summary>
    /// Interaction logic for Loading_Page.xaml
    /// </summary>
    public partial class Loading_Page : Page
    {
        DispatcherTimer timer1 = new DispatcherTimer();
        public Loading_Page()
        {
            InitializeComponent();
            timer1.Interval = TimeSpan.FromSeconds(10);
            timer1.Tick += new EventHandler(LoadChatApp);
            timer1.Start();
        }

        void LoadChatApp(object sender, EventArgs e)
        {
        
            Main.Content = new ChatApp_Page();
        }
    }
}

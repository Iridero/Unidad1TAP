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

namespace AppLayouts
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

        private void btnUniformGrid_Click(object sender, RoutedEventArgs e)
        {
            WndUniformGrid wnd = new WndUniformGrid();
            wnd.Show();
        }

        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WndWrapPanel wnd = new WndWrapPanel();
            wnd.Show();
        }

        private void bntDock_Click(object sender, RoutedEventArgs e)
        {
            WndDockPanel wnd = new WndDockPanel();
            wnd.Show();
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            WndGrid wnd = new WndGrid();
            wnd.Show();
        }
    }
}

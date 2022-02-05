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

namespace Apariencia
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

        private void mnuPrincipal_Click(object sender, RoutedEventArgs e)
        {
            MenuItem mnu = (MenuItem)e.OriginalSource;
            if (mnu==mnuListBox)
            {
                tabControles.SelectedIndex = 0;
            }
            else if(mnu==mnuComboBox)
            {
                tabControles.SelectedIndex = 1;
            }
        }
    }
}

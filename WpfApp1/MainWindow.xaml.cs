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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AutoController autoController = new AutoController();

        DataAutosDataContext db = new DataAutosDataContext();
        public MainWindow()
        {
            InitializeComponent();

            dgAuto.ItemsSource = db.Autos;

            this.DataContext = autoController;
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            if (dgAuto.SelectedItem != null)
            {
                autoController.Verwijderen((Auto)dgAuto.SelectedItem);
            }
        }

        private void btnWijzigen_Click(object sender, RoutedEventArgs e)
        {
            if (dgAuto.SelectedItem != null)
            {
                AutoWijzigen autoWijzigen = new AutoWijzigen();

                autoWijzigen.Auto = (Auto)dgAuto.SelectedItem;

                autoWijzigen.ShowDialog();

                //autoController.Verwijderen((Auto)dgAuto.SelectedItem);
            }
        }
    }
}

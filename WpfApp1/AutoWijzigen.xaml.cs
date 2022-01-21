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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for AutoWijzigen.xaml
    /// </summary>
    public partial class AutoWijzigen : Window
    {
        private AutoController autoController = new AutoController();

        DataAutosDataContext db = new DataAutosDataContext();
        public AutoWijzigen()
        {
            InitializeComponent();
        }

        public Auto Auto { get; set; }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            txtKentenken.Text = Auto.Kenteken;
            txtPrijs.Text = Auto.Prijs.ToString();
            txtMerk.Text = Auto.Merk;
            txtBouwjaar.Text = Auto.Bouwjaar.ToString();

        }

        private void btnOpslaan_Click(object sender, RoutedEventArgs e)
        {
            Auto.Kenteken = txtKentenken.Text;
            //Auto.Prijs = Convert.ToDecimal(txtPrijs.Text);

            if (decimal.TryParse(txtPrijs.Text, out decimal prijs))
            {
                Auto.Prijs = prijs;
            }

            db.Autos.InsertOnSubmit(Auto);

            db.SubmitChanges();

            this.Close();
        }

        private void BtnAnnuleren_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

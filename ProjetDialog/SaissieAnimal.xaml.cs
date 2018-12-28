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

namespace ProjetDialog
{
    /// <summary>
    /// Logique d'interaction pour SaissieAnimal.xaml
    /// </summary>
    public partial class SaissieAnimal : Window
    {
        public SaissieAnimal()
        {
            InitializeComponent();
        }
        private string nom;
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        private string prix;
        public string Prix
        {
            get { return prix; }
            set { prix = value; }
        }
    
        private void valider(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();   
            nom = this.TextBoxsaissie.Text;
            nom = Convert.ToString(TextBoxsaissie.Text);
            //nom = Nom;
            prix = this.TextBoxprix.Text;
            prix = Convert.ToString(TextBoxprix.Text);
            //prix = Prix;
            string resultat = "" + nom + prix;
          
            /*
            ((MainWindow)System.Windows.Application.Current.MainWindow).TextBoxmain.Text = nom;
            ((MainWindow)System.Windows.Application.Current.MainWindow).TextBoxmain.Text += " /(";           
            ((MainWindow)System.Windows.Application.Current.MainWindow).TextBoxmain.Text += prix;
            ((MainWindow)System.Windows.Application.Current.MainWindow).TextBoxmain.Text += "€)";
            */
            this.Close();
          
           window.Close();
                   
        }


        private void annuler(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement Annulé?", "Annulée", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            TextBoxsaissie.Text = "?";
            TextBoxprix.Text = "prix";
        }

    
    }
    


}

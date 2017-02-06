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

namespace telefoons
{
    /// <summary>
    /// Interaction logic for telefoon.xaml
    /// </summary>
    public partial class telefoon : Window
    {
        List<Persoon> telefoonlijst = new List<Persoon>();

        public telefoon()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            telefoonlijst.Add(new Persoon("Anne", "015/20.24.25","Vrienden",new BitmapImage(new Uri("Images/anne.jpg",UriKind.Relative))));
            telefoonlijst.Add(new Persoon("bob", "016/20.22.21", "Vrienden", new BitmapImage(new Uri("Images/bob.jpg", UriKind.Relative))));
            telefoonlijst.Add(new Persoon("collega1", "02/23.59.09", "Werk", new BitmapImage(new Uri("Images/collega1.jpg", UriKind.Relative))));
            telefoonlijst.Add(new Persoon("collega2", "02/98.76.32", "Werk", new BitmapImage(new Uri("Images/collega2.jpg", UriKind.Relative))));
            telefoonlijst.Add(new Persoon("collega3", "09/49.23.89", "Werk", new BitmapImage(new Uri("Images/collega3.jpg", UriKind.Relative))));
            telefoonlijst.Add(new Persoon("ed", "0476/34.34.23", "Vrienden", new BitmapImage(new Uri("Images/ed.jpg", UriKind.Relative))));
            telefoonlijst.Add(new Persoon("grotezus", "0472/34.59.43", "Familie", new BitmapImage(new Uri("Images/grotezus.jpg", UriKind.Relative))));
            telefoonlijst.Add(new Persoon("kleinezus", "0472/35.59.43", "Familie", new BitmapImage(new Uri("Images/kleinezus.jpg", UriKind.Relative))));
            telefoonlijst.Add(new Persoon("tantenon", "0471/35.54.43", "Familie", new BitmapImage(new Uri("Images/tantenon.jpg", UriKind.Relative))));
            telefoonlijst.Add(new Persoon("vader", "0468/34.59.43", "Familie", new BitmapImage(new Uri("Images/vader.jpg", UriKind.Relative))));

            groepen.Items.Add("Iedereen");
            groepen.Items.Add("Vrienden");
            groepen.Items.Add("Werk");
            groepen.Items.Add("Familie");
            groepen.SelectedIndex = 0;
        }

        private void telefoon_Click(object sender, RoutedEventArgs e)
        {
            string tekst = "";
            if (telefoons.SelectedIndex != -1 )
            {
                Persoon geselecteerdepersoon = (Persoon)telefoons.SelectedItem;

                tekst = "Wil je " + geselecteerdepersoon.Naam + " bellen \n" + "op het nummer : " + geselecteerdepersoon.Telefoonnr;

                MessageBox.Show(tekst,"Telefoon",MessageBoxButton.YesNo,MessageBoxImage.Question);
            }
           else
            {
                MessageBox.Show("geen telefoonnummer geselecteerd.","Telefoon",MessageBoxButton.OK,MessageBoxImage.Information);
            }
        }

        private void groepen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            telefoons.Items.Clear();


            foreach (Persoon mijntelefoonlijst in telefoonlijst)
            {
              //  MessageBox.Show(mijntelefoonlijst.Items.ToString());
             //   MessageBox.Show(groepen.SelectedItem.ToString());
                if ((mijntelefoonlijst.Groep == groepen.SelectedItem.ToString() ) || groepen.SelectedIndex == 0 )
                {
                    
                    telefoons.Items.Add(mijntelefoonlijst);
                }
            }

        }
    }
}

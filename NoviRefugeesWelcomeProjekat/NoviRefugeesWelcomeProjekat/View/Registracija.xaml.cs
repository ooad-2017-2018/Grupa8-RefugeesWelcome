using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace NoviRefugeesWelcomeProjekat
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Registracija : Page
    {
        public Registracija()
        {
            this.InitializeComponent();
        }

        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
          
        }

        private async void  Button1_Click(object sender, RoutedEventArgs e)
        {
            if (ime.Text == " " || prezime.Text == " " || gr.Date == null || spol.Text == " " || prijem.Date == null)
            {
                var dialog = new MessageDialog("Molimo Vas popunite svako polje!");
                await dialog.ShowAsync();
            }
            else
            {

                Model.IzbjeglicaOstanakUZemlji iz = new Model.IzbjeglicaOstanakUZemlji(ime.Text, prezime.Text,gr.Date.Value.UtcDateTime, JMBG.Text, spol.Text,prijem.Date.Value.UtcDateTime);
                ViewModel.Sistem.RegistrujIzbjeglicu(iz);
                ime.Text = "";
                prezime.Text = "";
                JMBG.Text = "";
                spol.Text = "";
            }
         
        }

        private async void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (jmbg.Text == " ")
            {
                var dialog = new MessageDialog("Molimo Vas unesite JMBG!");
                await dialog.ShowAsync();
                //metoda koja pretrazuje izbjeglicu, skontati fino taj dio
            }
            else
            {
                Model.IzbjeglicaOstanakUZemlji iz = new Model.IzbjeglicaOstanakUZemlji(ime.Text, prezime.Text, Convert.ToDateTime(gr.Date), JMBG.Text, spol.Text, Convert.ToDateTime(prijem.Date));
                ViewModel.Sistem.ObrisiIzbjeglicu(iz);
            }
        }
   
        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog1 = new MessageDialog("Zahtjev uspjesno dodan!");
            await dialog1.ShowAsync();
        }


    }
}

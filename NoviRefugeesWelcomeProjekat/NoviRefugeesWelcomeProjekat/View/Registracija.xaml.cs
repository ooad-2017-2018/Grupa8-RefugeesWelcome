using Microsoft.WindowsAzure.MobileServices;
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
        IMobileServiceTable<ViewModel.IzbjeglicaOstanakUZemljiViewModel> izbjeglice= App.MobileService.GetTable<ViewModel.IzbjeglicaOstanakUZemljiViewModel>();
        public Registracija()
        {
            this.InitializeComponent();
            DataContext = new ViewModel.IzbjeglicaOstanakUZemljiViewModel();


        }

        private async void Validacija()
        {
            if (ime.Text == "" || prezime.Text == "" || JMBG.Text == "" || gr.Date == null || spol.Text == "" || prijem.Date == null)
            {
                var dialog = new MessageDialog("Molimo Vas popunite svako polje!");
                await dialog.ShowAsync();
              
            }else
            {
                Model.IzbjeglicaOstanakUZemlji iz = new Model.IzbjeglicaOstanakUZemlji(ime.Text, prezime.Text, gr.Date.Value.UtcDateTime, JMBG.Text, spol.Text, prijem.Date.Value.UtcDateTime);
                ViewModel.Sistem.RegistrujIzbjeglicu(iz);
                ime.Text = "";
                prezime.Text = "";
                JMBG.Text = "";
                spol.Text = "";
            }
        }
        private void ScrollViewer_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
          
        }

        private void btnSpasi_Tapped(object sender, RoutedEventArgs e)
        {
          

        }

        private async void Button3_Click(object sender, RoutedEventArgs e)
        {
            if (jmbg.Text == " ")
            {
                var dialog = new MessageDialog("Molimo Vas unesite JMBG!");
                await dialog.ShowAsync();
               
            }
            else
            {
                Model.IzbjeglicaOstanakUZemlji iz = new Model.IzbjeglicaOstanakUZemlji(ime.Text, prezime.Text,gr.Date.Value.UtcDateTime, JMBG.Text, spol.Text,prijem.Date.Value.UtcDateTime);
                ViewModel.Sistem.ObrisiIzbjeglicu(jmbg.Text);
            }
        }
   
        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog1 = new MessageDialog("Zahtjev uspjesno dodan!");
            await dialog1.ShowAsync();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var dialog1 = new MessageDialog("Zahtjev uspjesno dodan!");
            await dialog1.ShowAsync();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Sektor));
        }

        private void btnSpasi_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ViewModel.IzbjeglicaOstanakUZemljiViewModel i = new ViewModel.IzbjeglicaOstanakUZemljiViewModel
                {
                    Ime = ime.Text,
                    Prezime = prezime.Text,
                    DatumRodjenja = gr.Date.Value.UtcDateTime,
                    JMBG = JMBG.Text,
                    Spol = spol.Text,
                    DatumPrijema = prijem.Date.Value.UtcDateTime
                };
                Validacija();
                izbjeglice.InsertAsync(i);
                //MessageDialog msgDialog = new MessageDialog("Uspješno ste registrovali izbjeglicu.");
                //msgDialog.ShowAsync();
            }
            catch (Exception ex)
            {
                MessageDialog msgDialogError = new MessageDialog("Error : " + ex.ToString());
                msgDialogError.ShowAsync();
            }
        }
    }
}

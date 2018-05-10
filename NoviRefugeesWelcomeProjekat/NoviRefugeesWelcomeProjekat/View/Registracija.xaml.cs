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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Model.IzbjeglicaOstanakUZemlji iz = new Model.IzbjeglicaOstanakUZemlji(ime.Text, prezime.Text, DateTime.Parse(gr.Text), JMBG.Text, spol.Text, DateTime.Parse(prijem.Text));
            ViewModel.Sistem.RegistrujIzbjeglicu(iz);
            ime.Text = "";
            prezime.Text = "";
            gr.Text="";
            JMBG.Text = "";
            spol.Text = "";
            prijem.Text="";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Model.IzbjeglicaOstanakUZemlji iz = new Model.IzbjeglicaOstanakUZemlji(ime.Text, prezime.Text, DateTime.Parse(gr.Text), JMBG.Text, spol.Text, DateTime.Parse(prijem.Text));
            ViewModel.Sistem.ObrisiIzbjeglicu(iz);
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            var dialog1 = new MessageDialog("Zahtjev uspjesno dodan!");
            await dialog1.ShowAsync();
        }


    }
}

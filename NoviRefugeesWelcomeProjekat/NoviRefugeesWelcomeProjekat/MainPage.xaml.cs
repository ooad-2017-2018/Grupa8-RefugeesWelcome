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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace NoviRefugeesWelcomeProjekat
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }


        private async void LOGIN_Click(object sender, RoutedEventArgs e)
        {
            bool postoji = false;
            for (int i = 0; i < ViewModel.Sistem.korisnici.Count; i++)
            {
                if (ViewModel.Sistem.korisnici[i].Username == txtUsername.Text && ViewModel.Sistem.korisnici[i].Password == txtPassword.Text)
                    postoji = true;
            }
            if (txtUsername != null && txtPassword != null && postoji == true)
            {
                this.Frame.Navigate(typeof(Sektor));
            }
            else
            {
                var dialog = new MessageDialog("Pogrešni pristupni podaci. Neuspjesna prijava!");
                await dialog.ShowAsync();
                txtUsername.Text = "";
                txtPassword.Text = "";
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PristupniPodaci_Load(object sender, RoutedEventArgs e)
        {
            Model.Korisnik k = new Model.Korisnik("izbjeglica", "rw"); //hardkodirali šifru i password
            Model.IzbjeglicaOstanakUZemlji iz = new Model.IzbjeglicaOstanakUZemlji("sejla","pljakic", DateTime.Parse("01.01.1997"), "123456789","zensko",DateTime.Parse("01.01.1997"));
            ViewModel.Sistem.korisnici.Add(k);
        }
    }
}

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

namespace RentACar
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            liste.Items.Remove(liste.SelectedItem);
            liste.Items.Add("Araç Modeli : " + model.Text + "  &&  Araç Markası : " + marka.Text + " && Araç Numarası : " + plaka.Text);
        }

        private void ekle_Click(object sender, RoutedEventArgs e)
        {
            liste.Items.Add("Araç Modeli : " + model.Text + "  &&  Araç Markası : " + marka.Text + " && Araç Numarası : " + plaka.Text);
        }

        private void sil_Click(object sender, RoutedEventArgs e)
        {
            liste.Items.Remove(liste.SelectedItem);
        }

        private void plaka_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(plaka.Text, "[^0-9]"))
            {
                MessageBox.Show("Lütfen sadece sayısal ifade giriniz.", "Hatalı Girdi");
                plaka.Text = plaka.Text.Remove(plaka.Text.Length - 1);
            }
        }

        private void listtemizle_Click(object sender, RoutedEventArgs e)
        {
            liste.Items.Clear();
        }
    }
}


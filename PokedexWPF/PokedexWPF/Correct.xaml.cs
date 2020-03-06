using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PokedexWPF
{
    /// <summary>
    /// Interaction logic for Correct1.xaml
    /// </summary>
    public partial class Correct : Window
    {
        public Correct()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            PlayWindow2 P2 = new PlayWindow2();
            P2.Show();
            Close();

        }
    }
}

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
    public partial class PlayWindow3 : Window
    {
        public PlayWindow3()
        {
            InitializeComponent();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {

            Correct3 C3 = new Correct3();
            C3.Show();
            Close();

        }

        private void TextBox_AnswerBox3(object sender, TextChangedEventArgs e)
        {

        }
    }
}

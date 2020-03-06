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
    /// Interaction logic for PlayWindow.xaml
    /// </summary>
    public partial class PlayWindow : Window
    {
        private string _path = @"C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 6\Images";
        GameLogic a;
        public PlayWindow()
        {
            InitializeComponent();
            a = new GameLogic();
        }

        private void TextBox_Answer(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_AnswerBox2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)

        {
            a.TheirAnswer = AnswerBox1.Text;
            a.AnswerComparison();
            {
                if (a.AnswerComparison() == true)
                {

                    Correct C1 = new Correct();
                    C1.Show();
                    Close();
                }


            }
        }

        private void TextBox_AnswerBox1(object sender, TextChangedEventArgs e)
        {

        }

        //AnswerBox1.Text = $"{a.CorrectAnswer()}";
        //if (AnswerBox1.Text == $"{a.CorrectAnswer()}")
        //{
        //pkImage.Source = new BitmapImage(new Uri(a.));
        //}


    }
}




//string CorrectAnswer()
//{
//    string y = "yes";
//    string n = "no";

//    using var db = new POKEDEXPOKEMONContext();
//    //q1 string (Bulbasaur)
//    {
//        var Answer1q =
//            from a1 in db.Pokemon
//            select a1;

//        foreach (var a1 in Answer1q)
//        {

//            if (_answer == a1.ToString())
//            {
//                return y;
//            }
//            else
//            {
//                return n;
//            }
//        }
//    }
//}




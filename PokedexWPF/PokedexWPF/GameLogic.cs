using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PokedexWPF
{
    public class GameLogic
    {
        //fields withing game logic 
        private string _actualAnswer;
        private string _answer;
        //private Pokemon _currentPokemon;
        private List<Pokemon> Answers;
        public int _currentP = 0;
        // list query
        public GameLogic()
        {
            using (var db = new POKEDEXPOKEMONContext())
            {
                Answers =
                    (from p in db.Pokemon
                     select p).ToList();
            }
        }
        public List<Pokemon> GetList()
        {
         using (var db = new POKEDEXPOKEMONContext())

            {
                return db.Pokemon.ToList();
            }

        }

        // create a constructor, get set 

        public string TheirAnswer
        {
            get { return _answer; }
            
            set
            
            {if (value.Length > 0)
                    _answer = value;
            }
        }

        
        // Methods for individual questions due to serialisation potentially taking too much time
        public string CorrectAnswer()
        {
            Answers = GetList();
            var a = Answers[0];


            _actualAnswer = a.ToString();
            return _actualAnswer;

        }

        public bool AnswerComparison()
        {
            if (TheirAnswer == CorrectAnswer())
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public string CorrectAnswer2()

        {
            Answers = GetList();
            var b = Answers[1];


            _actualAnswer = b.ToString();
            return _actualAnswer;
        }


        public bool AnswerComparison2()
        {
            if (TheirAnswer == CorrectAnswer2())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        // third answer
        public string CorrectAnswer3()

        {
            Answers = GetList();
            var c = Answers[2];


            _actualAnswer = c.ToString();
            return _actualAnswer;
        }

        public bool AnswerComparison3()
        {
            if (TheirAnswer == CorrectAnswer3())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}


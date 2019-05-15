﻿using System;
using System.Collections.Generic;

namespace Mastermind {
    class Program {
        static void Main (string[] args) {
            Game game = new Game (new string[] { "a", "b", "e", "d"});
            
            for (int turns = 10; turns > 0; turns--) {
                Console.WriteLine($"You have {turns} tries left");
                Console.WriteLine ("Choose four letters: ");
                string letters = Console.ReadLine ();
                Ball[] balls = new Ball[4];
                for (int i = 0; i < 4; i++) {
                    balls[i] = new Ball (letters[i].ToString());
                }
                try{
                Row row = new Row (balls);
                game.AddRow (row);
                Console.WriteLine (game.Rows);
                
            }
                catch(InvalidCastException e){
                    Console.WriteLine(" You Win!");
                    turns = 0;
                }
            }
            Console.WriteLine ("Out Of Turns");
        }
    }

    class Game {
        private List<Row> rows = new List<Row> ();
        private string[] answer = new string[4];

        public Game (string[] answer) {
            this.answer = answer;
        }

        private string Score (Row row) {
            string[] answerClone = (string[]) this.answer.Clone ();
            // red is correct letter and correct position
            // white is correct letters minus red
            // this.answer => ["a", "b", "c", "d"]
            // row.balls => [{ Letter: "c" }, { Letter: "b" }, { Letter: "d" }, { Letter: "a" }]
            int red = 0;
            for (int i = 0; i < 4; i++) {
                if (answerClone[i] == row.balls[i].Letter) {
                    red++;
                }
            }

            int white = 0;
            for (int i = 0; i < 4; i++) {
                int foundIndex = Array.IndexOf (answerClone, row.balls[i].Letter);
                if (foundIndex > -1) {
                    white++;
                    answerClone[foundIndex] = null;
                }
            }

            
            
            
                if(red == 4){
                    // Console.WriteLine(" Red = {red} You Win!");
                    throw new InvalidCastException();
                    
                }else{
                    Console.WriteLine(" Red = {red} Try again");
                    
                    
                }
                return $" {red} - {white - red}";
            
        }

        public void AddRow (Row row) {
            this.rows.Add (row);
        }

        public string Rows {
            get {
                foreach (var row in this.rows) {
                    Console.Write (row.Balls);
                    Console.WriteLine (Score (row));
                }
                return " ";
            }
        }
    }

    class Ball {
        public string Letter { get; private set; }

        public Ball (string letter) {
            this.Letter = letter;
        }
    }

    class Row {
        public Ball[] balls = new Ball[4];

        public Row (Ball[] balls) {
            this.balls = balls;
        }

        public string Balls {
            get {
                foreach (var ball in this.balls) {
                    Console.Write (ball.Letter);
                }
                return "";
            }
        }
    }
}
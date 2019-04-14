using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Game
    {
        public int TurnNum { get; set; }
        public Player[] Players;
        public Player Winner { get; } = null;
        public Board Board { get;}

        public Game()
        {
            TurnNum = 0;
            Players = new Player[2];
            Players[0] = new Player("Player 1", 'X');
            Players[1] = new Player("Player 2", 'O');
            Board = new Board();

        }

        public Player ActivePlayer()
        {
            return Players[TurnNum % 2];
        }

        public bool TakeTurn(Player player, char reference)
        {
            if (Board.Mark(reference, player.Marker))
            {
                TurnNum++;
                return true;
            }

            else
                return false;
        }

        public void Play()
        {

            while (true)
            {
                Console.WriteLine($"TURN {TurnNum} \t =============================");
                Console.WriteLine(Board.ToString());
                Console.WriteLine($"\n {this.ActivePlayer().Name} is up! Choose a spot to mark.");

                char spot = Convert.ToChar(Console.ReadLine());
                this.TakeTurn(this.ActivePlayer(), spot);

                if (Board.CheckWin())
                {
                    Console.WriteLine($"\n{this.ActivePlayer().Name} wins! Final board:");
                    Console.WriteLine(Board.ToString());
                    return;
                }
                else if (Board.CheckTie())
                {
                    Console.WriteLine("\nIt's a tie! Final board:");
                    Console.WriteLine(Board.ToString());
                    return;
                }
            }

        }
    }
}

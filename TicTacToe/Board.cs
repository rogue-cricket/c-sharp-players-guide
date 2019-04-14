using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Board
    {

        public Position[,] State;

        public Board()
        {
            State = new Position[3, 3];
            char posMarker = 'a';
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    State[j, i] = new Position(j, i, posMarker++);
                }
            }

        }

        public bool Mark(int row, int col, char marker)
        {
            return State[row, col].PlaceMarker(marker);
        }

        public bool Mark(char shortcut, char marker)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (State[i, j].Content == shortcut)
                        return State[i, j].PlaceMarker(marker);
                }
            }

            return false;
        }

        public bool CheckWin()
        {
            bool winner = false;
            // Check X
            for (int i = 0; i < 3 && !winner; i++)
            {
                if (State[i, 0].Content == State[i, 1].Content && State[i, 1].Content == State[i, 2].Content)
                    winner = true;
            }

            // Check Y
            for (int i = 0; i < 3 && !winner; i++)
            {
                if (State[0, i].Content == State[1, i].Content && State[1, i].Content == State[2, i].Content)
                    winner = true;
            }

            // Check Diagonals
            if (!winner && State[0, 0].Content == State[1, 1].Content && State[1, 1].Content == State[2, 2].Content)
                winner = true;
            else if (!winner && State[0, 2].Content == State[1, 1].Content && State[1, 1].Content == State[2, 0].Content)
                winner = true;

            return winner;
        }

        public bool CheckTie()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (!State[j, i].Filled)
                        return false;
                }
            }

            return true;
        }
        public override string ToString()
        {
            return $"\t {State[0, 0].Content} | {State[1, 0].Content} | {State[2, 0].Content} " +
                $"\n\t---+---+---\n" +
                $"\t {State[0, 1].Content} | {State[1, 1].Content} | {State[2, 1].Content} " +
                $"\n\t---+---+---\n" +
                $"\t {State[0, 2].Content} | {State[1, 2].Content} | {State[2, 2].Content}";
        }
    }

}

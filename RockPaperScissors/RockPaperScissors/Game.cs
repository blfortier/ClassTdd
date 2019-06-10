using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaperScissors
{
    public class Game 
    {
      
        public static Gesture DetermineWhoWins(Gesture player1, Gesture player2)
        {
            Gesture Rock = Gesture.Rock;
            Gesture Paper = Gesture.Paper;
            Gesture Scissor = Gesture.Scissor;
            Gesture Draw = Gesture.Draw;

            if (player1 == Rock && player2 == Scissor || player2 == Rock && player1 == Scissor)
                return Rock;
            if (player1 == Scissor && player2 == Paper || player2 == Scissor && player1 == Paper)
                return Scissor;
            if (player1 == Rock && player2 == Paper || player2 == Rock && player1 == Paper)
                return Paper;

            return Draw;
        }
    }
}

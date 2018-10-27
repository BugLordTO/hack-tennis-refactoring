using System;

namespace Hack.Lib
{
    public class TennisGame2 : ITennisGame
    {
        private int player1Point = 0;
        private int player2Point = 0;

        private string player1Result = string.Empty;
        private string player2Result = string.Empty;
        private string player1Name;
        private string player2Name;

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        private string GetScoreText(int point)
        {
            if (point == 0)
                return "Love";
            else if (point == 1)
                return "Fifteen";
            else if (point == 2)
                return "Thirty";
            else if (point == 3)
                return "Forty";
            else throw new NotSupportedException();
        }

        public string GetScore()
        {            
            if (player1Point == player2Point)
            {
                if(player1Point < 3)
                    return $"{GetScoreText(player1Point)}-All";
                else
                    return "Deuce";
            }
            else if (player1Point < 4 && player2Point < 4)
            {
                return $"{GetScoreText(player1Point)}-{GetScoreText(player2Point)}";
            }
            else if(Math.Abs(player1Point - player2Point) == 1)
            {
                if (player1Point > player2Point)
                    return "Advantage player1";
                else
                    return "Advantage player2";
            }
            else
            {
                if (player1Point > player2Point)
                    return "Win for player1";
                else
                    return "Win for player2";
            }
        }

        public void WonPoint(string player)
        {
            if (player == "player1")
                P1Score();
            else
                P2Score();
        }

        private void P1Score()
        {
            player1Point++;
        }

        private void P2Score()
        {
            player2Point++;
        }
    }
}

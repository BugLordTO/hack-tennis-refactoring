using System;

namespace Hack.Lib
{
    public class TennisGame2 : ITennisGame
    {
        private int player1Point = 0;
        private int player2Point = 0;
        private string player1Name;
        private string player2Name;
        private string[] scoreTexts = { "Love", "Fifteen","Thirty", "Forty" };

        public TennisGame2(string player1Name, string player2Name)
        {
            this.player1Name = player1Name;
            this.player2Name = player2Name;
        }

        public string GetScore()
        {            
            if (player1Point == player2Point)
                return player1Point < 3 ? $"{scoreTexts[player1Point]}-All" : "Deuce";
            else if (player1Point < 4 && player2Point < 4)
                return $"{scoreTexts[player1Point]}-{scoreTexts[player2Point]}";
            else if(Math.Abs(player1Point - player2Point) == 1)
                return $"Advantage {GetAdvantagePlayer()}";
            else
                return $"Win for {GetAdvantagePlayer()}";
        }

        public string GetAdvantagePlayer()
        {
            return player1Point > player2Point ? player1Name : player2Name;
        }

        public void WonPoint(string player)
        {
            if (player == player1Name)
                player1Point++;
            else
                player2Point++;
        }
    }
}

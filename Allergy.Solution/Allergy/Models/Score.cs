using System;

namespace Allergy.Score
{
    public class Scores
    {
        private int _userScore = 0;
        private string[] _allergyArray = { "","","","","","","","" };

        public string GetAllergyArray() 
        {
            string finalString = "";
            for (int i = 0; i < _allergyArray.Length; i++)
            {
                string arrayElement = _allergyArray[i];
                if( arrayElement.Length > 0)
                {
                    finalString += (_allergyArray[i] + " ");
                } 
            }
            return finalString;
        }

        public void SetArray(int index, string value)
        {
            _allergyArray[index] = value;
        }

        public void SetScore(int score)
        {
            _userScore += score;
        }

        public int GetScore()
        {
            return _userScore;
        }
    }
}

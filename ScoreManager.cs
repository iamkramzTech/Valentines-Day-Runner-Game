using static System.Formats.Asn1.AsnWriter;

namespace ValentinesDay
{
    public class ScoreManager
    {
        private int _score;
        public int Score=>_score;
        public ScoreManager()
        {
            _score = 0;
        }
        public void IncrementScore(int amount)
        {
            _score += amount;
        }
        public void ResetScore()
        {
            _score = 0;
        }

    }
}

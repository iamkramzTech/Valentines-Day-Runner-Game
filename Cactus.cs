using System;
using System.Windows.Forms;
namespace ValentinesDay
{
    public class Cactus : IObstacle, ISpeed
    {
        public PictureBox PictureBox { get; }
        private int _obstacleSpeed;
        public int ObstacleSpeed => _obstacleSpeed;
        public ObstacleType Type => ObstacleType.Cactus;

        public ScoreManager scoreManager { get; }
        private Form form;
        private Random random;
        public Cactus(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
          //  _obstacleSpeed = obstacleSpeed;
        }
        public bool CollidesWithCharacter(ICharacter character)
        {

            if (PictureBox.Bounds.IntersectsWith(character.CharacterPictureBox.Bounds))
            {
                MessageBox.Show("Character Die");
                return true;
            }

            return false;
        }

        public void IncreaseSpeed(int amount)
        {

            if (scoreManager.Score > 5)
            {
                _obstacleSpeed += amount;
            }
        }
    }
}

namespace ValentinesDay
{
    public class Heart : IObstacle
    {
        public PictureBox PictureBox { get; }
        public ObstacleType Type => ObstacleType.Heart;
        public ScoreManager scoreManager { get; }
        public Heart(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
        }
        public bool CollidesWithCharacter(ICharacter character)
        {

            if (PictureBox.Bounds.IntersectsWith(character.CharacterPictureBox.Bounds))
            {
                // Implement score increment logic here
                // For example: score += 10;
                scoreManager.IncrementScore(1);
                return true; // Return true to indicate a collision has occurred
            }
            return false;

        }
        
    }
}

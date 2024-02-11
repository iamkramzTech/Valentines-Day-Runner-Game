namespace ValentinesDay
{
    public class Mario : Character
    {
        /// <summary>
        /// Create an Instance of Mario Character Inherited from base Class Character, and ICharacter
        /// </summary>
        /// <param name="pictureBox">PictureBox Control of the character</param>
        /// <param name="gravity">set an integer gravity of the Character </param>
        /// <param name="velocity">set an integer velocity of the character</param>
        public Mario(PictureBox pictureBox, int gravity, int velocity) : base(pictureBox, gravity, velocity)
        {
            
        }
        /// <summary>
        /// Function for checking the movemet of a character
        /// </summary>
        /// <param name="isJumping">boolean check if character is jumping</param>
        /// <param name="groundLevel">int ground level of a character</param>
        public override void Update(bool isJumping, int groundLevel)
        {
            if(isJumping)
            {
                Velocity = -10;
            }
            Velocity += Gravity;
            CharacterPictureBox.Top += Velocity;

            if(CharacterPictureBox.Top >=groundLevel)
            {
                CharacterPictureBox.Top = groundLevel;
                Velocity = 0;
            }
        }

        /// <summary>
        /// Function to Jump a character when keys for jumping is pressed
        /// </summary>
        public override void Jump()
        {
            Velocity = -30;
        }
    }
}

namespace ValentinesDay
{
    public class Mario : Character
    {
        private const int _MaxJumpDuration = 1; // Maximum duration of the jump
        private int _jumpDuration; // Duration of the current jump
        private SoundEffects _jumpingSound = new JumpSoundEffects();
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
            if(isJumping && _jumpDuration < _MaxJumpDuration)
            {
               // Velocity = -40;
                Jump();
                _jumpDuration++;
            }
            else
            Velocity += Gravity;

            // Update the position of the character
            CharacterPictureBox.Top += Velocity;

            // Check if the character has landed
            if (CharacterPictureBox.Top >= groundLevel)
            {
                CharacterPictureBox.Top = groundLevel;
                Velocity = 0;
                _jumpDuration = 0; // Reset the jump duration when the character lands
            }
        }

        /// <summary>
        /// Function to Jump a character when keys for jumping is pressed
        /// </summary>
        public override void Jump()
        {
            Velocity = -40;
            _jumpingSound.PlaySound();
        }
    }
}

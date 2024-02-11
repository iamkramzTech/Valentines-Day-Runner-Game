using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValentinesDay
{
    public abstract class Character : ICharacter
    {
        public PictureBox CharacterPictureBox { get; }
        public int Gravity { get; set; }
        public int Velocity { get; set; }
        public Character(PictureBox pictureBox,int gravity,int velocity)
        {
            CharacterPictureBox = pictureBox;
            Gravity = gravity;
            Velocity = velocity;
           
        }
        public abstract void Update(bool isJumping, int groundLevel);
        public abstract void Jump();
       
    }
}

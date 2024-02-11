using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValentinesDay
{
    public interface ICharacter
    {
        PictureBox CharacterPictureBox { get; }
        int Velocity { get; set; }
        int Gravity { get; set; }
        void Update(bool isJumping, int groundLevel);
        void Jump();
    }
}

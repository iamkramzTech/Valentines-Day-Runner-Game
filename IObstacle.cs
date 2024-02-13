using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValentinesDay
{
    public interface IObstacle
    {
        PictureBox PictureBox { get; } // Represents the PictureBox control used for the obstacle
        ObstacleType Type { get; } // Represents the type of obstacle
        public ScoreManager scoreManager { get; }
        
        
        bool CollidesWithCharacter(ICharacter character); // Method to check collision with a character 
    }

    public interface ISpeed
    {
        int ObstacleSpeed { get; }
    }
}

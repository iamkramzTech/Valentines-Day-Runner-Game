using System.Media;
namespace ValentinesDay
{
    public class RunningSoundEffects : SoundEffects
    {
        private SoundPlayer _sound = new SoundPlayer(@"sound\character-running.wav");
        public override void PlaySound()
        {
           
            _sound.Play();
        }
        public override void StopSound()
        {
            _sound.Stop();
        }
    }
}

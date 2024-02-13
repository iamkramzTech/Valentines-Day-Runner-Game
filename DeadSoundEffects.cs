using System.Media;

namespace ValentinesDay
{
    public class DeadSoundEffects : SoundEffects
    {
        private SoundPlayer _sound = new SoundPlayer(@"sound\character-died.wav");
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

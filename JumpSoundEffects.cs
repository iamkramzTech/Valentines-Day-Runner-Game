﻿using System.Media;

namespace ValentinesDay
{
    public class JumpSoundEffects : SoundEffects
    {
        private SoundPlayer _sound = new SoundPlayer(@"sound\character-jump.wav");
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

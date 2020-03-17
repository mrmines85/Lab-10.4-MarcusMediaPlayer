using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
    class MediaPlayer
    {

        public void PlayMedia(IAudioPlayer media)
        {
            media.Play();
        }
    }
}

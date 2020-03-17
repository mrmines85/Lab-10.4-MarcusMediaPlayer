using System;

namespace ConsoleApp21
{
    class Program
    {

        public static void Main()
        {

            Artist bone = new Artist("Bone Thugs N Harmony");
            bone.AddToPlaylist("Foe the love of $");
            bone.AddToPlaylist("Everyday Thang");
            bone.AddToPlaylist("Thuggish Ruggish Bone");
            bone.AddToPlaylist("Thugz Cry");

            MediaPlayer player = new MediaPlayer();
            player.PlayMedia(bone);

            AudioBook modeone = new AudioBook("Mode One: Let the Women Know What You're REALLY Thinking", "Alan Roger Currie");
            player.PlayMedia(modeone);

            MovieSoundTrack xmenFC = new MovieSoundTrack("Xmen: First Class");
            xmenFC.SelectTrack("Frankenstein's Monster");
            player.PlayMedia(xmenFC);

        }
    }
}

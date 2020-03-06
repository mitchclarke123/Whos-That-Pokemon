using System;
using System.Media;

namespace PokeDexApp
{
    
    public class PokedexLogin
    {
        
        private bool _on = false;
        private int _volume = 1;
        
        public bool On
        {
            get { return _on; }
            set
            {
                _on = value;
            }

        }

        public void Clip()
        {
            SoundPlayer song = new SoundPlayer(@"C:\Users\TECH-W129birm\Documents\Sparta Global Mitchell Work\Week 6\Songs\pokemon jhoto.wav");
            song.Play();
            song.PlayLooping();
        }
    }
}

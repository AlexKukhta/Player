using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player
{
    public class AudioPlayer
    {
        private int _volume;
        const int MIN_VALUE = 0;
        const int MAX_VALUE = 100;
        private bool _locked;
        private bool _playing;

        private bool Playing;
        public int Volume
        {
            get
            {
                return _volume;
            }
            private set
            {
                if (value < MIN_VALUE)
                {
                    _volume = MIN_VALUE;
                }
                else if (value > MAX_VALUE)
                {
                    _volume = MAX_VALUE;
                }
                else
                {
                    _volume = value;
                }
            }
        }
        public Song[] Songs { get; private set; }

        public void VolumeUp()
        {
            if (_locked==false)
                Volume++;
        }

        public void VolumeDown()
        {
            if (_locked==false)
                Volume--;
        }

        public void VolumeChange(int step)
        {
            if (_locked==false)
            Volume += step;
           
        }

        public void Play()
        {
            if (_locked) return;
            _playing = true;
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Player playing: {Songs[i].Name}");
                System.Threading.Thread.Sleep(1000);
            }
            
        }

        public void Stop()
        {
            if (_locked) return;
            _playing = false;
            Console.WriteLine("Player is Stopped");
        }

        public void Lock()
        {
            _locked = true;
        }
       
        public void Unlock()
        {
            
            _locked = false;
        }

        public void Add(Song[] songs)
        {
            songs = songsArray;
        }


        
    }
}

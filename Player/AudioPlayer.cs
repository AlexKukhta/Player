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
        bool Locked;
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
        public Song[] Songs;

        public void VolumeUp()
        {
            Volume++;
        }

        public void VolumeDown()
        {
            Volume--;
        }

        public void VolumeChange(int step)
        {
            Volume += step;
        }

        public void Play()
        {
            Console.WriteLine("Player playing: {Songs[0].Name}");
        }

        public void Stop()
        {
            Console.WriteLine("Player is Stopped");
        }

        public void Lock()
        {
            return Locked = true;
        }
       
        public void Unlock()
        {
            return Locked = false;
        }
    }
}

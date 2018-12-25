using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Player
{
    class Player
    {
        private int _volume;
        public Songs[] Songs;

        const int MIN_VOLUME = 0;
        const int MAX_VOLUME = 100;

        public int Volume
        {
            get{ return _volume;}
            set 
            {
                if (value<MIN_VOLUME)
                {
                    _volume=MIN_VOLUME;
                }
                else if (value > MAX_VOLUME)
                {
                    _volume = MAX_VOLUME;
                }
                else
                {
                    value = _volume;
                }
            }
        }
        
        public void VolumeUp()
        {
            _volume++;
        }

        public void VolumeDown()
        {
            _volume--;
        }

        public void VolumeChange(int step)
        {
             _volume += step;
        }

        public void Play()
        {
            Console.WriteLine("Player is Playing");
        }

        public void Stop()
        {
            Console.WriteLine("Player has Stopped");
        }

    }
}

using System;

namespace delegates_repeat
{
    public class TimerModel
    {
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public TimerModel(int min, int sec)
        {
            Minutes = min;
            Seconds = sec;
        }
    }
}
using System;
using System.Threading;

namespace delegates_repeat
{
    /// <summary>
    /// Class that describes the timer instance
    /// Contains two fields: seconds and message to transmit
    /// seconds: corresponds for seconds for timer countdown
    /// message to transmit: corresponds for message that should be transmitted after 
    /// the timer elapsed
    /// </summary>
    public class TimerModel
    {
        private int seconds;
        private string messageToTransmit;

        public TimerModel(int sec, string message) {
            this.seconds = sec;
            this.messageToTransmit = message;
        }

        /// <summary>
        /// Methods that starts the count down and raises events of its change and end
        /// </summary>
        public void StartCountDown() {
            OnTimerChanged(new TimerChangedEventArgs() { TimerCurrentTimer = seconds });
            while(seconds > 0)
            {
                WaitForOneSecond();
                seconds -= 1;
                OnTimerChanged(new TimerChangedEventArgs() { TimerCurrentTimer = seconds });
            }
            OnTimerElapsed(new TimerElapsedEventArgs(){ MessageFromTimer = messageToTransmit});
        }

        private void WaitForOneSecond() {
            Thread.Sleep(1000);
        }

        /// <summary>
        /// Event that is fired when the value of timer has changed
        /// </summary>
        public event EventHandler<TimerChangedEventArgs> TimerChanged;

        protected virtual void OnTimerChanged(TimerChangedEventArgs e) {
            EventHandler<TimerChangedEventArgs> handler = TimerChanged;
            handler?.Invoke(this, e);
        }

        /// <summary>
        /// Event that is fired when timer has elapsed
        /// </summary>
        public event EventHandler<TimerElapsedEventArgs> TimerElapsed;

        protected virtual void OnTimerElapsed(TimerElapsedEventArgs e) {
            EventHandler<TimerElapsedEventArgs> handler = TimerElapsed;
            handler?.Invoke(this, e);
        }
    }

    public class TimerElapsedEventArgs : EventArgs {
        public string MessageFromTimer{ get; set;}
    }

    public class TimerChangedEventArgs : EventArgs {
        public int TimerCurrentTimer { get; set; }
    }
}
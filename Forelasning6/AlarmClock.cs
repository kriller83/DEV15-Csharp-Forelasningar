using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning6
{
    public class AlarmClock
    {
        int seconds, alarmSeconds;  //default 0
        private bool alarmOn;  //default false

        public void SetTime(int hours, int minutes)  //en klass. Public returnerar ingenting
        {
            seconds = (hours * 3600 + minutes * 60);
        }
        public int GetTime()
        {
            return seconds;
            //throw new NotImplementedException();
        }
        public void SetAlarm(int hours, int minutes)
        {
            alarmSeconds = (hours * 3600 + minutes * 60);
        }
        public void TurnAlarmOnOff(bool alarmOn)
        {
            this.alarmOn = alarmOn;
        }
    }
}
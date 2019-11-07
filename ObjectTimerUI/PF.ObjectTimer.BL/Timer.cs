using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PF.ObjectTimer.BL
{
  
    public class Stopwatch
    {
        DateTime startTime = new DateTime();



        public string ET()
        {
         
            TimeSpan elapsedTime = new TimeSpan();

          
            elapsedTime = DateTime.Now - startTime;
            return elapsedTime.ToString(@"hh\:mm\:ss");

        }
    }
}

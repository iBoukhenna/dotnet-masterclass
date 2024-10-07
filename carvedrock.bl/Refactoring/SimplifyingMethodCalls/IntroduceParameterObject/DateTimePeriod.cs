using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carvedrock.bl.refactoring.SimplifyinMethodCalls.IntroduceParameterObject
{
    public class DateTimePeriod
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        // public int IntervalInSeconds { get; set; }
    }
}

using System;
using System.Globalization;

namespace carvedrock.bl.principles.KISS
{
    public class KISS
    {        
        public string GetMonthName(int month)
        {
            if ((month < 1) || (month > 12)) 
                throw new InvalidOperationException("Month must be between 1 and 12");

            return (new DateTimeFormatInfo()).GetMonthName(month);
        }
    }
}

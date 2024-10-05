using System;

namespace carvedrock.bl.principles
{
    public class KISS
    {
        public string GetMonth(int month)
        {
            switch (month) {  
                case 1:  
                    return "January";  
                case 2:  
                    return "February";  
                case 3:  
                    return "March";  
                case 4:  
                    return "April";  
                case 5:  
                    return "May";  
                case 6:  
                    return "June";  
                case 7:  
                    return "July";  
                case 8:  
                    return "August";  
                case 9:  
                    return "September";  
                case 10:  
                    return "October";  
                case 11:  
                    return "November";  
                case 12:  
                    return "December";  
                default:  
                    throw new InvalidOperationException("The month must be in range 1 to 12");  
            }  
        }

        public string GetMonth2(int month)
        {
            if ((month < 1) || (month > 12)) throw new InvalidOperationException("The month must be in range 1 to 12");
            string[] months = {  
                "January",
                "February",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };  
            return months[month - 1];  
        }
    }
}

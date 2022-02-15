using System;
using System.Globalization;

namespace Services{
    class HourContracts{
        public DateTime Date {get;set;}
        public double Value { get; set; }
        public int Hours {get;set;}


        public HourContracts()
        {

        }
        public HourContracts(DateTime date, double value, int hours)
        {
            Date = date;
            Value = value;
            Hours = hours;
        }


        public double TotalValue()
        {
            return Hours*Value;
        }
        
    }

}
using System;

namespace ComPortTestForm
{
    public class GetValues
    {
        public int Id { get; set; }
        public string Voltage { get; set; }
        public string Ampere { get; set; }
        public TimeSpan TimeMesaure { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;

        public GetValues(string voltage, string ampere, TimeSpan time) //,DateTime dateTime)
        {

            Voltage = voltage;
            Ampere = ampere;
            TimeMesaure = time;
            //DateTime = dateTime;
        }

        public GetValues()
        {

        }
    }
}
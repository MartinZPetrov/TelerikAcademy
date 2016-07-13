using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType BatteryType;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double HoursIdle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }
        public double HoursTalk
        {
            get { return hoursTalk; }
            set { hoursTalk = value; }
        }
        public Battery() : this("Standart", 2.22, 3.33, BatteryType.LiIon) { }

        public Battery (string model, double hoursIdle, double hoursTalk, BatteryType battery)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            BatteryType = battery;
        }
    }

    public enum BatteryType
    {
        LiIon,
        NiMH, 
        NiCd
    }
}

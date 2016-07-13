using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class GSM
    {
        private string model;
        private string manafacturer;
        private decimal price;
        private string owner;
        private Display dispay;
        private Battery battery;
        private static GSM iPhone4S;
        private List<Call> callHitory = new List<Call>();


        public List<Call> CallHistory
        {
            set { this.callHitory = value; }

            get
            {
                return new List<Call>(this.callHitory);
            }
        }


        public static GSM IPhone4S 
        {
            get { return iPhone4S; }
            private set { iPhone4S = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Manafacturer
        {
            get { return manafacturer; }
            set { manafacturer = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }


        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }

        public Battery Battery
        {
            get { return battery; }
            set { battery = value; }
        }

        public Display Display
        {
            get { return dispay; }
            set { dispay = value; }
        }

        
        static GSM()
        {
            IPhone4S = new GSM("IPhone", "Apple", 999.99m, "Marto", new Battery(), new Display());
        }

        public GSM(string model, string manafacturer): this(model, manafacturer, 100.0m , "PeshKolibrata", new Battery(), new Display())
        {
            this.Model = model;
            this.Manafacturer = manafacturer;
        }


        public GSM(string model, string manafacturer, decimal price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manafacturer = manafacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        public override string ToString()
        {
            return String.Format("Manifacturer: {0}\n" +
                                  "Model: {1}\n" +
                                  "Price: {2}\n" +
                                  "Owner: {3}\n" +
                                  "Battery: {4}\n" +
                                  "Display: {5}",
                                  this.Manafacturer, this.Model, this.Price, this.Owner,
                                  this.Battery.ToString(), this.Display.ToString());
        }

        public void AddCall(Call call)
        {
            this.callHitory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            this.callHitory.Remove(call);
        }

        public void DeleteCallHistory()
        {
            this.callHitory.Clear();
        }

        public decimal GetTotalCallPrice(decimal pricePerMinute)
        {
            decimal value = 0;
            decimal allCallsInSecs = (decimal)(this.callHitory.Select(x => x.Duration).Sum());
            return value * (allCallsInSecs / pricePerMinute);
        }

        public string PrintCallHistory()
        {
            return string.Format("Calls history:\n{0}", string.Join(Environment.NewLine, this.CallHistory));
        }
    }
}

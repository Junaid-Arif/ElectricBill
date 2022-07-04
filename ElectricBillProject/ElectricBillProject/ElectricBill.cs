

namespace ElectricBillProject
{
    internal class ElectricBill
    {
        private int units { get; set; }


        public ElectricBill()
        {
            units = 0;
        }


        public int Commercial(int units)
        {
            if (units < 0)
            {
                return units;
            } 
            else if (units == 0) 
            {
                return units;
            } 
            else if (units > 0  && units <= 100)
            {
                units = units * 8;
                return units;
            }
            else if (units > 100  && units <= 200)
            {
                units = units * 21;
                return units;
            }
            else if (units > 200  && units <= 500)
            {
                units = units * 23;
                return units;
            }
            else if(units > 500)
            {
                units = units * 79;
                return units;
            }
           return units;
        }
        public int Residential(int units)
        {
            if (units < 0)
            {
                return units;
            }
            else if (units == 0)
            {
                return units;
            }
            else if (units > 0  && units <= 100)
            {
                units = units * 5;
                return units;
            }
            else if (units > 100  && units <= 200)
            {
                units = units * 17;
                return units;
            }
            else if (units > 200  && units <= 500)
            {
                units = units * 23;
                return units;
            }
            else if(units > 500)
            {
                units = units * 69;
                return units;
            }
            return units;
        }
    }
}

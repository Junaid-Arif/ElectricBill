

namespace ElectricBillProject
{
    internal class User: ElectricBill
    {
        private double bill_total { get; set; }

        public User()
        {
            bill_total = 0;
        }


        public void getElectricBill(int units,string type)
        {
            if(type == "residential")
            {
                bill_total = Residential(units);
                double tax = (bill_total/100) *13;
                bill_total = bill_total + tax;
                Console.WriteLine("The total bill is: "+ bill_total );

            }else if(type == "commercial")
            {
                bill_total = Commercial(units);
                double tax = (bill_total/100) *17;
                bill_total = bill_total + tax;
                Console.WriteLine("The total bill is: "+ bill_total );
            }
        }
    }
}

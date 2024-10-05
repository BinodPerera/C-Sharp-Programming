namespace Prototype 
{
    public class Program
    {
        public static void Main(String[] args)
        {
            TwoWheelerVehicle honda250 = new TwoWheelerVehicle("250","honda","100000","black","petrol");
            honda250.DisplayDetails();

            TwoWheelerVehicle honda125 = (TwoWheelerVehicle)honda250.Clone();
            honda125.engine = "125";
            honda125.DisplayDetails();


            FourWheelerVehicle Q2 = new FourWheelerVehicle("1000", "Audi", "200000", "red","Auto");
            Q2.DisplayDetails();

            FourWheelerVehicle Q2Sport = (FourWheelerVehicle)Q2.Clone();
            Q2Sport.transmission = "manual";
            Q2Sport.DisplayDetails();

        }
    }

    
}


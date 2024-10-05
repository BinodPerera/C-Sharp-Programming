

using BuilderPattern2;

namespace BuilderPattern2
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //BugattiBuilder bugattiBuilder = new BugattiBuilder();
            //Director director = new Director();

            //director.Construct(bugattiBuilder);
            //Car bugattiCar = bugattiBuilder.BuildCar();
            //bugattiCar.Display();

            //LamboBuilder lamboBuilder = new LamboBuilder();

            //director.Construct(lamboBuilder);
            //Car lamboCar = lamboBuilder.BuildCar();
            //lamboCar.Display();

            Car car = new Director(new ElectricCarBuilder()).Construct();
            car.Display();


        }
    }

}
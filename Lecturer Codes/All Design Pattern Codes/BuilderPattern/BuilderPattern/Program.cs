namespace BuilderPattern
{
  public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new Car.CarBuilder()
                .Id(121)
                .Brand("Bugatti")
                .Model("Chiron")
                .Color("Blue")
                .Build();

            
            car.Display();
            //Director director = new Director();
            //CarBuilder carBuilder = new CarBuilder();
            //director.BuildBugatti(carBuilder);
            //Car car = carBuilder.Build();
            //car.Display();


        }
    }

}
using AbstractFactory;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MsiManufacturer msiManufacturer = new MsiManufacturer();
            msiManufacturer.AssmbleGpu();
            msiManufacturer.AssmbleMonitor();

            AsusManufacturer asusManufacturer = new AsusManufacturer();
            asusManufacturer.AssmbleGpu();
            asusManufacturer.AssmbleMonitor();
        }
    }
}
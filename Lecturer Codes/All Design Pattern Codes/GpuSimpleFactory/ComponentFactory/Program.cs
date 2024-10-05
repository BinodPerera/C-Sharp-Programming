using ComponentFactory;

namespace ComponentFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MsiManufacturer msiManufacturer = new MsiManufacturer();
            msiManufacturer.AssmbleComponent("Gup");
            msiManufacturer.AssmbleComponent("Monitor");

            AsusManufacturer asusManufacturer = new AsusManufacturer();
            asusManufacturer.AssmbleComponent("Gpu");
            asusManufacturer.AssmbleComponent("Monitor");
        }
    }
}
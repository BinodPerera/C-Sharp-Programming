
namespace GpuSimpleFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MsiManufacturer msiManufacturer = new MsiManufacturer();
            msiManufacturer.assmbleGpu();

            AsusManufacturer asusManufacturer = new AsusManufacturer();
            asusManufacturer.assmbleGpu();
        }
    }
}





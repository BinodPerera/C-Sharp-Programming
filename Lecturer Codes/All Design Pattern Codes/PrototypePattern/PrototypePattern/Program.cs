namespace PrototypePattern
{
    public class Program
    {
        public static void Main(String[] args)
        {
            //object 01
            Circle circlePrototype = new Circle("red");
            //clone of the object 01
            Circle c1 = (Circle)circlePrototype.Clone();
            //object 01 draw method
            circlePrototype.Draw();
            //clone object draw method
            c1.Draw();
        }
    }
}


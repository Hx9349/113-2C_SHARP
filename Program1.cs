namespace Chap9Test2_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box box;
            box = new Box(5, 5, 5);

            Console.WriteLine("盒子體積：" + box.Volume());
            Console.WriteLine("盒子面積：" + box.Area());
        }
    }

    public class Box
    {
        public double Width, Height, Length; //Properties
        public Box(double width, double height, double length) //Constructors
        {
            this.Width = width;
            this.Height = height;
            this.Length = length;
        }

        public double Volume()  //Method Volume()
        {
            return Width * Height * Length; 
        }
        public double Area()  //Method Area()
        {
            double area = Width * Height;
            return area;
        }
    }
}

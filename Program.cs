namespace Module3HW3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var class1 = new Class1();
            var class2 = new Class2();

            Show(class2.Calc(class1.Pow, 2, 3)(3));
        }

        public static void Show(bool b)
        {
            Console.WriteLine(b);
        }
    }
}

using System;

namespace Module3HW3
{
    public class Class1
    {
        public Action<bool> ShowHandler { get; } = Program.Show;

        public int Pow(int x, int y)
        {
            return x * y;
        }
    }
}

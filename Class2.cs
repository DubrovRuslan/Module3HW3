using System;

namespace Module3HW3
{
    public class Class2
    {
        private int _resultPow;
        public Func<int, bool> Calc(Func<int, int, int> powHandler, int x, int y)
        {
            _resultPow = powHandler(x, y);
            Func<int, bool> resultHandler = Result;
            return resultHandler;
        }

        public bool Result(int x)
        {
            if (_resultPow % x == 0)
            {
                return true;
            }

            return false;
        }
    }
}

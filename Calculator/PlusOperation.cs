using System;
using System.Linq;

namespace Calculator
{
    public class PlusOperation: IOperation
    {
        double Left { get; set; }
        double Right { get; set; }

        public PlusOperation(double left, double right)
        {
            Left = left;
            Right = right;
        }

        double IOperation.Calculate()
        {
            return Left + Right;
        }
    }
}

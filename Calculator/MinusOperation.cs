using System;
using System.Linq;

namespace Calculator
{
    public class MinusOperation: IOperation
    {
        double Left { get; set; }
        double Right { get; set; }

        public MinusOperation(double left, double right)
        {
            Left = left;
            Right = right;
        }

        double IOperation.Calculate()
        {
            return Left - Right;
        }
    }
}

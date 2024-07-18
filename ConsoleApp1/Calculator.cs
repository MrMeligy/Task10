using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator<T> where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        public Func<T, T, T> Add { get; set; }
        public Func<T, T, T> Subtract { get; set; }
        public Func<T, T, T> Multiply { get; set; }
        public Func<T, T, T> Divide { get; set; }

        public Calculator()
        {
            Add = AddOperation;
            Subtract = SubtractOperation;
            Multiply = MultiplyOperation;
            Divide = DivideOperation;
        }

        private T AddOperation(T a, T b)
        {
            return (dynamic)a + b;
        }

        private T SubtractOperation(T a, T b)
        {
            return (dynamic)a - b;
        }

        private T MultiplyOperation(T a, T b)
        {
            return (dynamic)a * b;
        }

        private T DivideOperation(T a, T b)
        {
            return (dynamic)a / b;
        }
    }
}

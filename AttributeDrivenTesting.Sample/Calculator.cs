using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AttributeDrivenTesting.Attributes;

namespace AttributeDrivenTesting.Sample
{
    public class Calculator
    {
        [ShouldReturn(9)]
        public int Sum([WhenThisIs(5)] int a, [WhenThisIs(4)] int b)
        {
            return a + b;
        }

        [ShouldReturn(false)]
        public bool IsPrime([WhenThisIs(15)] int number)
        {
            if (number < 1)
                throw new ArgumentException("Invalid number. The value should be greater than 0");

            if (number == 1)
                return true;

            for (int i = 2; i < number; i++)
                if (number % i == 0)
                    return false;

            return true;
        }

    }
}

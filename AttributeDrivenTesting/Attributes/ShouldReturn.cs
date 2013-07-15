using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeDrivenTesting.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    public class ShouldReturnAttribute : Attribute
    {
        public object ExpectedReturnValue { get; private set; }

        public ShouldReturnAttribute(object expectedReturnValue)
        {
            this.ExpectedReturnValue = expectedReturnValue;
        }
    }
}

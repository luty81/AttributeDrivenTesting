using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AttributeDrivenTesting.Attributes
{
    [AttributeUsage(AttributeTargets.Parameter)]
    public class WhenThisIsAttribute : Attribute
    {
        public WhenThisIsAttribute(object values)
        {
            this.AttributeValue = values;
        }

        public object AttributeValue { get; set; }
    }

}

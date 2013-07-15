using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using AttributeDrivenTesting.Attributes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AttributeDrivenTesting.Extensions
{
    public static class ObjectExtensions
    {
        public static void TestAllPublicMethods(this object instance)
        {
            var allMethods = instance.GetType().GetMethods(BindingFlags.Public | BindingFlags.Instance);
            var methodInfo =
                allMethods
                    .Where(m => m.GetCustomAttributes(typeof(ShouldReturnAttribute), true).Count() > 0).First();
                    
            var methodAttributes = methodInfo.GetCustomAttributes(typeof(ShouldReturnAttribute), true);
            var argumentAttributes = 
                methodInfo
                    .GetParameters()
                    .Select(p => p.GetCustomAttributes(typeof(WhenThisIsAttribute), true)
                    .First());


            var shouldReturnAttribute = (ShouldReturnAttribute)methodAttributes.First();
            var givenArguments = argumentAttributes.Select(arg => ((WhenThisIsAttribute)arg).AttributeValue).ToArray();
            var methodReturnValue = methodInfo.Invoke(instance, givenArguments);

            Assert.AreEqual(shouldReturnAttribute.ExpectedReturnValue.ToString(), methodReturnValue.ToString());

        }
    }
}

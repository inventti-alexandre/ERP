using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AOP.Cache;
using Castle.DynamicProxy;

namespace AOP.Core
{
    public static class MethodRead
    {
        public static Attribute GetMethodeAttribute<TKEY>(IInvocation invocation)
        {
            var methodInfo = invocation.MethodInvocationTarget ?? invocation.Method;

            return Attribute.GetCustomAttribute(methodInfo, typeof (TKEY), true);
        }


        public static string GetCacheKey(IInvocation invocation)
        {
            // کار کردن با هش سریعتر خواهد بود
            return invocation.Arguments.Aggregate(invocation.Method.Name,
                (current, argument) => current + (":" + argument));
        }
    }
}
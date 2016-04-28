using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOP.Log
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LogMethodAttribute : Attribute
    {
    }
}
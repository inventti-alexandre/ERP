using System;

namespace AOP.Cache
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CacheMethodAttribute : Attribute
    {
        public CacheMethodAttribute()
        {
            // مقدار پیش فرض
            SecondsToCache = 30;
        }

        public double SecondsToCache { get; set; }
    }
}
using System;
using System.Linq;
using System.Web;
using AOP.Core;
using Castle.DynamicProxy;

namespace AOP.Cache
{
    public class CacheInterceptor : IInterceptor
    {
        private static readonly object LockObject = new object();

        public void Intercept(IInvocation invocation)
        {
            CacheMethod(invocation);
        }

        private static void CacheMethod(IInvocation invocation)
        {
            var cacheMethodAttribute = MethodRead.GetMethodeAttribute<CacheMethodAttribute>(invocation);
            if (cacheMethodAttribute == null)
            {
                // متد جاری توسط ویژگی کش شدن مزین نشده است
                // بنابراین آن‌را اجرا کرده و کار را خاتمه می‌دهیم
                invocation.Proceed();
                return;
            }

            // دراینجا مدت زمان کش شدن متد از ویژگی کش دریافت می‌شود
            var cacheDuration = ((CacheMethodAttribute) cacheMethodAttribute).SecondsToCache;

            // برای ذخیره سازی اطلاعات در کش نیاز است یک کلید منحصربفرد را
            //  بر اساس نام متد و پارامترهای ارسالی به آن تهیه کنیم
            var cacheKey = MethodRead.GetCacheKey(invocation);

            var cache = HttpRuntime.Cache;
            var cachedResult = cache.Get(cacheKey);


            if (cachedResult != null)
            {
                // اگر نتیجه بر اساس کلید تشکیل شده در کش موجود بود
                // همان را بازگشت می‌دهیم
                invocation.ReturnValue = cachedResult;
            }
            else
            {
                lock (LockObject)
                {
                    // در غیر اینصورت ابتدا متد را اجرا کرده
                    invocation.Proceed();
                    if (invocation.ReturnValue == null)
                        return;

                    // سپس نتیجه آن‌را کش می‌کنیم
                    cache.Insert(key: cacheKey,
                        value: invocation.ReturnValue,
                        dependencies: null,
                        absoluteExpiration: DateTime.Now.AddSeconds(cacheDuration),
                        slidingExpiration: TimeSpan.Zero);
                }
            }
        }


       
    }
}
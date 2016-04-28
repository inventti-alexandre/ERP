using System.Web;

namespace ServiceLayer.Session
{
    public class WebSessionProvider : ISessionProvider
    {
        private readonly HttpSessionStateBase _session;

        public WebSessionProvider(HttpSessionStateBase session)
        {
            _session = session;
        }

        public object Get(string key)
        {
            return _session[key];
        }

        public T Get<T>(string key) where T : class
        {
            return _session[key] as T;
        }

        public void Remove(string key)
        {
            _session.Remove(key);
        }

        public void RemoveAll()
        {
            _session.RemoveAll();
        }

        public void Store(string key, object value)
        {
            _session[key] = value;
        }
    }
}
namespace Singleton
{
    internal class Instance
    {
        private static Instance _instance;
        private static readonly object _lock = new object();
        private  Instance() {}

        internal static Instance CreateInstance()
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new Instance();
                }
                return _instance;
            }
        }
    }
}
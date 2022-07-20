namespace Singleton
{
    internal class Product
    {
        private static Product _product;
        private static readonly object _lock = new object();
        private Product() {}

        internal static Product CreateInstance()
        {
            lock (_lock)
            {
                if (_product == null)
                {
                    _product = new Product();
                }
                return _product;
            }
        }
    }
}
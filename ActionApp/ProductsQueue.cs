using System.Collections.Generic;

namespace ActionApp
{
    /// <summary>
    /// Class of products in queue
    /// It contains mathods add, drop and count of elements in queue of products
    /// </summary>
    class ProductsQueue
    {
        Queue<bool> _queue;

        public delegate void SenderHandler(string message);
        public event SenderHandler Sender;

        public ProductsQueue()
        {
            _queue = new();
        }

        string GetProductsQueue()
        {
            string output = "";
            foreach (bool q in _queue)
                if (q) output += "1";
                else output += "0";
            return output;
        }

        public int GetCount()
        {
            return _queue.Count;
        }

        public void AddProduct(bool product)
        {
            if (_queue.Count < 5)
            {
                _queue.Enqueue(product);
                Sender?.Invoke(GetProductsQueue());
            }
        }

        public void DropProduct()
        {
            if (_queue.Count > 0)
            {
                _queue.Dequeue();
                Sender?.Invoke(GetProductsQueue());
            }
        }
    }
}

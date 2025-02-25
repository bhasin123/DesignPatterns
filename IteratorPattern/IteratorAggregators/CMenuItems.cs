using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.IteratorAggregators
{
    internal class CMenuItems : IEnumerator<string>, IMenu
    {
        public List<string> MenuItems;
        private int position = -1;
        private bool disposedValue;

        public CMenuItems()
        {
            MenuItems = new List<string>()
                {
                    "Idly",
                    "Dosa",
                    "Pongal",
                    "Vada",
                    "Poori"
                };
        }

        public IEnumerable<string> CreateEnumerator()
        {
            return MenuItems;
        }

        public object Current
        {
            get
            {
                try
                {
                    if(position < 0 || position >= MenuItems.Count)
                        throw new InvalidOperationException();

                    return MenuItems[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }


        object IEnumerator.Current => Current;

        string IEnumerator<string>.Current => Convert.ToString(Current);

        public bool MoveNext()
        {
            position++;
            return position < MenuItems.Count;
        }

        public void Reset()
        {
            position = -1;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        ~CMenuItems()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        IEnumerator<string> IEnumerable<string>.GetEnumerator()
        {
            return this;
        }

        public IEnumerator GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

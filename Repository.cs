using System.Collections.Generic;
using System;
using System.Linq;

namespace Generics
{
    public class Repository<T>
    {
        private List<T> _data = new List<T>();

        public void Create(T item) => _data.Add(item);

        public T Read(Func<T, bool> predicate) => _data.FirstOrDefault(predicate);

        public IEnumerable<T> ReadAll() => _data;

        public void Update(Func<T, bool> predicate, T newItem)
        {
            var index = _data.FindIndex(item => predicate(item));
            if (index != -1) _data[index] = newItem;
        }

        public void Delete(Func<T, bool> predicate)
        {
            var item = _data.FirstOrDefault(predicate);
            if (item != null) _data.Remove(item);
        }
    }
}

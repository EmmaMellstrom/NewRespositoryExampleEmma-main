using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsCreation1
{
    class Repository<T> : IEnumerable<T>
    {
        private List<T> m_repo = new List<T>();
        public T GetItemFromDataBase(int index)
        {
            //Här skulle vi ha kod för att hämta från databas tex
            //istället för från vår fejklista
            return m_repo[index];
        }

        public void SaveToRepo(T item)
        {
            //Här sparar vi
            m_repo.Add(item);
        }

        public void RemoveItem(T item)
        {
            m_repo.Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (T val in m_repo)
            {
                yield return val;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

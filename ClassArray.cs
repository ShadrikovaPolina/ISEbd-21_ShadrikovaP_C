using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class ClassArray<T> : IEnumerator<T>, IEnumerable<T>, IComparable<ClassArray<T>>
    {
        private Dictionary<int, T> places;
        private int maxCount;
        private T defaultValue;

        public ClassArray(int size, T defVal)
        {
            defaultValue = defVal;
            places = new Dictionary<int, T>();
            maxCount = size;
        }

        public static int operator +(ClassArray<T> p, T croc)
        {
            var isalligator = croc is alligator;
            if(p.places.Count == p.maxCount)
            {
                throw new RiverOverflowException();
            }
            int index = p.places.Count;
            for (int i = 0; i < p.places.Count; i++)
            {
                if (p.CheckFreePlace(i))
                {
                    index = i;
                }
                if (croc.GetType() == p.places[i].GetType())
                {
                    if (isalligator)
                    {
                        if ((croc as alligator).Equals(p.places[i]))
                        {
                            throw new RiverAlreadyHaveException();
                        }
                    }
                    else if ((croc as crocodile).Equals(p.places[i]))
                    {
                        throw new RiverAlreadyHaveException();
                    }
                }
            }
            if (index != p.places.Count)
            {
                p.places.Add(index, croc);
                return index;               
            }
            p.places.Add(p.places.Count, croc);
            return p.places.Count - 1;
        }

        public static T operator -(ClassArray<T> p, int index)
        {
            if (p.places.ContainsKey(index))
            {
                T croc = p.places[index];
                p.places.Remove(index);
                return croc;
            }
            throw new RiverIndexOutOfRangeException();
        }

        private bool CheckFreePlace(int index)
        {
            return !places.ContainsKey(index);
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                return defaultValue;
            }
        }

        private int currentIndex;
        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public void Dispose()
        {

        }

        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }

        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int CompareTo(ClassArray<T> other)
        {
            if (this.Count() > other.Count())
            {
                return -1;
            }
            else if (this.Count() < other.Count())
            {
                return 1;
            }
            else
            {
                var thisKeys = this.places.Keys.ToList();
                var otherKeys = other.places.Keys.ToList();
                for (int i = 0; i < this.places.Count; ++i)
                {
                    if (this.places[thisKeys[i]] is crocodile && other.places[thisKeys[i]] is alligator)
                    {
                        return 1;
                    }
                    if (this.places[thisKeys[i]] is alligator && other.places[thisKeys[i]] is crocodile)
                    {
                        return -1;
                    }
                    if (this.places[thisKeys[i]] is crocodile && other.places[thisKeys[i]] is crocodile)
                    {
                        return (this.places[thisKeys[i]] is crocodile).CompareTo(other.places[thisKeys[i]] is crocodile);
                    }
                    if (this.places[thisKeys[i]] is alligator && other.places[thisKeys[i]] is alligator)
                    {
                        return (this.places[thisKeys[i]] is alligator).CompareTo(other.places[thisKeys[i]] is alligator);
                    }
                }
            }
            return 0;
        }
        
    }
}

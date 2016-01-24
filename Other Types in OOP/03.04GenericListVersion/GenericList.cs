using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._04GenericListVersion
{
    namespace _03_Generic_List
    {
        using System;
        using System.Linq;

        [Version(2, 04)]
        public class GenericList<T>
            where T : IComparable<T>
        {
            private const int defaultCapacity = 16;
            private T[] array;
            private int index;
            private int currCapacity;

            public GenericList(int capacity = defaultCapacity)
            {
                this.array = new T[capacity];
                this.index = 0;
                this.currCapacity = capacity;
            }
            public void addElement(T element)
            {
                if (this.index == this.currCapacity)
                {
                    this.Resize(this.currCapacity * 2);
                }
                this.array[this.index] = element;
                this.index++;
            }

            private void Resize(int newCapacity)
            {
                T[] newArray = new T[newCapacity];

                for (int i = 0; i < this.index; i++)
                {
                    newArray[i] = this.array[i];
                }
                this.array = newArray;
                this.currCapacity = newCapacity;
            }

            public void removeElement(int index)
            {
                if (this.index == 0)
                {
                    throw new InvalidOperationException("List is empty");
                }

                if (index < 0 || index >= this.index)
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index"));
                }
                for (int i = index; i < this.index - 1; i++)
                {
                    this.array[i] = this.array[i + 1];
                }

                this.index--;
            }

            public string Access(int index)
            {
                if (this.index == 0)
                {
                    throw new InvalidOperationException("List is empty");
                }
                if (index > this.index)
                {
                    throw new ArgumentException("Index doesn't exists");
                }
                for (int i = 0; i < this.index; i++)
                {
                    return array[index].ToString();
                }
                return "The index doesn't exists";
            }
            public void Insert(T element, int index)
            {
                if (this.index == 0)
                {
                    throw new InvalidOperationException("List is empty");
                }

                if (index < 0 || index >= this.index)
                {
                    throw new IndexOutOfRangeException(string.Format("Invalid index"));
                }

                if (this.index == this.currCapacity)
                {
                    this.Resize(this.currCapacity * 2);
                }

                for (int i = this.index; i >= index; i--)
                {
                    this.array[i] = this.array[i - 1];
                }

                this.array[index] = element;
                this.index++;
            }
            public void Clear()
            {
                for (int i = 0; i < this.index; i++)
                {
                    this.array[i] = default(T);
                }
                this.index = 0;
            }
            public string FindIndex(T element)
            {
                if (this.index == 0)
                {
                    throw new InvalidOperationException("List is empty");
                }
                for (int i = 0; i < this.index; i++)
                {
                    T currElement = this.array[i];
                    if (currElement.Equals(element))
                    {
                        return i.ToString();
                    }
                }
                return ("No match found");
            }
            public string Contains(T element)
            {
                if (this.index == 0)
                {
                    throw new InvalidOperationException("List is empty");
                }
                for (int i = 0; i < this.index; i++)
                {
                    T currElement = this.array[i];
                    if (currElement.Equals(element))
                    {
                        return "Yes,it cointains " + element;
                    }
                }
                return "No,it doesn't cointain " + element;
            }
            public T Max()
            {
                if (this.index == 0)
                {
                    throw new InvalidOperationException("List is empty");
                }
                T max = this.array[0];

                for (int i = 0; i < this.index; i++)
                {
                    T currElement = this.array[i];
                    if (currElement.CompareTo(max) > 0)
                    {
                        max = currElement;

                    }
                }
                return max;
            }
            public T Min()
            {
                if (this.index == 0)
                {
                    throw new InvalidOperationException("List is empty");
                }
                T min = this.array[0];

                for (int i = 0; i < this.index; i++)
                {
                    T currElement = this.array[i];
                    if (currElement.CompareTo(min) < 0)
                    {
                        min = currElement;

                    }
                }
                return min;
            }

            public void Version()
            {
                Type type = typeof(GenericList<T>);
                var allAttributes = type.GetCustomAttributes(false);
                foreach (var attr in allAttributes)
                {
                    if (attr is VersionAttribute)
                    {
                        VersionAttribute temp = attr as VersionAttribute;
                        Console.WriteLine("GenericList Version {0}.{1}", temp.MajorVersion, temp.MinorVersion);
                    }
                }
            }
            public override string ToString()
            {
                var resultElements = this.array.Take(this.index);

                return string.Join(", ", resultElements);
            }
        }
    }
}

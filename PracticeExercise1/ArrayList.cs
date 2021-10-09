using System;
namespace PracticeExercise1
{
    public class ArrayList: IList
    {
        private int[] array = null;
        private int count = 0;

        public ArrayList()
        {
            array = new int[16];
        }

        public int Length => count;

        public bool IsEmpty => count == 0;

        public int First
        {
            get
            {
                if (IsEmpty)
                {
                throw new NullReferenceException();
                }
                    return array[0];
            }
        }

        public int Last
        {
            get
            {
                if (IsEmpty)
                {
                    throw new NullReferenceException();
                }
                return array[count-1];
            }
        }

        public void Append(int i)
        {
            if (count == array.Length)
            {
                Resize();
            }

            array[count++] = i;
        }

        private void Resize()
        {
            Array.Resize(ref array, array.Length * 2);
        }

        public void InsertAfter(int newValue, int existingValue)
        {
            if (count == array.Length)
            {
                Resize();
            }

            int indexOfExistingValue = FirstIndexOf(existingValue);

            if( indexOfExistingValue == -1)
            {
                Append(newValue);
            }
            else
            {
                // shift everything from that index to the right
                ShiftRight(indexOfExistingValue+1);

                // add new value at that index
                array[indexOfExistingValue+1] = newValue;
                count++;
            }

        }

        public int FirstIndexOf(int existingValue)
        {
            // find index of existing value
            for (int i = 0; i < count; i++)
            {
                if (array[i] == existingValue)
                {
                    return i;
                }
            }

            return -1;
        }

        public void Prepend(int i)
        {
            if (count == array.Length)
            {
                Resize();
            }

            ShiftRight(0);
            array[0] = i;
            count++;

        }

        private void ShiftRight(int startingIndex)
        {
            if (count == array.Length)
            {
                Resize();
            }

            for (int i=count; i>startingIndex; i--)
            {
                array[i] = array[i - 1];
            }
        }

        // TODO
        private void ShiftLeft(int startingIndex)
        {
            if (count == array.Length)
            {
                Resize();
            }

            for (int i = startingIndex; i < count+1; i++)
            {
                array[i] = array[i + 1];
            }
        }

        public override string ToString()
        {
            if (count == 0)
            {
                return "[]";
            }
            string result = "[";
            for (int i = 0; i < count - 1; i++)
            {
                result += array[i] + ", ";
            }

            result += array[count - 1] + "]";
            return result;


            //return "[" + string.Join(", ", array) + "]";

        }

        public void InsertAt(int newValue, int index)
        {

            if (count == array.Length)
            {
                Resize();
            }

            if (index == array.Length)
            {
                Append(newValue);
            }
            if (index <0 || index > array.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                // shift everything from that index to the right
                ShiftRight(index);

                // add new value at that index
                array[index] = newValue;
                count++;
            }

        }

        public void Remove(int value)
        {
            int indexOfValueToRemove = FirstIndexOf(value);

            if (indexOfValueToRemove == -1)
            {
                return;
            }
            else
            {
                ShiftLeft(indexOfValueToRemove);
                count--;
                return;
            }
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index > count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            Remove(array[index]);
        }

        public void Clear()
        {
            count = 0;
        }

        public IList Reverse()
        {
            var reversedList = new ArrayList();

            for (int i = 0; i < count; i++)
            {
                reversedList.Prepend(array[i]);
            }

            return reversedList;
        }
    }
}

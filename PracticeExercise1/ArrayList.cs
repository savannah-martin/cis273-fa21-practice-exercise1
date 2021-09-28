using System;
namespace PracticeExercise1
{
    public class ArrayList : IList
    {
        private int[] array = null;
        //count is how many of the array spots are in use
        private int count = 0;

        public ArrayList()
        {
            array = new int[16];

        }

        public int Length => count;

        public bool IsEmpty => count == 0;

        public int First => throw new NotImplementedException();

        public int Last => throw new NotImplementedException();

        public void Append(int i)
        {
            if (count == array.Length)
            {
                Resize();
            }

            array[count++] = i;
            //count++;
        }

        private void Resize()
        {
            //double length of array
            Array.Resize(ref array, array.Length * 2);
        }

        public void InsertAfter(int newValue, int existingValue)
        {
            if (count == array.Length)
            {
                Resize();
            }

            int indexOfExistingValue = FirstIndexOf(existingValue);

            if (indexOfExistingValue == -1)
            {
                Append(newValue);
            }
            else
            {
                //shift everything from that index to the right
                ShiftRight(indexOfExistingValue);

                //add new value at that index
                array[indexOfExistingValue] = newValue;
                count++;
            }
        }

        public int FirstIndexOf(int existingValue)
        {
            //find index of existing value
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
        }

        private void ShiftRight(int startingIndex)
        {
            for (int i = count; i > startingIndex; i--)
            {
                array[i] = array[i - 1];
            }
        }

        //TODO
        private void ShiftLeft(int startingIndex)
        {
        
        }

        public override string ToString()
        {
            string result = "[";
           for (int i=0; i<count -1; i++)
            {
                result += array[i] + ", ";
            }

            result += array[count - 1] + "]";
            return result;

            //return "[" + String.Join(", ", array) + "]";
        }

        public void Clear()
        {
            count = 0;
        }

        public IList Reverse()
        {
            var reversedList = new ArrayList();

            return reversedList;
        }

        public void InsertAfter(int i)
        {
            throw new NotImplementedException();
        }

        public void InsertAt(int newValue, int index)
        {
            throw new NotImplementedException();
        }

        public void Remove(int value)
        {
            //do not remove from empty list
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }
    }
}

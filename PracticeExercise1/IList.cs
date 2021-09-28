using System;
namespace PracticeExercise1
{
    public interface IList
    {
        int Length { get; }
        bool IsEmpty { get; }
        //TODO
        int First { get; }
        //TODO
        int Last { get; }


        //Add i to the end of the list
        void Append(int i);

        //Add i to the beginning of the list
        void Prepend(int i);

        //Insert new value after first instance of existing value
        //If existing value isn't found, then append to list
        void InsertAfter(int i);
        
        //TODO
        void InsertAt(int newValue, int index);
        int FirstIndexOf(int existingValue);
        
        //TODO
        void Remove(int value);
        
        //TODO
        void RemoveAt(int index);

        //TODO
        void Clear();

        //TODO
        IList Reverse();
    }
}

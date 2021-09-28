using System;
namespace PracticeExercise1
{
    public interface IList
    {
        //Add i to the end of the list
        void Append(int i);

        //Add i to the beginning of the list
        void Prepend(int i);

        //Add i to the end of the list
        void InsertAfter(int i);
        int Length { get; }
        bool IsEmpty { get; }
        public int FirstIndexOf(int existingValue)

    }
}

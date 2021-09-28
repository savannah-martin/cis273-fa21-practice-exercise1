using System;
namespace PracticeExercise1
{
    public interface IList
    {
        //Add i to end of list
        void Append(int i);
        //Add i to beginning of list
        void Prepend(int i);
        void InsertAfter(int i);
    }
}

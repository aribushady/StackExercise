using System;
using System.Collections.Generic;

namespace StackExercise
{
    class MyStack
    {
        private readonly List<object> _list = new List<object>();
        
        public MyStack()
        {

        }

        //Push method to add each object element to the end of the list
        public void Push(object e)
        {
            if(e == null) 
            {
                throw new InvalidOperationException("Null elements cannot be added to list");
            }

            _list.Insert(0, e); //Inserts each element to the first index, pushing each element back one. 

        }

        //Pop method pops elements off LIFO
        public object Pop()
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is Empty");
            }
            
            object popped = _list.IndexOf(0); //popped object holds the element of the first index
                      
            _list.Remove(popped); //Removes the popped object           

            return popped;       
        }

        public void Clear() 
        {
            _list.Clear();           
        }

        public object Peek() //Peek method to look at the top list element
        {   
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }
            
            return _list.IndexOf(0); //Return first element of list
        }

        public void Print() //Print method displays the list elements
        {
            if(IsEmpty())
            {
                throw new InvalidOperationException("Stack is empty");
            }            

           foreach(var e in _list )
           {
                Console.WriteLine(e);
           }
        }

        private bool IsEmpty() //Bool method to determint if list is empty
        {
            if (_list.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

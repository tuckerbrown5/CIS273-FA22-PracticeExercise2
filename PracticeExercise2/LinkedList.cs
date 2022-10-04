using System;
namespace PracticeExercise2
{

    public class LinkedListNode<T>
    {
        public T Data { get; set; }
        public LinkedListNode<T> Next { get; set; }

        public LinkedListNode(T data = default(T), LinkedListNode<T> next=null)
        {
            Data = data;
            Next = next;
        }

        public override string ToString()
        {
            return Data.ToString();
        }

    }

	public class LinkedList<T>: IList<T>
	{
        public LinkedListNode<T> Head { get; set; }
        public LinkedListNode<T> Tail { get; set; }

		public LinkedList()
		{
            Head = null;
            Tail = null;
		}

        public T? First => throw new NotImplementedException();

        public T? Last => throw new NotImplementedException();

        public bool IsEmpty => throw new NotImplementedException();

        public int Length => throw new NotImplementedException();

        public void Append(T value)
        {

            var newNode = new LinkedListNode<T>(value);

            if (IsEmpty)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }


        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        public int FirstIndexOf(T value)
        {
            int index = 0;

            var currentNode = Head;

            while(currentNode!=null)
            {
                if( currentNode.Data.Equals(value) )
                {
                    return index;
                }
                index++;
                currentNode = currentNode.Next;

            }

            return -1;
        }

        public T Get(int index)
        {
            throw new NotImplementedException();
        }

        public void InsertAfter(T newValue, int existingValue)
        {
            throw new NotImplementedException();
        }

        public void InsertAt(T value, int index)
        {
            throw new NotImplementedException();
        }

        public void Prepend(T value)
        {
            throw new NotImplementedException();
        }

        public void Remove(T value)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        public IList<T> Reverse()
        {
            throw new NotImplementedException();
        }
    }
}


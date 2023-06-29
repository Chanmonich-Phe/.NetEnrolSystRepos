using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrolmentSystemPHE
{
	public class DoublyLinkedListNode<T>
	{
		// Represents a node in the doubly linked list
		public DoublyLinkedListNode(T value)
		{
			Value = value;
		}

		public T Value { get; set; } // Value stored in the node

		public DoublyLinkedListNode<T> Next { get; set; } // Reference to the next node


		public DoublyLinkedListNode<T> Previous { get; set; } // Reference to the next node
	}

	public class DoublyLinkedList<T> : System.Collections.Generic.ICollection<T>
    {
		public DoublyLinkedListNode<T> Head // Reference to the next node

		{
			get;
			private set;
		}

		public DoublyLinkedListNode<T> Tail // Reference to the last node
		{
			get;
			private set;
		}


		// Inserts a new node with the specified value at the beginning of the doubly linked list
		public void InsertAtHead(T value)
		{
			InsertAtHead(new DoublyLinkedListNode<T>(value));
		}

		// Inserts the given node at the beginning of the doubly linked list
		public void InsertAtHead(DoublyLinkedListNode<T> node)
		{
			DoublyLinkedListNode<T> temp = Head;

			Head = node;

			Head.Next = temp;

			if (Count == 0)
			{
				Tail = Head;
			}
			else
			{
				temp.Previous = Head;
			}

			Count++;
		}

		// Inserts a new node with the specified value at the end of the doubly linked list
		public void InsertAtTail(T value)
		{
			InsertAtTail(new DoublyLinkedListNode<T>(value));
		}

		// Inserts the given node at the end of the doubly linked list
		public void InsertAtTail(DoublyLinkedListNode<T> node)
		{
			if (Count == 0)
			{
				Head = node;
			}
			else
			{
				Tail.Next = node;

				node.Previous = Tail;
			}
			Tail = node;
			Count++;
		}

		// Removes the first node from the doubly linked list
		public void RemoveHead()
		{
			if (Count != 0)
			{
				Head = Head.Next;
				Count--;

				if (Count == 0)
				{
					Tail = null;
				}
				else
				{
					Head.Previous = null;
				}
			}
		}

		// Removes the last node from the doubly linked list
		public void RemoveTail()
		{
			if (Count != 0)
			{
				Head = null;
				Tail = null;
			}
			else
			{
				Tail.Previous.Next = null;
				Tail = Tail.Previous;
			}
			Count--;
		}

		// Number of elements in the doubly linked list
		public int Count
		{
			get;
			private set;
		}

		// Adds a new node with the specified item at the beginning of the doubly linked list
		public void Add(T item)
		{
			InsertAtHead(item);
		}

		// Checks if the doubly linked list contains the specified item
		public bool Contains(T item)
		{
			DoublyLinkedListNode<T> current = Head;
			while (current != null)
			{
				if (current.Value.Equals(item))
				{
					return true;
				}

				current = current.Next;
			}

			return false;
		}

		// Copies the elements of the doubly linked list to an array, starting from the specified index
		public void CopyTo(T[] array, int arrayIndex)
		{
			DoublyLinkedListNode<T> current = Head;
			while (current != null)
			{
				array[arrayIndex++] = current.Value;
				current = current.Next;
			}
		}

		// Indicates whether the doubly linked list is read-only
		public bool IsReadOnly
		{
			get { return false; }
		}

		// Removes the first occurrence of the specified item from the doubly linked list
		public bool Remove(T item)
		{
			DoublyLinkedListNode<T> previous = null;
			DoublyLinkedListNode<T> current = Head;

			while (current != null)
			{
				if (current.Value.Equals(item))
				{
					if (previous != null)
					{
						previous.Next = current.Next;

						if (current.Next == null)
						{
							Tail = previous;
						}
						else
						{
							current.Next.Previous = previous;
						}

						Count--;
					}
					else
					{
						RemoveHead();
					}

					return true;
				}

				previous = current;
				current = current.Next;
			}

			return false;
		}

		// Returns an enumerator that iterates through the doubly linked list
		System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator()
		{

			DoublyLinkedListNode<T> current = Head;
			while (current != null)
			{
				yield return current.Value;
				current = current.Next;
			}
		}

		System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			return ((System.Collections.Generic.IEnumerable<T>)this).GetEnumerator();
		}

		// Removes all nodes from the doubly linked list
		public void Clear()
		{
			Head = null;
			Tail = null;
			Count = 0;
		}

		// Returns the hash code for the doubly linked list
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}
	}
}


using System;
using System.IO;

namespace CodingInterview
{
    class Program
    {
        static void Main(string[] args)
        {
			LinkedList<int> LL = new LinkedList<int>();
			Console.WriteLine(LL.ToString());
			LL.Add(5);
			Console.WriteLine(LL.ToString());
			LL.Add(4);
			Console.WriteLine(LL.ToString());
			LL.Reverse();
			Console.WriteLine(LL.ToString());
		}
    }
}
			
public class LinkedList<T>
{

	private Node head;

	public LinkedList()
	{
		this.head = null;
	}

	public void Add(T value) {
		this.head = new Node(value, this.head);
	}

	public void Reverse() {
		Node curr = this.head;
        Node prev = null;
		while (curr != null) {
            Node next = curr.getNext();
            curr.setNext(prev);
			prev = curr;
			curr = next;
		}
		this.head = prev;
	}

	public override String ToString() {
		return this.head == null ? "[NULL]" : this.head.ToString();
	}

	class Node
	{
		T value;
		private Node next;

		public Node(T value, Node next)
		{
			this.value = value;
			this.next = next;
		}

		public Node getNext() {
			return next;
		}

		public void setNext(Node next) {
			this.next = next;
		}

        public override string ToString()
        {
			return String.Format("[{0}] -> {1}", this.value, this.next == null ? "[NULL]" : this.next.ToString());
        }
    }
}

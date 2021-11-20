using System;
using DataStructures;

namespace DataStructures
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; set; }

        public Employee(string firstName, string lastName, int id)
        {
            firstName = FirstName;
            lastName = LastName;
            ID = id;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName + " " + ID;
        }

    }
    public class EmployeeNode
    {
        private Employee employee;
        private EmployeeNode next;
		private EmployeeNode previous;

        public EmployeeNode(Employee employee)
        {
            this.employee = employee;
        }

        public Employee GetEmployee()
        {
            return employee;
        }

        public void SetEmployee(Employee employee)
        {
            this.employee = employee;
        }

        public EmployeeNode GetNext()
        {
            return next;
        }

        public void SetNext(EmployeeNode next)
        {
            this.next = next;
        }

		public EmployeeNode GetPrevious()
		{
			return previous;
		}

		public void SetPrevious(EmployeeNode previous)
		{
            this.previous = previous;
        }

        public string ToStringEmployee()
        {
            return employee.ToString();
        }
    }
    public class EmployeeLinkedList
    {
        private EmployeeNode head;
        private int size;

        public void AddToFront(Employee employee)
        {
            var node = new EmployeeNode(employee);
            node.SetNext(head);
            head = node;
            size++;
        }

		public EmployeeNode RemoveFromFront()
		{
			if(IsEmpty())
				return null;

            var removeNode = head;
			head = head.GetNext();
            size--;
			removeNode.SetNext(null);
			return removeNode;
        }

        public void PrintList()
        {
            var current = head;
            System.Console.Write("Head ->");
            while (current != null)
            {
                Console.Write(current.ToStringEmployee() + " ->");
                current = current.GetNext();
            }
			System.Console.WriteLine(" Null");
        }

        public int GetSize()
        {
            return size;
        }

		public bool IsEmpty()
		{
			return head == null;
		}
    }

	public class EmployeeDoublyLinkedList
	{
        private EmployeeNode head;
		private EmployeeNode tail;
        private int size;

        public void AddToFront(Employee employee)
        {
            var node = new EmployeeNode(employee);
            node.SetNext(head);
			// If adding to an empty list, set tail to the new node
			if(head == null)
			{
				tail = node;
			}
			else{
                head.SetPrevious(node);
            }
            head = node;
            size++;
        }

		public void AddToEnd(Employee employee)
		{
			var node = new EmployeeNode(employee);
			if(tail == null)
			{
				head = node;
			}
			else
			{
				tail.SetNext(node);
				node.SetPrevious(tail);
			}
			tail = node;
			size++;
		}

        public EmployeeNode RemoveFromFront()
        {
            if (IsEmpty())
                return null;

            var removeNode = head;
			if(head.GetNext() == null)
			{
				tail = null;
			}
			else{
				head.GetNext().SetPrevious(null);
			}
            head = head.GetNext();
            size--;
            removeNode.SetNext(null);
            return removeNode;
        }

		public EmployeeNode RemoveFromEnd()
		{
            if (IsEmpty())
                return null;
			var removeNode = tail;
			if (tail.GetNext() == null)
			{
                head = null;
            }
			else
			{
				tail.GetPrevious().SetNext(null);
			}
			tail = tail.GetPrevious();
            size--;
            removeNode.SetPrevious(null);
            return removeNode;
		}

        public void PrintList()
        {
            var current = head;
            System.Console.Write("Head ->");
            while (current != null)
            {
                Console.Write(current.ToStringEmployee() + " <->");
                current = current.GetNext();
            }
            System.Console.WriteLine(" Null");
        }

        public int GetSize()
        {
            return size;
        }

        public bool IsEmpty()
        {
            return head == null;
        }
	}
}
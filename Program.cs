using System;
using DataStructures;

namespace DataStrutures
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var janeJones = new Employee("Jane", "Jones", 123);
            var johnDoer = new Employee("John", "Doer", 4567);
            var marySmith = new Employee("Mary", "Smith", 22);
            var mikeWilson = new Employee("Mike", "Wilson", 3245);
            var employees = new EmployeeDoublyLinkedList();
            employees.AddToFront(janeJones);
            employees.AddToFront(johnDoer);
            employees.AddToFront(marySmith);
            employees.AddToFront(mikeWilson);
            employees.PrintList();
            System.Console.WriteLine(employees.GetSize());
            var billEnd = new Employee("Bill", "End", 56);
            employees.AddToEnd(billEnd);
            employees.PrintList();
            System.Console.WriteLine(employees.GetSize());
            employees.RemoveFromFront();
            employees.PrintList();
            System.Console.WriteLine(employees.GetSize());
        }
    }
}
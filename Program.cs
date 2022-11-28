using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackUsingSingleLinkList
{
    class node
    {
        public int info;
        public node next;
        public node(int i, node n)
        {
            info = i;
            next = n;
        }
    }
    class Stack
    {
        node top;
        public Stack()
        {
            top = null;
        }
        bool empty()
        {
            if (top == null)
                return (true);
            else
                return (false);
        }

        public void push(int element)
        {
            node fresh;
            fresh = new node(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed");
        }

        public void pop()
        {
            Console.WriteLine("\n The poped element is: " + top.info);
            top = top.next; // make top point to the next is squence
        }

        public void display()
        {
            node tmp;
            if (empty())
                Console.WriteLine("\nStackEmpty");
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }
            }
        }
    }
   class program
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n***Stack Menu***\n");
                Console.WriteLine("1. Push ");
                Console.WriteLine("2. Pop ");
                Console.WriteLine("3. Display ");
                Console.WriteLine("4. Exit ");
                Console.Write("\nEnter your choice: ");
                string Input = Console.ReadLine();
                char ch = Convert.ToChar(Input == "" ? "0" : Input);
                switch (ch)
                {
                    case '1':
                        Console.Write("\nEnter a number :");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\nStack Empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\nInvalid Choice");

                }
            }
        }
    }

       
    }














 

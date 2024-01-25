using System;

namespace LinkListQuestion
{
    public class LinkListExample
    {
        public Node AddTwoNumbers(Node l1, Node l2)
        {
            //This is to store whole node data
            Node headNode = new Node(0);
            //We will be adding our new node result in current node
            Node currentNode = headNode;
            //Store carry value if more than 9 number will be the sum
            int carry = 0;

            //Checking if both  of our node is null or not
            while (l1 != null || l2 != null)
            {
                //Result value of our first node stored
                int firstValue = (l1 != null) ? l1.val : 0;
                //Result value of our second node stored 
                int secondValue = (l2!= null) ? l2.val : 0;

                //Sum reult of first and second value with carry if there is any
                int sum  = firstValue + secondValue + carry;

                //Storing carry for adding it to next executing node.
                carry = sum / 10;
                //CurrentNode Next points to mod value if there is any and add it to second node in our loop
                currentNode.next = new Node(sum % 10);
                //Current node point to next data
                currentNode = currentNode.next;
                //Checking node status and point to next data
                if (l1 != null) l1 = l1.next;
                if(l2 != null) l2 = l2.next;
            }
            // if there is any remaining carry data than it will add to last node
            if(carry > 0)
            {
                currentNode.next = new Node(carry);
            }
            //Returning headNode next because in first we have stored mock data 0 so ignoring it
            return headNode.next ;
        }
    }
    //Single linklist Node Structure
    public class Node
    {
        public int val;
        public Node next;
        public Node(int val = 0, Node next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            //Assigning node value and next point
            Node node1 = new Node(1, new Node(2, new Node(3)));
            Node node2 = new Node(1, new Node(2, new Node(3)));
            LinkListExample example = new LinkListExample();
            //result of sum of two node
            Node result = example.AddTwoNumbers(node1, node2);


            //Printing Data
            Console.WriteLine("Example : ");
            PrintData(node1);
            Console.Write(" + ");
            PrintData(node2);
            PrintData(result);
            Console.WriteLine();

        }
        public static void PrintData(Node node)
        {
            while (node != null)
            {
                Console.Write(node.val);
                node = node.next;
            }
            Console.WriteLine();
        }
    }
}


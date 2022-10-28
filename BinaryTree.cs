using System;

class Node1
{
    public int value;
    public Node1 left;
    public Node1 right;

    public void show()
    {
        Console.Write("[");
        Console.Write(value);
        Console.Write("]");
    }
}

class Tree
{
    public Node1 root;

    public Tree()
    {
        root = null;
    }

    public Node1 ReturnRoot()
    {
        return root;
    }

    public void Insert(int x)
    {
        Node1 newNode = new Node1();
        newNode.value = x;
        if (root == null)
        {
            root = newNode;
        }
        else{
            Node1 current = root;
            Node1 parent;
            while(true)
            {
                parent = current;
                if (x < current.value)
                {
                    current = current.left;
                    if (current == null)
                    {
                        parent.left = newNode;
                        return;
                    }
                }
                else{
                    current = current.right;
                    if (current == null)
                    {
                        parent.right = newNode;
                        return;
                    }
                }   
            }
        }
    }

    public void Pre_order(Node1 Root)
    {
        if (Root != null)
        {
            Console.Write(Root.value + " ");
            Pre_order(Root.left);
            Pre_order(Root.right);
        }
    }

    public void In_order(Node1 Root)
    {
        if (Root != null)
        {
            In_order(Root.left);
            Console.Write(Root.value + " ");
            In_order(Root.right);
        }
    }

    public void Post_order(Node1 Root)
    {
        if (Root != null)
        {
            Post_order(Root.left);
            Post_order(Root.right);
            Console.Write(Root.value + " ");
        }
    }
}
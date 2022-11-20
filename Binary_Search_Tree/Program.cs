namespace Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(56);
            tree.Add(70);
            tree.Add(30);
            tree.Add(40);
            tree.Add(60);
            tree.Add(22);
            tree.Add(95);
            tree.Add(65);
            tree.Add(11);
            tree.Add(3);
            tree.Add(63);
            tree.Add(67);
            tree.Add(16);
            Console.WriteLine(" Elements in Binary Trees ");
            tree.DisplayInorder(tree.Root);
            Console.WriteLine();
            tree.Size();
            int data = 63;
            Node<int> node = tree.Find(data, tree.Root);
            if (node == null)
            {
                Console.WriteLine($"{data} is not present in Binary Tree");
            }
            else
            {
                Console.WriteLine($"{node.Data} is Present in Binaray Tree");
            }

            Console.WriteLine("Elements in Binary Trees");
            tree.DisplayInorder(tree.Root);
            Console.WriteLine();
            tree.Size();
        }
    }
}
namespace Binary_Search_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>(56);
            tree.Add(30);
            tree.Add(70);

            Console.WriteLine("********************** Elements in Binary Trees **********************");
            tree.Display(); 
        }
    }
}
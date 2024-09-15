using BinaryTreeExplanation;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static void Main(string[] args)
    {
        Tree tree = new Tree();

        List<int> binaryTree = new List<int>();


        tree.Insert(7);
        tree.Insert(4);
        tree.Insert(1);
        tree.Insert(6);
        tree.Insert(9);
        tree.Insert(8);
        tree.Insert(10);

        var exists = tree.Find(7);
        Console.WriteLine(exists);
    }
}
// See https://aka.ms/new-console-template for more information
using DataStructureAndAlgorithm;

Console.WriteLine("Hello, World!");
 
    static void Main(string[] args)
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Select Programs\n 1.Binary search");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    BinarySearchWord_UC1 binarysearch = new BinarySearchWord_UC1();
                    binarysearch.Search(@"D:\Bridgelabs\DataStructureAndAlgorithm\DataStructureAndAlgorithm\Word.txt");
                    break;
            }
        }
    }

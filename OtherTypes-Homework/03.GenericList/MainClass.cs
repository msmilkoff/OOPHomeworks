using System;

namespace _03.GenericList
{
    class MainClass
    {
        static void Main()
        {
            GenericList<int> nums = new GenericList<int>();
            nums.Add(5);
            nums.Add(10);
            nums.Add(50);

            Console.WriteLine(nums.Contains(10)); // output: True
            Console.WriteLine(nums[2]);           // output: 50

            nums[2] = 42;                         
            Console.WriteLine(nums[2]);           // output: 42

            Console.WriteLine(nums.IndexOf(42));  // output: 2

            Console.WriteLine(nums.Count);        // output: 3

            Console.WriteLine(nums);              // output: [item1, item2...]

            nums.RemoveAt(0);                     
            Console.WriteLine(nums.Count);        // output: 2

            nums.Clear();                         
            Console.WriteLine(nums.Count);        // output: 0
        }
    }
}

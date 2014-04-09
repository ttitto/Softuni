namespace Task5WeLoveBits
{
    using System;
    using System.Linq;
    class Task5WeLoveBitsClass
    {
        static void Main()
        {
            int numCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < numCount; i++)
            {
                int p = int.Parse(Console.ReadLine());
                char[] myInt = Convert.ToString(p, 2).ToCharArray();
                int result = Convert.ToInt32(string.Join("", myInt.Reverse()), 2);
                Console.WriteLine(result);
            }
        }
    }
}

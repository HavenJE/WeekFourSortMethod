

// Week 4 - Sort() method 

class Program
{
    static void Main(string[] args)
    {
        int[] randomNums = { 50, 15, 11, 40, 7, 215 };
        string[] randomNames = { "Xena", "Cortiney", "George", "Omar" };

        Array.Sort(randomNames);
        for (int i = 0; i < randomNames.Length; i++)
        {
            // Console.WriteLine(randomNums[i]);
            Console.WriteLine(randomNames[i]);
        }
        
    }
}
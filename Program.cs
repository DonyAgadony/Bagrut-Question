using System.Numerics;

class Program
{
    public static void Main()
    {
        int[] ints = [33, 0, 5, 4, 0, 17, 0, 4, 10, 0, 5, 14];
        Console.WriteLine(BiggestSum(ints));
    }
    public static int BiggestSum(int[] ints)
    {
        int biggest = int.MinValue;
        int sum = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            if (ints[i] == 0)
            {
                sum = 0;
                do
                {
                    sum += ints[i];
                    if (i == ints.Length - 1) { return biggest; }
                    else
                    {
                        i++;
                    }

                    if (sum > biggest) { biggest = sum; }
                } while (ints[i] != 0);
                i--;
            }
        }
        return biggest;
    }
}
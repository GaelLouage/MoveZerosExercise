internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(string.Join(" ", MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 })));
    }
    public static int[] MoveZeroesLinq(int[] arr)
    { 
        return arr.OrderBy(x => x == 0).ToArray();
    }

    public static int[] MoveZeroes(int[] arr)
    {
        var nonZeros = new List<int>();
        var zeros = new List<int>();
        for (int i = 0; i < arr.Length; i++) 
        {
            if(arr[i] == 0) 
            {
                zeros.Add(arr[i]);
            }
            else
            {
                nonZeros.Add(arr[i]);
            }
        }
        return nonZeros.Concat(zeros).ToArray();
    }
}

class Program
{
    static void Main()
    {
        int[] Array = {1,-2,3,-4,5,-6};
        ConvertToPositive(ref Array);
        
        foreach (var a in Array)
        {
            Console.WriteLine(a);
        }
    }
    
    static void ConvertToPositive(ref int[] Array)
    {
        int[] PositiveArray = new int[Array.Length];
        
        for (int i = 0; i < Array.Length; i++)
            PositiveArray[i] = Array[i] > 0 ? Array[i] : -Array[i];
    
        Array = PositiveArray;
    }
}

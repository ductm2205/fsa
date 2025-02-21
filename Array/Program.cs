using Array;

internal class Program
{
    private static void Main(string[] args)
    {

        CustomArray<int> customArray = [2, 3];

        customArray.Remove(3);

        foreach (var item in customArray)
        {
            System.Console.WriteLine(item);
        }


    }
}

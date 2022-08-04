class ParameterTest
{
    int temp;
    int b;

    public void Value(int x)
    {
        x = 1;
    }
    public void Swap(ref int n1, ref int n2)
    {
        temp = n1;
        n1 = n2;
        n2 = temp;
    }
    public void MinMax(int[] a, out int min, out int max)
    {

        min = a.Min();
        max = a.Max();
    }
}
class Driver
{
    public static void Main(string[] args)
    {
        int y = 12;
        int z = 4;
        int x = 5;

        ParameterTest b = new ParameterTest();
        b.Value(y);
        b.Swap(ref x, ref z);
        Console.WriteLine($"{x} {z}");
        int min;
        int max;
        ParameterTest c = new ParameterTest();
        int[] a = { 1, 2, 3, 4, 5, 6, -2, -8 };
        c.MinMax(a, out min, out max);
        Console.WriteLine(min);
        Console.WriteLine(max);
    }
}
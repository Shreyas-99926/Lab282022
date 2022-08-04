program p1 = new program();
int[] values;
Console.WriteLine(p1.ComputeSum(22, 32, 55));

class program
{
    int sum = 0;
    public int ComputeSum(params int[] values)
    {
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return sum;
    }
}
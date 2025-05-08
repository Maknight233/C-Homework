namespace ArrayHomework;

public class SumOfPrime
{
    public static int[] prime(int start, int end)
    {
        bool check = true;
        List<int> arr = new List<int>();
        for (int i = start; i <= end; i++)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    check = false;
                    break;
                }
            }

            if (check)
            {
                arr.Add(i);
            }
            else
            {
                check = true;
            }
        }
        return arr.ToArray();
    }
}
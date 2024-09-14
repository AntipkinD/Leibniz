internal class Program
{
    private static void Main(string[] args)
    {
        const double x = 4;
        double xSum;
        double xSumResult = x;
        double divider = 1;
        Console.WriteLine("Введите число повторений");
        int iteras = Convert.ToInt32(Console.ReadLine());
        int i = 1;
        string result = $"{x}";

        //while
        /*while (i <= iteras)
        {
            if (i % 2 == 0)
            {
                xSum = x / (divider += 2);
                result += $"+{xSum}";
            }
            else
            {
                xSum = -1 * x / (divider += 2);
                result += $"{xSum}";
            }
            xSumResult += xSum;
            
            i++;
        }
        Console.WriteLine(result + '=' + xSumResult);*/

        //do...while
        i = 1;
        xSumResult = x;
        do
        {
            if (i % 2 == 0)
            {
                xSum = x / (divider += 2);
                result += $"+{xSum}";
            }
            else
            {
                xSum = -1 * x / (divider += 2);
                result += $"{xSum}";
            }
            xSumResult += xSum;
            i++;
        }
        while (i <= iteras);
        Console.WriteLine(result + '=' + xSumResult);

        //for
        /*xSumResult = x;
        for (int j = 1; j <= iteras; j++)
        {
            if (j % 2 == 0)
            {
                xSum = x / (divider += 2);
                result += $"+{xSum}";
            }
            else
            {
                xSum = -1 * x / (divider += 2);
                result += $"{xSum}";
            }
            xSumResult += xSum;
        }
        Console.WriteLine(result + '=' + xSumResult);*/
    }
}
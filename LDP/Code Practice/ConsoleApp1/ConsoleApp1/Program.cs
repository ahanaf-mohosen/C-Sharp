using System;

class Program
{
    static void Main()
    {
        int[] number1 = new int[3];
        number1[0] = 101;
        number1[1] = 102;
        number1[2] = 103;
        int[] number2 = new int[3];
        number2[0] = 104;
        number2[1] = 105;
        number2[2] = 106;
        //paramArray(number);
        Program.paramArray(number1,number2);
        Console.ReadLine();
    }
    public static void paramArray(int[] number1,params int[] Numbers)
    {
        foreach (int i in Numbers)
        {
            foreach (int j in number1)
            {
                Console.WriteLine(j);
            }
            Console.WriteLine(i);
        }
        foreach (int j in number1)
        {
            Console.WriteLine(j);
        }
    }
}
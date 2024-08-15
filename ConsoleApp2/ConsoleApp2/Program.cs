using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();


        bool isDangerous = IsDangerous(input);
        if (isDangerous == true)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }

        static bool IsDangerous(string s)
        {
            int maxLength = 7;
            int count = 1;

            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == s[i - 1])
                {
                    count++;
                    if (count >= maxLength)
                    {
                        return true;
                    }
                }
                else
                {
                    count = 1;
                }
            }

            return false;
        }
    }
}


using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] nums = new int[4] { 1, 2, 4, 8 };
        int target = 12;
        var res = Twosum(nums, target);
        Console.WriteLine(res);

        var pal = IsPalindrome(121);
        Console.WriteLine(pal);

        var rom = RomanToInt("XI");
        Console.WriteLine(rom);

        Console.ReadLine();
    }

    // Two sum problem
    public static int[] Twosum(int[] nums, int target)
    {
        Dictionary<int, int> check = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (check.ContainsKey(target - nums[i]))
            {
                return new int[] { check[target - nums[i]], i };
            }

            if (!check.ContainsKey(nums[i]))
            {
                check.Add(nums[i], i);
            }
        }

        return null;
    }

    public static bool IsPalindrome(int x)
    {
        int reverse = 0;
        int original = x;
        
        while (x > 0)
        {
            int remainder = x % 10;
            reverse = (reverse * 10) + remainder;
            x = x / 10;
        }

        if (reverse == original)
        {
            return true;
        }
        return false;
    }


    public static int RomanToInt(string s)
    {
        int num = 0;
        Dictionary<string,int> dict = new Dictionary<string, int>()
        {
            { "I",1}, {"V",5}, {"X", 10}, {"L", 50}, {"C", 100}, {"D",500}, {"M",1000}
        };

        s = s.Replace("IV", "IIII").Replace("IX", "VIIII").Replace("XL", "XXXX")
            .Replace("XC", "LXXXX").Replace("CD", "CCCC").Replace("CM", "DCCCC");

        foreach (var ch in s)
        {
            num += dict[ch.ToString()];
        }

        return num;
    }

}
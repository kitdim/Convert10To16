using static System.Console;

class Program
{
    private static void Main()
    {
        Write("Enter number : ");
        bool isConvert = int.TryParse(ReadLine(), out int num10);

        if (isConvert)
        {
            WriteLine("A number in the hexadecimal number system: " + Convert10To16(num10));
        }
        else
        {
            throw new("The input is not a number.");
        }
    }
    private static string Convert10To16(int num10)
    {
        if (num10 == 0)
        {
            return "0";
        }
        Dictionary<int, string> nums = new()
        {
            {10, "A"},
            {11, "B"},
            {12, "C"},
            {13, "D"},
            {14, "E"},
            {15, "F"}
        };
        string? answer = default;
        while (num10 > 0)
        {
            int num16 = num10 % 16;
            num10 /= 16;

            if (nums.ContainsKey(num16))
            {
                answer += nums[num16];
            }
            else
            {
                answer += $"{num16}";
            }
        }
        char[] chars = answer.ToCharArray();

        for (int i = 0; i < answer.Length / 2; i++)
        {
            char ch = chars[i];
            chars[i] = chars[answer.Length - i - 1];
            chars[answer.Length - i - 1] = ch;
        }
        answer = new string(chars);
        return answer;
    }
}
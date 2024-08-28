namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }

        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            // if the int variable is divisible by 2, return two, else return false.
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            // If one of the first two variables are bigger than the third, return the bigger number out of the two.
            if (Math.Max(a, b) > c)
            {
                return Math.Max(a, b);
            }
            // else return the third number.
            else
            {
                return c;
            }
        }

        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            int characters = 0;

            // for each letter in string s, add to the variable characters and return that number.
            foreach (char c in s)
            {
                characters++;
            }
            return characters;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            return s.StartsWith("Hello");
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            // Multiply the variable total by each number up to n and return that number.
            int total = 1;
            for (int i = 1; i <= n; i++)
            {
                total *= i;
            }
            return total;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            // Return false if the given number is divisible by any numbers leading up to it, if not return true.
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            // base case: n is less than or equal to 1.
            if (n <= 1) return n;
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            // Loop through the array to find the largest number.
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > largest) largest = numbers[i];
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            if (s == ReverseString(s)) return true;
            return false;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            foreach (int i in numbers) sum += i;
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            // for every char in the string, check if the char c is within it, and if so increment count.
            foreach (char character in s) {
                if (character == c) count++;
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            return $"{str1} {str2}";
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {
            if (s.Length <= 1) return s;
            
            // Store data within two char variables, create a char array to switch the first and last char around, and return it as a string.
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            char[] sArray = s.ToArray();
            sArray[0] = lastChar;
            sArray[sArray.Length - 1] = firstChar;
            
            return new string(sArray);
        }
    }
}

using System;

namespace RandomTraining
{
    class Program
    {
        static void Main()
        {
            //Expression lambdas
            //LINQ 1
            Func<int, int> square = x => x * x;
            Console.WriteLine(square(5));
            Console.WriteLine("----------------------------------------------------");
            // Output:
            // 25

            //LINQ 2
            Action action = () => Console.WriteLine("hello world");
            action.Invoke();
            Console.WriteLine("----------------------------------------------------");
            // Output:
            // hello world

            //LINQ 3
            Func<int, int, bool> testForEquality = (x, y) => x == y;
            Console.WriteLine(testForEquality(5, 5));
            Console.WriteLine("----------------------------------------------------");
            // Output:
            // True

            //LINQ 4
            Func<int, string, bool> isTooLong = (int x, string s) => s.Length > x;
            Console.WriteLine(isTooLong(5, "hello world"));
            Console.WriteLine("----------------------------------------------------");
            // Output:
            // True

            //Statement lambdas
            //LINQ 1
            Action<string> greet = name =>
            {
                string greeting = $"Hello {name}!";
                Console.WriteLine(greeting);
            };
            greet("World");
            Console.WriteLine("----------------------------------------------------");
            // Output:
            // Hello World!

            //Lambda expressions and tuples
            //LINQ 2
            //IN                    //OUT
            Func<(int, int, int), (int, int, int)> doubleThem = ns => (2 * ns.Item1, 2 * ns.Item2, 2 * ns.Item3);
            var numbers = (2, 3, 4);
            var doubledNumbers = doubleThem(numbers);
            Console.WriteLine($"The set of integers {numbers} doubled: {doubledNumbers}");
            Console.WriteLine("----------------------------------------------------");
            // Output:
            // The set (2, 3, 4) doubled: (4, 6, 8)

            //LINQ 2-Example2
            //IN                    //OUT
            Func<(int, int, int), (double, double, double)> doubleThem2 = ns => (Convert.ToDouble(1.5 * ns.Item1), Convert.ToDouble(1.5 * ns.Item2), Convert.ToDouble(1.5 * ns.Item3));
            var numbers2 = (2, 3, 4);
            var doubledNumbersToDouble = doubleThem2(numbers2);
            Console.WriteLine($"The set of integers {numbers} converted to double and then doubled: {doubledNumbersToDouble}");
            Console.WriteLine("----------------------------------------------------");
            // Output:
            // The set (2, 3, 4) doubled: (4, 6, 8)

            //LINQ 2-Example2
            //IN                            //OUT
            Func<(string, string, string), (int, int, int)> parseToInt = ns => (Int32.Parse(ns.Item1), Int32.Parse(ns.Item2), Int32.Parse(ns.Item3));
            var strings = ("2", "3", "4");
            var parsedStrings = parseToInt(strings);
            Console.WriteLine($"The set of strings {strings} parsed into integers: {parsedStrings}");
            Console.WriteLine("----------------------------------------------------");
            // Output:
            // The set (2, 3, 4) parsed: (2, 3, 4)

            Console.ReadKey(true);
        }
    }
}

using System.Linq;
using System.Text.RegularExpressions;
using Core.Tools;

namespace Core.MathHomework
{
    public enum MathPrecedence
    {
        Order,
        Addition,
        Multiplication
    }

    public class HomeworkCalculator
    {
        private const string Addition = "+";
        private const string Multiplication = "*";
        private const char GroupStart = '(';
        private const char GroupEnd = ')';

        public long SumOfAll(string input, MathPrecedence precedence)
        {
            var rows = PuzzleInputReader.ReadLines(input);
            return rows.Sum(o => Sum(o, precedence));
        }

        public long Sum(string input, MathPrecedence precedence)
        {
            var rootGroup = new Group(input, precedence);
            var result = rootGroup.Result;
            return result;
        }

        private class Group
        {
            public long Result { get; }

            public Group(string s, MathPrecedence precedence)
            {
                var regex = new Regex(@"\([0-9 \*\+]+\)");
                while (s.Contains('('))
                {
                    var matches = regex.Matches(s);
                    foreach (Match match in matches)
                    {
                        var hit = match.ToString();
                        var result = Calc(hit.TrimStart(GroupStart).TrimEnd(GroupEnd));
                        s = s.Replace(hit, result.ToString());
                    }
                }
                
                Result = Calc(s);
            }

            private long Calc(string s)
            {
                var parts = s.Split(' ').ToList();
                while (parts.Count > 1)
                {
                    var current = long.Parse(parts[0]);
                    var next = long.Parse(parts[2]);
                    var operation = parts[1];
                    var result = operation == Multiplication
                        ? current * next
                        : current + next;

                    parts[0] = result.ToString();
                    parts.RemoveAt(1);
                    parts.RemoveAt(1);
                }

                return long.Parse(parts[0]);
            }
        }
    }
}
using Pzl.Common;
using Pzl.Tools.CoordinateSystems.CoordinateSystem2D;
using Pzl.Tools.Strings;

namespace Pzl.Everybody.Puzzles.Everybody15;

// Thanks to Jonathan Paulson
[IsSlow]
[Comment("Complex path finding")]
[Name("From the Herbalist's Diary")]
public class Everybody15 : EverybodyPuzzle
{
    private readonly (int r, int c)[] _diffs = [(-1, 0), (1, 0), (0, 1), (0, -1)];
    
    public PuzzleResult Part1(string input)
    {
        var cost = Run(input);
        return new PuzzleResult(cost, "4d832f8cc35ae0da374a91187caa538b");
    }

    public PuzzleResult Part2(string input)
    {
        var result = Run(input);
        return new PuzzleResult(result, "88139015cfdd3b0563287eff1d2229c1");
    }
    
    public PuzzleResult Part3(string input)
    {
        var result = Run(input);
        return new PuzzleResult(result, "3a179922baba26e752177ed54092cfdc");
    }

    private long Run(string input)
    {
        var grid = input.Split(LineBreaks.Single);
        var height = grid.Length;
        var width = grid[0].Length;
        var start = new MatrixAddress(input.Split(LineBreaks.Single).First().IndexOf('.'), 0);
        var herbs = GetHerbs(grid);
        var herbToIndex = new Dictionary<char, int>();

        var allFound = 0L;
        var index = 0;
        foreach (var type in herbs)
        {
            herbToIndex[type] = index;
            allFound |= (uint)(1 << index);
            index++;
        }

        var q = new Queue<(long, int, int, long)>();
        q.Enqueue((0, start.Y, start.X, 0));
        var seen = new bool[width * height * (allFound + 1)];

        while (q.Count > 0)
        {
            var (d, r, c, found) = q.Dequeue();
            var key = found * height * width + r * width + c;
            if (seen[key])
                continue;

            seen[key] = true;

            if (r == start.Y && c == start.X && found == allFound)
                return d;
            
            foreach (var (dr, dc) in _diffs)
            {
                var rr = r + dr;
                var cc = c + dc;
                var v = grid[r][c];

                if (rr < 0 || rr >= height || cc < 0 || cc >= width || v is '#' or '~')
                    continue;
                
                var newFound = v != '.'
                    ? found | (uint)(1 << herbToIndex[v])
                    : found;

                q.Enqueue((d + 1, rr, cc, newFound));
            }
        }

        throw new Exception("No result");
    }

    private static HashSet<char> GetHerbs(string[] grid)
    {
        var herbs = new HashSet<char>();
        for (var r = 0; r < grid.Length; r++)
        {
            for (var c = 0; c < grid[r].Length; c++)
            {
                if (grid[r][c] is '#' or '.' or '~')
                    continue;

                herbs.Add(grid[r][c]);
            }
        }

        return herbs;
    }
}
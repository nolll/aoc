using Pzl.Common;

namespace Pzl.Everybody;

public class EverybodyPuzzleProvider : IPuzzleProvider
{
    public List<PuzzleDefinition> GetPuzzles() =>
        PuzzleDataReader.ReadData<EverybodyPuzzle>()
            .Select(CreatePuzzleDefinition)
            .ToList();

    private static PuzzleDefinition CreatePuzzleDefinition(PuzzleData data)
    {
        var (year, day) = EverybodyPuzzleParser.GetYearAndDay(data.Type);
        var paddedDay = day.ToString().PadLeft(2, '0');
        var id = $"{year}{paddedDay}";
        var sortId = $"aoc {id}";
        var title = $"Advent of Code {year}-{paddedDay}";
        var listTitle = $"Aoc {year}-{paddedDay}";
        List<string> tags = ["aoc", year.ToString(), day.ToString()];

        return new PuzzleDefinition(data, tags, sortId, title, listTitle);
    }
}
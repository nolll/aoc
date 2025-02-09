using Pzl.Tools.Combinatorics;
using Pzl.Tools.Strings;

namespace Pzl.Aoc.Puzzles.Aoc2015.Aoc201513;

public class DinnerTable
{
    private const string Me = "Me";
    
    public int HappinessChange { get; }

    public DinnerTable(string input, bool includeMe = false)
    {
        var guests = ParseGuests(input, includeMe);
        var names = guests.Keys;
        var nameLists = PermutationGenerator.GetPermutations(names.ToList());
        var happiness = nameLists.Select(nl => CalculateHappiness(nl.Select(p => guests[p]).ToList()));
            
        HappinessChange = happiness.Max();
    }

    private int CalculateHappiness(IList<DinnerGuest> guests)
    {
        var happiness = 0;
        for (var i = 0; i < guests.Count; i++)
        {
            var guest = guests[i];
            var nextGuestIndex = i + 1 >= guests.Count ? 0 : i + 1;
            var prevGuestIndex = i - 1 < 0 ? guests.Count - 1 : i - 1;
            var nextGuest = guests[nextGuestIndex];
            var prevGuest = guests[prevGuestIndex];
            var nextGuestHappiness = guest.GetHappiness(nextGuest.Name);
            var prevGuestHappiness = guest.GetHappiness(prevGuest.Name);
            happiness += nextGuestHappiness + prevGuestHappiness;
        }
        return happiness;
    }

    private static IDictionary<string, DinnerGuest> ParseGuests(string input, bool includeMe)
    {
        var rules = StringReader.ReadLines(input);
        var guests = new Dictionary<string, DinnerGuest>();

        if (includeMe) 
            guests.Add(Me, new DinnerGuest(Me));

        foreach (var r in rules)
        {
            var parts = r.TrimEnd('.').Split(' ');
            var name = parts[0];
            var sign = parts[2] == "lose" ? -1 : 1;
            var happiness = sign * int.Parse(parts[3]);
            var otherName = parts[10];
            var rule = new DinnerGuestRule(otherName, happiness);
            if (!guests.TryGetValue(name, out var guest))
            {
                guest = new DinnerGuest(name);
                guests.Add(name, guest);
            }

            guest.AddRule(rule);
        }

        return guests;
    }
}
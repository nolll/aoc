﻿using App.Platform;

namespace App.Puzzles.Year2019.Day18;

public class Year2019Day18 : Puzzle
{
    public override string Comment => "Key Collector";
    public override bool IsSlow => true;

    public override PuzzleResult RunPart1()
    {
        var keyCollector1 = new KeyCollector(FileInput);
        keyCollector1.Run();

        return new PuzzleResult(keyCollector1.ShortestPath, 4420);
    }

    public override PuzzleResult RunPart2()
    {
        var keyCollector2 = new KeyCollector(GeneratedMapFromStep1);
        keyCollector2.Run();

        return new PuzzleResult(keyCollector2.ShortestPath, 2128);
    }

    private const string GeneratedMapFromStep1 = @"
#################################################################################
#...#z..#.....#...#...#.........#...#...#.............................#...#.....#
#.#.#.#.#.#.#.#.#.#.#.#####.###.###.#.#.#####.#######################H#.#.###.#.#
#.#.#.#...#.#...#...#.....#.#.#...#f..#.#...#.#.......#...#.........#...#.....#.#
#.#.#.#####.#############.#.#.###.###.#.#.#.#.#.#####.#.#.###.#####.###########.#
#.#...#...#.#.........#.....#...#...#.#.#.#...#.....#...#...#.#...#...#...#.....#
#.#####.#.#.#.#######.#######.#####.#.#.#.###.#####.#######I#.#.#.#####X#.#.#####
#.#...#.#.#...#.....#...#...#.....#.#.#.#...#...#.#.#.....#.#.#.#.......#.#.#...#
#.#.#.###.#######.#.###.###.#.#.###.#.#.#.#.###.#.#.#.###.#.#.#.#########.#.#.#.#
#.#.#...#.#.......#...#.#...#.#...#.#.#.#.#.#...#w#b..#.#.#.#.....#...#...#.#.#.#
#.#.###.#.#.#.#######.#.#.###.###.#.###.###.#.###.#####.#.#.###.###Y#.#.#.#.#.###
#.#.#...#...#...#.....#.#.#...#.#...#...#...#.......#.....#...#.#...#.#.#.#.#...#
#.#.#.#########.#.#####.#.#.###.#####.#.#.###########.#####.#.#.#.###.#.###.###.#
#.#.#...#.......#.#.....#.....#.......#.#............j#...#.#.#.#...#.#.....#s..#
#.#.###.#.###.#####.#.#######.#####.###.###############.#.###.###.###.#.#####.#G#
#.C.#.#...#...#.....#.#.....#.....#...#.#.............#.#.....#...#...#.#.....#.#
#####.#####.###.#######.###.#####.###.#.#.###.#####.###.#.#####.###.###.#.#####.#
#...#...#...#...#.....#.#.#.#.......#.#.#.#.#.#.....#...#.#.....#.#...#...#...#.#
#.#.###.#.###.#.#.###.#.#.#.#######.#.#.#.#.#.#.#####.#####.#####.###.#######.#.#
#.#...#...#.#.#.#...#...#.#.#.....#...#.#.#.#.#.#.....#...........T.#.#...U.#.#.#
#.###.#.###.#.#.#.#####.#.#.#.###.#####.#.#.#.###.#.###.#############.#.###.#.#.#
#...#.#.....#.#.#.#...#...#.....#.....#.#...#.#...#.#...#.P...#.E...#...#...#...#
#.#.#.#####.#.###.#.###############.#.###.###.#.###.#.###.#####.###.#####.###.###
#.#.#.....#.#.#...#...............#.#...#.#...#...#.#.#.#...#...#.#.#.N.#...#...#
#.#.#####.###.#.#################.#.###.###.#.###R#.#.#.###.###.#.#.#.#.###.###.#
#.#.....#.#...#...#.........#...#.#...#.#...#.#...#.#.#...#p#...#.#e#.#.....#...#
#.#####.#.#.#####.###.#.#####.#.#.#####.#.#####.###.#V###.#.#.###.#.#.#######.###
#.#...#.#...#...#...#.#.#.....#.#.....#.#.....#.#...#...#.#...#...#...#...#...#.#
#.#.#.#.###.#.#.###.#.#.#.#####.#####.#.#.###.#.#######.#.#######.#######.#.###.#
#.#.#.#...#.#.#.....#.#.......#...#...#.#.#...#.........#...#.........#...#.....#
#.#.#.###.###.#######.#########.#.#.###.###.#.###########.#.#.#.#####.#.#.#####.#
#m#.#...#.....#...#.....#...#...#.#.....#...#...#...#.....#.#.#.#.......#...#...#
#.###O#.#######.#.#####.#.#.#.###.#######.#####.#.###.#.###.#.#.###########.#.###
#...#.#.#.......#.....#.#.#.#...#.....#.#.#...#...#..k#...#.#.#.#.....#...#.#.#.#
###.#.#.###.#########.###.#.###.#####.#.#.#.#.###.#.#####.###L#.#.###.#.#.###.#.#
#.#.#.#.....#l#.....#a..#.#.....#...#.#.#.#.#.#...#...#.#.#...#.#.#.#...#...#.#.#
#.#.#.#######.#.###.###.#.#######.###.#.#.#.#.#######.#.#.#.###.#.#.#######.#.#.#
#...#.#.#.K...#...#...#...#...........#.#...#.......#.#.#.#.#...#...#o....#.#...#
#Q###.#.#.#.#####.#.#######.###########.#.#######.###.#.#.#.#.#####.#.###.#.###.#
#.....#...#.......#............d.......@#@......#.......#...#.........#...#.....#
#################################################################################
#...........#.....#.....#...#.....#....@#@#.....#...D.......#...#.........#.....#
#.#.#######.#.###.#.###.#.#.###.#.###.#.#.#.#.###.###.#.#####.#.#.###.###.#.###.#
#g#.....#...#.#.#.#.#.....#.....#.#...#.#...#.....#.#.#.#.....#.....#.#.....#...#
#.#####.#.###.#.#.#.#############.#.###.#.#########.#.###.#########.#.#########.#
#.....#.#.#...#.....#...#...#...#.#...#.#.......#...#.....#...#...#.#.#.......#.#
#######.#.###.#######.#.#.#.#.#.#.#.#.#########.#.#########.#.#.#.###.#.#####.#.#
#.......#.....#.......#...#.#.#...#.#...#.....#.#.#.........#...#.....#...#.#.#.#
#.###########.#.###########.#.#########.#.#.###.#.#.#####################.#.#M#.#
#.#.........#.#.#.....#.....#...#.......#.#.#...#.#.....#.......#...........#.#.#
#.#.#######.#.#.#####.#.#######.###.###.#.#.#.###.#####.#.#####.#.###########.#.#
#.#.......#.#.#.....#.#.#.#...#...#.#.#.#.#.#.........#...#.#...#.....#.....#.#.#
#.#######.#.#######.#.#.#.#.#.###.#.#.#.#.#.#########.#####.#.###.#####.###.#.#.#
#.#.....S.#.......#.#.#.#.#.#.....#.#...#.#.........#...#...#.....#...#.#...#.#.#
#.#.#########.#.###.#.#.#.#.#######.#.###########.#.###.###.#######.#.#.#.###.#.#
#...#.......#.#.#.....#.#.#...#.....#...#.......#.#.......#...#.....#...#...#.#.#
#######.###.#.###.#####.#.###.#.#######.#.#####.#.#######.###.#.###########.#.#.#
#.....#.#...#.....#.....#...#...#...#...#.#.#...#.#.....#.....#.#.....#.....#.#.#
#.###.#.#.#########.#####.#########.#.###.#.#.#####.###.#.#####.#.###.#.#####.#A#
#.#.....#.....#...#...#...#.........#...#...#.....#.#...#.#...#.#...#.#.#.....#.#
#.#.###########.#.###.#.#.#.###.#.#####.###F#####.#.#.#####.#.#.###.#.#.###.###.#
#.#...#.........#...#.#.#...#...#.#.....#.#...#.#v..#....t#.#n#...#.#.#.#...#...#
#.#.###.###########.###.#####.#####.#####.###.#.#########.#.###.#.#.###.#.###.###
#.#.#.....#.........#.#.#...#...#...#...#...#.#.......#...#...#.#.#.#.....#.#.#.#
#.#.#.#####.#######.#.#.#.#####.#.#####.#.###.###.###.#.#.###.###.#.#.#####.#.#.#
#.#.#...#...#.....#...#.#.#...#.#.#...#.#...#.....#...#.#...#...#.#...#...#...#.#
#.#####.#.#.#.###.###.#.#.#.#.#.#.#.#.#.###.#####.#####.#######.#.###.#.#.###.#.#
#.#.B.#.#.#.#...#...#.#.#...#.#.#...#.#.#.....#...#..y#.#..u....#...#.#.#...#.#.#
#.#.#.#.#.#.###.###.###.#####.#.#####.#.#.###.#.###.#.#.#.#######.#.###.###.#.#.#
#.#.#.#.#.#.#.....#...#.......#.....#...#.#.#.#.#.#.#...#.#.......#.......#.#...#
#.#.#.#.#.###.#######.#######.#####.###.#.#.#.#.#.#.#####.#.#############.#.###.#
#...#...#.....#.....#.......#.#.#...#.#.#.#...#...#.......#.#.........#...#c#.#.#
#.#############.###.#######.#.#.#.#.#.#.#.#.#####.#########.#.#######.#.###.#.#.#
#.#...........#...#...#...#.#.#.#.#...#.#.#.#...#.#.#.....Z.#.......#.#.#...#...#
#.#########.#####.###.#.#.#.#.#.#.#.###.#.#.#.#.#.#.#.#############.#.###.###.###
#i#.......#.#...#x#..h..#...#.#.#.#.#...#.#...#r#.#...#.....#.J.....#...#...#...#
#.#.#####.#.#.#.#.#########.#.#.#.###.###.###.###.#####.###.#.#########.###.###.#
#.#...#...#.#.#...#...#...#.#.#.#.#...#.#...#.#...#...#.#.#...#.......#...#.#q..#
#.###.#.###.#.#####.#.#.#.###.#.#.#.###.#.#.###.###.#.#.#.#####.###.#####.#.#.###
#.....#.....#.......#...#.......#.......#.#.........#...#...W.....#.........#...#
#################################################################################";
}
﻿using System.Collections.Generic;
using System.Linq;

namespace Aoc.Puzzles.Aoc2018.Day01;

public static class FrequencyChangeListReader
{
    public static List<int> Read(string str)
    {
        return IntListReader.Read(RemovePlusSigns(str)).ToList();
    }

    private static string RemovePlusSigns(string input)
    {
        return input.Replace("+", "");
    }
}
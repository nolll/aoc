﻿using Core.Bingo;

namespace ConsoleApp.Years.Year2021.Puzzles
{
    public class Day04 : Day2021
    {
        public Day04() : base(4)
        {
        }

        public override PuzzleResult RunPart1()
        {
            var diagnostics = new BingoGame(FileInput);
            var result = diagnostics.Play(false);

            return new PuzzleResult(result, 45031);
        }

        public override PuzzleResult RunPart2()
        {
            var diagnostics = new BingoGame(FileInput);
            var result = diagnostics.Play(true);

            return new PuzzleResult(result, 2568);
        }
    }
}
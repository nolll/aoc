﻿using Core.Platform;

namespace Core.Puzzles.Year2017.Day03
{
    public class Year2017Day03 : Year2017Day
    {
        public override int Day => 3;

        public override PuzzleResult RunPart1()
        {
            var memory1 = new SpiralMemory(Input, SpiralMemoryMode.RunToTarget);
            return new PuzzleResult(memory1.Distance, 438);
        }

        public override PuzzleResult RunPart2()
        {
            var memory2 = new SpiralMemory(Input, SpiralMemoryMode.RunToValue);
            return new PuzzleResult(memory2.Value, 266_330);
        }

        private const int Input = 265149;
    }
}
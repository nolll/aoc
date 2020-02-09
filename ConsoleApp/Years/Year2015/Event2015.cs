﻿using System.Collections.Generic;

namespace ConsoleApp.Years.Year2015
{
    public class Event2015 : Event
    {
        public Event2015() : base(2015)
        {
        }

        protected override IList<Day> Days => new List<Day>
        {
            new Day01(),
            new Day02(),
            new Day03(),
            new Day04(),
            new Day05(),
            new Day06(),
            new Day07(),
            new Day08(),
            new Day09(),
            new Day10(),
            new Day11(),
            new Day12(),
            new Day13(),
            new Day14(),
            new Day15()
        };
    }
}
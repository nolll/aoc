﻿using System.Collections.Generic;

namespace ConsoleApp.Years.Year2018
{
    public class Event2018 : Event
    {
        public Event2018() : base(2018)
        {
        }

        protected override IList<Day> Days => new List<Day>
        {
            new Day01(),
            new Day02(),
            new Day03(),
            new Day04(),
            new Day05(),
            new Day06()
        };
    }
}
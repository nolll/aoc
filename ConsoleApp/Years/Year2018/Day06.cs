﻿using System;
using Core.ChronalCoordinates;

namespace ConsoleApp.Years.Year2018
{
    public class Day06 : Day
    {
        public Day06() : base(6)
        {
        }

        protected override void RunDay()
        {
            WritePartTitle();
            var finder = new LargestAreaFinder(Input);
            var size1 = finder.GetSizeOfLargestArea();
            Console.WriteLine($"Size of largest area: {size1}");

            WritePartTitle();
            var size2 = finder.GetSizeOfCentralArea(10000);
            Console.WriteLine($"Size of central area: {size2}");
        }

        private const string Input = @"342, 203
79, 64
268, 323
239, 131
246, 87
161, 93
306, 146
43, 146
57, 112
241, 277
304, 303
143, 235
253, 318
97, 103
200, 250
67, 207
345, 149
133, 222
232, 123
156, 359
80, 224
51, 145
138, 312
339, 294
297, 256
163, 311
241, 321
126, 66
145, 171
359, 184
241, 58
108, 312
117, 118
101, 180
58, 290
324, 42
141, 190
270, 149
209, 294
296, 345
68, 266
233, 281
305, 183
245, 230
161, 295
335, 352
93, 66
227, 59
264, 249
116, 173";
    }
}
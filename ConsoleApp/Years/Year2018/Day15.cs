﻿using System;
using Core.BeverageBandits;

namespace ConsoleApp.Years.Year2018
{
    public class Day15 : Day
    {
        public Day15() : base(15)
        {
        }

        protected override void RunDay()
        {
            WritePartTitle();
            var battle = new ChocolateBattle(Input);
            battle.Run(false);
            Console.WriteLine($"Battle outcome: {battle.Outcome}");
        }

        private const string Input = @"
################################
######..#######.################
######...######..#.#############
######...#####.....#############
#####....###G......#############
#####.#G..#..GG..##########..#.#
#######G..G.G.....##..###......#
######....G...........#.....####
#######.G......G........##..####
######..#..G.......E...........#
######..G................E..E..#
####.............E..........#..#
#####.........#####........##..#
########.....#######.......#####
########..G.#########......#####
#######.....#########....#######
#######G....#########..G...##.##
#.#.....GG..#########E##...#..##
#.#....G....#########.##...#...#
#....##......#######..###..##E.#
####G.........#####...####....##
####..G...............######..##
####....#.....##############.###
#..#..###......#################
#..#..###......#################
#.....#####....#################
###########.E.E.################
###########.E...################
###########.E..#################
#############.##################
#############.##################
################################";
    }
}
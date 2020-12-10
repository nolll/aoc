﻿using System;
using System.IO;
using System.Text;
using Core.Asteroids;
using Core.Tools;

namespace ConsoleApp.Years
{
    public class PuzzleResult
    {
        public string Message { get; }
        
        public PuzzleResult(string message)
        {
            Message = message;
        }
    }

    public abstract class Day
    {
        private int _part;
        protected abstract void RunDay();
        public abstract int Year { get; }
        private readonly Timer _timer;
        public int Id { get; }

        protected Day(int day)
        {
            Id = day;
            _timer = new Timer();
            _part = 1;
        }

        public void Run()
        {
            _timer.Start();
            WriteDayTitle();
            RunDay();
            WriteDayEnd();
        }

        public virtual PuzzleResult RunPart1()
        {
            return null;
        }

        public virtual PuzzleResult RunPart2()
        {
            return null;
        }

        protected string FileInput
        {
            get
            {
                var filePath = FilePath;
                if(!File.Exists(filePath))
                    throw new FileNotFoundException("File not found", filePath);

                return File.ReadAllText(filePath, Encoding.UTF8);
            }
        }

        private string FilePath => Path.Combine(
                Directory.GetCurrentDirectory(),
                "Years",
                $"Year{Year}",
                "Inputs",
                $"{PaddedDay}.txt");

        private string PaddedDay => Id.ToString().PadLeft(2, '0');

        protected void WritePartTitle()
        {
            Console.WriteLine();
            Console.WriteLine($"Part {_part}:");
            _part++;
        }

        private void WriteDayTitle()
        {
            Console.WriteLine();
            Console.WriteLine($"Day {Id} {Year}:");
            Printer.PrintDivider();
        }

        private void WriteDayEnd()
        {
            Printer.PrintDivider();
            Printer.PrintTime(_timer);
        }
    }
}
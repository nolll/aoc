﻿using FluentAssertions;
using NUnit.Framework;

namespace Puzzles.common.Parameters;

public class ParameterTests
{
    [Test]
    public void NoParameters()
    {
        var result = Puzzles.Parameters.Parse("");

        result.Id.Should().BeNull();
        result.Tags.Should().BeEmpty();
        result.ShowHelp.Should().BeFalse();
    }

    [TestCase("--puzzle 1")]
    [TestCase("-p 1")]
    public void ParsePuzzle(string input)
    {
        var result = Puzzles.Parameters.Parse(input);

        result.Id.Should().Be("1");
    }

    [TestCase("--tags 1,test,3")]
    [TestCase("-t 1,test,3")]
    public void ParseTags(string input)
    {
        var result = Puzzles.Parameters.Parse(input);

        result.Tags[0].Should().Be("1");
        result.Tags[1].Should().Be("test");
        result.Tags[2].Should().Be("3");
    }
    
    [TestCase("--help")]
    [TestCase("--help true")]
    [TestCase("-h")]
    [TestCase("-h true")]
    public void ParseHelp(string input)
    {
        var result = Puzzles.Parameters.Parse(input);

        result.ShowHelp.Should().BeTrue();
    }

    [TestCase("--aaa", true)]
    [TestCase("--aaa true", true)]
    [TestCase("--aaa false", false)]
    [TestCase("--aaa bad", null)]
    [TestCase("--bbb", false)]
    [TestCase("-a", true)]
    [TestCase("-a true", true)]
    [TestCase("-a false", false)]
    [TestCase("-a bad", null)]
    [TestCase("-b", false)]
    public void ParseBool(string input, bool? expected)
    {
        var parser = new ParameterParser(input.Split(' '));
        var result = parser.GetBoolValue("-a", "--aaa");

        result.Should().Be(expected);
    }

    [TestCase("--aaa", null)]
    [TestCase("--aaa 1", 1)]
    [TestCase("--aaa 2", 2)]
    [TestCase("--aaa bad", null)]
    [TestCase("--bbb", null)]
    [TestCase("-a", null)]
    [TestCase("-a 1", 1)]
    [TestCase("-a 2", 2)]
    [TestCase("-a bad", null)]
    [TestCase("-b", null)]
    public void ParseInt(string input, int? expected)
    {
        var parser = new ParameterParser(input.Split(' '));
        var result = parser.GetIntValue("-a", "--aaa");

        result.Should().Be(expected);
    }
}
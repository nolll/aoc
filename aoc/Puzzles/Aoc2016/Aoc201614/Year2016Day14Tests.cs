using System.Linq;
using Common.Strings;
using NUnit.Framework;

namespace Aoc.Puzzles.Aoc2016.Aoc201614;

public class Year2016Day14Tests
{
    [Test]
    public void GeneratesCorrectKeys()
    {
        var generator = new KeyGenerator();
        var index = generator.GetIndexOfNThKey("abc", 64, 0);

        Assert.That(index, Is.EqualTo(22728));
    }

    [Test]
    public void GeneratesCorrectStretchedKeys()
    {
        var generator = new KeyGenerator();
        var index = generator.GetIndexOfNThKey("abc", 64, 10);

        Assert.That(index, Is.EqualTo(12665));
    }
    
    [TestCase(0, "577571be4de9dcce85a041ba0410f29f")]
    [TestCase(1, "eec80a0c92dc8a0777c619d9bb51e910")]
    [TestCase(2, "16062ce768787384c81fe17a7a60c7e3")]
    [TestCase(10, "8de2bfc94801e26c8c6729bd30d5c952")]
    public void StretchedHash(int iterations, string expected)
    {
        var generator = new KeyGenerator();
        var hashedBytes = generator.CreateHash("abc0", iterations);
        var hash = ByteConverter.ToString(hashedBytes);
            
        Assert.That(hash, Is.EqualTo(expected));
    }

    [TestCase("aaa01010101010101010", 'a')]
    [TestCase("bbaaab10101010101010", 'a')]
    [TestCase("bbaaabbbb01010101010", 'a')]
    [TestCase("bbaab010101010101010", null)]
    public void RepeatedChars(string str, char? expected)
    {
        var byteHash = str.ToCharArray().Select(o => (byte)o).ToArray();
        var c = KeyGenerator.GetRepeatingByte(byteHash);

        Assert.That(c, Is.EqualTo(expected));
    }
    
    [TestCase("aaaaa010101010101010", true)]
    [TestCase("bbaaaaaa101010101010", true)]
    [TestCase("101011010101010aaaaa", true)]
    [TestCase("bbaab010101010101010", false)]
    public void ByteHashFiveInARowOf(string stringHash, bool expected)
    {
        var byteHash = stringHash.ToCharArray().Select(o => (byte)o).ToArray();
        var hasFiveInARow = KeyGenerator.HasFiveInARowOf(byteHash, (byte)'a');

        Assert.That(hasFiveInARow, Is.EqualTo(expected));
    }

    [Test]
    public void Index39IsAKey()
    {
        var generator = new KeyGenerator();
        const string salt = "abc";
        const int index = 39;
        var hash = generator.GetHash(salt, index, 0);
        var isKey = generator.IsKey(salt, index, hash, 0);

        Assert.That(isKey, Is.True);
    }
}
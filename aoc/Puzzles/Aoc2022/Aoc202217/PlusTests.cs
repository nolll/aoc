using FluentAssertions;
using NUnit.Framework;
using Puzzles.common.CoordinateSystems.CoordinateSystem2D;

namespace Puzzles.aoc.Puzzles.Aoc2022.Aoc202217;

public class PlusTests
{
    [Test]
    public void CanMoveRight()
    {
        var matrix = new Matrix<char>(5, 5, '.');
        var bottomLeft = new MatrixAddress(1, 3);
        var shape = new PlusShape();
        shape.Paint(matrix, bottomLeft);
        Console.WriteLine(matrix.Print());

        var result = shape.CanMoveRight(matrix, bottomLeft);

        result.Should().BeTrue();
    }

    [Test]
    public void CanNotMoveRight()
    {
        var matrix = new Matrix<char>(5, 5, '.');
        var bottomLeft = new MatrixAddress(2, 3);
        var shape = new PlusShape();
        shape.Paint(matrix, bottomLeft);
        Console.WriteLine(matrix.Print());

        var result = shape.CanMoveRight(matrix, bottomLeft);

        result.Should().BeFalse();
    }

    [Test]
    public void CanNotMoveRightBlocked()
    {
        var matrix = new Matrix<char>(5, 5, '.');
        matrix.WriteValueAt(3, 1, 'o');
        var bottomLeft = new MatrixAddress(1, 3);
        var shape = new PlusShape();
        shape.Paint(matrix, bottomLeft);
        Console.WriteLine(matrix.Print());

        var result = shape.CanMoveRight(matrix, bottomLeft);

        result.Should().BeFalse();
    }

    [Test]
    public void CanMoveLeft()
    {
        var matrix = new Matrix<char>(5, 5, '.');
        var bottomLeft = new MatrixAddress(1, 3);
        var shape = new PlusShape();
        shape.Paint(matrix, bottomLeft);
        Console.WriteLine(matrix.Print());

        var result = shape.CanMoveLeft(matrix, bottomLeft);

        result.Should().BeTrue();
    }

    [Test]
    public void CanNotMoveLeft()
    {
        var matrix = new Matrix<char>(5, 5, '.');
        var bottomLeft = new MatrixAddress(0, 3);
        var shape = new PlusShape();
        shape.Paint(matrix, bottomLeft);
        Console.WriteLine(matrix.Print());

        var result = shape.CanMoveLeft(matrix, bottomLeft);

        result.Should().BeFalse();
    }

    [Test]
    public void CanNotMoveLeftBlocked()
    {
        var matrix = new Matrix<char>(5, 5, '.');
        matrix.WriteValueAt(1, 1, 'o');
        var bottomLeft = new MatrixAddress(1, 3);
        var shape = new PlusShape();
        shape.Paint(matrix, bottomLeft);
        Console.WriteLine(matrix.Print());

        var result = shape.CanMoveLeft(matrix, bottomLeft);

        result.Should().BeFalse();
    }

    [Test]
    public void CanMoveDown()
    {
        var matrix = new Matrix<char>(5, 5, '.');
        var bottomLeft = new MatrixAddress(1, 3);
        var shape = new PlusShape();
        shape.Paint(matrix, bottomLeft);
        Console.WriteLine(matrix.Print());

        var result = shape.CanMoveDown(matrix, bottomLeft);

        result.Should().BeTrue();
    }

    [Test]
    public void CanNotMoveDown()
    {
        var matrix = new Matrix<char>(5, 5, '.');
        var bottomLeft = new MatrixAddress(1, 4);
        var shape = new PlusShape();
        shape.Paint(matrix, bottomLeft);
        Console.WriteLine(matrix.Print());

        var result = shape.CanMoveDown(matrix, bottomLeft);

        result.Should().BeFalse();
    }

    [Test]
    public void CanNotMoveDownBlocked()
    {
        var matrix = new Matrix<char>(5, 5, '.');
        matrix.WriteValueAt(1, 3, 'o');
        var bottomLeft = new MatrixAddress(1, 3);
        var shape = new PlusShape();
        shape.Paint(matrix, bottomLeft);
        Console.WriteLine(matrix.Print());

        var result = shape.CanMoveDown(matrix, bottomLeft);

        result.Should().BeFalse();
    }
}
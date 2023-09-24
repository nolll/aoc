﻿namespace Aoc.Puzzles.Aoc2016.Day22;

public struct StorageNode
{
    public int Size { get; }
    public int Used { get; }
    public int Avail { get; }

    public StorageNode(int size, int used, int avail)
    {
        Size = size;
        Used = used;
        Avail = avail;
    }
}
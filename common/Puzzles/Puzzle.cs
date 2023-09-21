﻿using System.Text;

namespace common.Puzzles;

public abstract class Puzzle
{
    public abstract string Name { get; }
    public virtual string? Comment => null;
    public virtual bool IsSlow => false;
    public virtual bool NeedsRewrite => false;
    public virtual bool IsFunToOptimize => false;

    protected string FileInput
    {
        get
        {
            var filePath = FilePath;
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found", filePath);

            return File.ReadAllText(filePath, Encoding.UTF8);
        }
    }

    public abstract IList<Func<PuzzleResult>> RunFunctions { get; }

    protected virtual string FilePath => GetFilePath(GetType());
    protected abstract string GetFilePath(Type t);
    protected string RootPath => AppDomain.CurrentDomain.BaseDirectory;
}
﻿namespace Puzzles.common.Cryptography;

public static class CaesarCipher
{
    public static int Encrypt(char input)
        => input - 'A' + 1;
}
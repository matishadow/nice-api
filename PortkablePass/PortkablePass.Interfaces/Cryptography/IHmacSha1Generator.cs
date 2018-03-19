﻿namespace PortkablePass.Interfaces.Cryptography
{
    public interface IHmacSha1Generator
    {
        byte[] GenerateHmacSha1Hash(byte[] input, byte[] key);
        byte[] GenerateHmacSha1Hash(string input, byte[] key);
    }
}
﻿namespace apbd_tut3;

public class OverfillException : Exception
{
    public OverfillException(string message) : base(message)
    {
    }
}
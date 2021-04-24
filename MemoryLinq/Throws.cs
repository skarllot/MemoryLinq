using System;
using System.Diagnostics.CodeAnalysis;

namespace MemoryLinq
{
    internal static class Throws
    {
        [DoesNotReturn]
        public static void NoElementsException()
        {
            throw new InvalidOperationException(Strings.NoElements);
        }
    }
}
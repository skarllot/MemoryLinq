using System;

namespace MemoryLinq
{
    public static partial class MemoryEnumerable
    {
        public static TSource First<TSource>(this Memory<TSource> source)
        {
            return First((ReadOnlySpan<TSource>)source.Span);
        }

        public static TSource First<TSource>(this ReadOnlyMemory<TSource> source)
        {
            return First(source.Span);
        }

        public static TSource First<TSource>(this Span<TSource> source)
        {
            return First((ReadOnlySpan<TSource>)source);
        }

        public static TSource First<TSource>(this ReadOnlySpan<TSource> source)
        {
            TSource? value = TryGetFirst(source, out bool found);
            if (!found)
            {
                Throws.NoElementsException();
            }

            return value!;
        }

        private static TSource? TryGetFirst<TSource>(this ReadOnlySpan<TSource> source, out bool found)
        {
            if (source.Length == 0)
            {
                found = false;
                return default;
            }

            found = true;
            return source[0];
        }
    }
}
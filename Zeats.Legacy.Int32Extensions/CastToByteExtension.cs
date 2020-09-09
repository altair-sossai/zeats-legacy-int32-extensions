using System.Collections.Generic;

namespace Zeats.Legacy.Int32Extensions
{
    public static class CastToByteExtension
    {
        public static IEnumerable<byte> CastToByte(this IEnumerable<int> values)
        {
            foreach (var value in values)
                yield return value.CastToByte();
        }

        public static byte CastToByte(this int value)
        {
            return (byte) value;
        }
    }
}
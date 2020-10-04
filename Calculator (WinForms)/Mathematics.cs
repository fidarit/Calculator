namespace Calculator_WinForms
{
    class Mathematics
    {
        public static long Plus(long x, long y)
        {
            return x + y;
        }
        public static long Minus(long x, long y)
        {
            return x - y;
        }
        public static long Mult(long x, long y)
        {
            return x * y;
        }
        public static long Div(long x, long y)
        {
            return x / y;
        }
        public static long Mod(long x, long y)
        {
            long buf = x / y;

            return x - buf * y;
        }
        public static long And(long x, long y)
        {
            return x & y;
        }
        public static long Or(long x, long y)
        {
            return x | y;
        }
        public static long Xor(long x, long y)
        {
            return x ^ y;
        }
        public static long Lsh(long x, long y)
        {
            return x << (int)y;
        }
        public static long Rsh(long x, long y)
        {
            return x >> (int)y;
        }
    }
}

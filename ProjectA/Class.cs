using System;

namespace ProjectA
{
    internal sealed class Class
    {
        public static readonly long Field = ProjectB1.Class.Field + 1;

        private static void Main(string[] args)
        {
            Console.WriteLine(Field);
        }
    }
}
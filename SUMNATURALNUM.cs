namespace assignments
{
    class SUMNATURALNUM
    {
        public static void Main(string[] args)
        {
            int i, temp = 0;

            for (i = 1; i <= 10; i++)
            {
                temp = temp + i;
            }

            Console.WriteLine("sum of first 10 natural numbers:" + temp);
            Console.ReadKey();
        }
    }
}

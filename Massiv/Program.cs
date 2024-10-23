namespace dastur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ismlar = new string[]
            {
                "Suhrob",
                "Muzrob",
                "Shukrona",
                "Mustafo"
            };
            int[] baholar = new int[]
            {
                5,
                4,
                4,
                5

            };
            int[] random = new int[]
            {
                5,
                4,
                4,
                3
            };
            Array.Sort(random);
            Console.WriteLine(random[0]);

            Console.WriteLine($" uzunligi {ismlar.Length} | baholar {baholar.Length}");
            Console.WriteLine($"1. {ismlar[0]} | {baholar[0]}");
            Console.WriteLine($"2. {ismlar[1]} | {baholar[1]}");

        }
    }
}

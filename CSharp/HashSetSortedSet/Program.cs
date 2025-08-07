namespace HashSetSortedSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var conjunto = new HashSet<string>();

            conjunto.Add("Les Paul");
            conjunto.Add("Vox ac30");
            conjunto.Add("Valeton gp-200");

            foreach (var conj in conjunto)
            {
                Console.WriteLine(conj);
            }
        }
    }
}

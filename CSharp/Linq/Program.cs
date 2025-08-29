namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            //Três passos pra trabalhar com LINQ
            //1º - Criar um data source (coleção, array, recurso de Entrada/Saída, etc)
            //2º - Definir a Query
            //3º Executar a Query (foreach ou alguma operação terminal)
            // Data Source -> Query -> Execution

            //data source
            int[] numbers = new int[] { 1, 2, 3 };

            // query expression definition
            var result = numbers
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //execute the query
            foreach (var x in result)
                Console.WriteLine(x);
        }
    }
}

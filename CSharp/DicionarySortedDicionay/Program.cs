namespace DicionarySortedDicionay
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "Mateus Paulino";
            cookies["email"] = "Mateusgpaulino@gmail.com";
            cookies["phone"] = "19999873551";

            // ou no lugar desse KeyValuePair pode colocar um VAR pra não ficar t]ao verboso
            foreach (KeyValuePair<string, string> cookie in cookies)
            {
                Console.WriteLine($"{cookie.Key} : {cookie.Value}");
            }
        }
    }
}

using System;
using RestSharp;

namespace QuestionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ask your yes or no question:");
                var question = Console.ReadLine();
                var client = new RestClient("https://yesno.wtf/api");
                var request = new RestRequest();

                var reponse = client.ExecuteGetAsync<Data>(request).Result;

                Console.WriteLine(reponse.Data.answer);

                Console.WriteLine("Hit enter to ask another or CTRL+C to exit...");

                Console.ReadLine();
                Console.Clear();            }
        }

        public class Data
        {
            public string answer { get; set; }

            public string imageUrl { get; set; }
        }
    }
}

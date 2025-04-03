using System;
using System.Net.Http;
using System.Text.Json;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Temp t = new Temp();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://data.riksdagen.se/personlista/?utformat=json");
            client.DefaultRequestHeaders.Accept.Clear();

            HttpResponseMessage response = client.GetAsync("").Result;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                t = JsonSerializer.Deserialize<Temp>(result);
            }

            Printer.PrintResults(t);
        }
    }
}

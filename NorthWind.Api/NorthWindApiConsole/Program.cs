using NorthWindApi.Console;
using System.Text.Json;

namespace NorthWindApiConsole
{
    internal class Program
    {
        static void Main(string[] args
        {
            GetCategories();
        }
              static void GetCategories()
            {
                HttpClient httpClient = new HttpClient(); // HttpClient 
                httpClient.BaseAddress = new Uri("https://northwind.now.sh/");

                var result = httpClient.GetAsync("api/categories").Result;// Async metodunun direk sonucunu almaya zorlar 

                var jsonString = result.Content.ReadAsStringAsync().Result;

                var categories = JsonSerializer.Deserialize<List<Category>>(jsonString);

                foreach (var category in categories)
                    System.Console.WriteLine(
                        $"Id: {category.id} - " +
                        $"Name: {category.name} - " +
                        $"Description:{category.description}");

            }
        }
    }
}
    
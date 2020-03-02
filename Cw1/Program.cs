using System;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Cw1
{
    public class Program
    {
         
        public static async Task Main(string[] args) //async method
    {
        //int tmp1 = 1;
        //string tmp2 = "Ala ma kota";
        //String tmp3 = "i psa";
        //bool? tmp4 = null;
        //string path = @"C:\Users\s18966\Desktop\cw1";
        //Console.WriteLine($"{tmp1} {tmp2} {tmp3} {path}");
        //var tmp = "c";
        //var newPerson = new Person { FirstName = "Daniel" };

        var url = args[0];



        var httpClient = new HttpClient();
        var response = await httpClient.GetAsync(url); //async 


        //2xx
        if (response.IsSuccessStatusCode)
        {
            var htmlContent = await response.Content.ReadAsStringAsync();
            var regex = new Regex("[a-z]+[a-z0-9]*@[a-z0-9]+\\.[a-z]+", RegexOptions.IgnoreCase);
            var matches = regex.Matches(htmlContent);

            foreach (var match in matches)
            {
                Console.WriteLine(match.ToString());
            }

        }


    }

    }
}

using System;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;

namespace MediaWikiTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string article = GetOpenSearch(args).Result;
            GetData(article);
            Console.ReadKey();
        }

        static async Task<string> GetOpenSearch(string[] term)
        {
            try
            {
                string value = String.Join("", term);
                Console.WriteLine(value);
                Console.WriteLine();
                string openSearchUrl = $"https://nl.wikipedia.org//w/api.php?action=opensearch&format=json&origin=*&search={value}";

                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage res = await client.GetAsync(openSearchUrl))
                {
                    Console.WriteLine("Fetching open search...");
                    using (HttpContent content = res.Content)
                    {
                        string response = await content.ReadAsStringAsync();
                        response = response.Replace("[", "").Replace("]", "").Replace(",", "");
                        string[] stringArray = response.Split('"');
                        stringArray = stringArray.Where(x => !string.IsNullOrEmpty(x))
                            .Skip(1)
                            .ToArray();

                        Console.WriteLine("Open search fetch complete.");
                        //Console.WriteLine(response);
                        return stringArray[0].Replace(" ", "_");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return e.Message;
            }
        }
        private static async void GetData(string article)
        {
            string dataUrl = $"https://nl.wikipedia.org/w/api.php?action=query&titles={article}&format=xml&redirects=true&prop=extracts";
            //string dataUrl = $"https://nl.wikipedia.org/wiki/{article}";

            using (HttpClient client = new HttpClient())        
            using (HttpResponseMessage res = await client.GetAsync(dataUrl))
            {
                Console.WriteLine("Fetching content...");
                using (HttpContent content = res.Content)
                {
                    string response = await content.ReadAsStringAsync();
                    response = HttpUtility.HtmlDecode(response);

                    int indexFirstTag = response.IndexOf("<extract xml:space=\"preserve\">");
                    int indexLastTag = response.IndexOf("</extract>");

                    response = response.Substring(indexFirstTag, indexLastTag - indexFirstTag);


                    string acceptable = "b|i";
                    response = Regex.Replace(response, @"</?(?(?=" + acceptable + @")notag|[a-zA-Z0-9]+)(?:\s[a-zA-Z0-9\-]+=?(?:(["",']?).*?\1?)?)*\s*/?>", "");

                    Console.WriteLine(response);
                    Console.WriteLine("Done");
                }
            }
        }
    }
}

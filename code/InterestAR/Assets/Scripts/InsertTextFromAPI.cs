using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Net;

namespace Assets.Scripts
{

    public class InsertTextFromAPI : MonoBehaviour
    {
        public Text ChangingText;
        public String Returnvalue;
        async void Start()
        {
            string language = "fr";

            if (Returnvalue == "text")
            {
                ChangingText.text = await FullSearch("Eiffeltoren", language);
            }
            else if (Returnvalue == "title")
            {
                ChangingText.text = await GetOpenSearch("Eiffeltoren");
            }
        }

        static async Task<string> FullSearch(string term, string language)
        {
            string text = await GetData(term, language);

            if (string.IsNullOrEmpty(text)) text = await GetData(term);

            if (string.IsNullOrEmpty(text)) text = "No information found";
            return text;
        }

        static async Task<string> GetOpenSearch(string term, string language = "en")
        {
            term = Regex.Replace(term, @"s", "_");
            string openSearchUrl = $"https://{language}.wikipedia.org//w/api.php?action=opensearch&format=json&origin=*&search={term}";

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.GetAsync(openSearchUrl))
            using (HttpContent content = res.Content)
            {
                string response = await content.ReadAsStringAsync();
                response = response.Replace("[", "").Replace("]", "").Replace(",", "");
                string[] stringArray = response
                    .Split('"')
                    .Where(x => !string.IsNullOrEmpty(x))
                    .Skip(1)
                    .ToArray();

                string title = string.Empty;
                
                try
                {
                    title = stringArray[0].Replace(" ", "_");
                }
                catch (IndexOutOfRangeException)
                {
                    title = string.Empty;
                }

                if (title == string.Empty) throw new ArgumentNullException();

                return title;
            }
        }
        private static async Task<string> GetData(string args, string language = "en")
        {
            try
            {
                string article = await GetOpenSearch(args, language);
                string dataUrl = $"https://{language}.wikipedia.org/w/api.php?action=query&titles={article}&format=xml&redirects=true&prop=extracts";

                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage res = await client.GetAsync(dataUrl))
                using (HttpContent content = res.Content)
                {
                    string response = await content.ReadAsStringAsync();
                    response = WebUtility.HtmlDecode(response);

                    int indexFirstTag = response.IndexOf("<extract xml:space=\"preserve\">");
                    int indexLastTag = response.IndexOf("</extract>");

                    response = response.Substring(indexFirstTag, indexLastTag - indexFirstTag);

                    response = Regex.Replace(response, @"<\/?(?!b)(?!i)\w*\b[^>]*>", "");

                    return response;
                }
            }
            catch (Exception ex) when (ex is ArgumentNullException || ex is AggregateException)
            {
                return string.Empty;
            }
        }
    }
}

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
using Assets.Scripts.Services;

namespace Assets.Scripts
{
    public class InsertTextFromAPI : MonoBehaviour
    {
        public Text ChangingText;
        public String Returnvalue;
        async void Start()
        {
            string language = MemoryDataService.Language;

            if (Returnvalue == "text")
            {
                ChangingText.text = await fullSearch("Eiffel Tower", language);
            }
            else if (Returnvalue == "title")
            {
                ChangingText.text = await GetOpenSearch("Eiffel Tower", language);
            }
        }

        public static async Task<string> fullSearch(string term, string language)
        {
            string text = await GetData(term, language);

            if (string.IsNullOrEmpty(text))
            {
                text = await GetData(term);
            }

            if (string.IsNullOrEmpty(text))
            {
                text = "No information found";
            }
            return text;
        }

        public static async Task<string> GetOpenSearch(string term, string language)
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

                if (stringArray.Length > 0)
                {
                    title = stringArray[0].Replace(" ", "_");
                }
                else
                {
                    return string.Empty;
                }

                return title;
            }
        }
        private static async Task<string> GetData(string args, string language = "en")
        {
            string response = string.Empty;
            string article = await GetOpenSearch(args, language);

            if (!string.IsNullOrEmpty(article))
            {

                string dataUrl = $"https://{language}.wikipedia.org/w/api.php?action=query&titles={article}&format=xml&redirects=true&prop=extracts";

                using (HttpClient client = new HttpClient())
                using (HttpResponseMessage res = await client.GetAsync(dataUrl))
                using (HttpContent content = res.Content)
                {
                    response = await content.ReadAsStringAsync();
                    response = WebUtility.HtmlDecode(response);

                    int indexFirstTag = response.IndexOf("<extract xml:space=\"preserve\">");
                    int indexLastTag = response.IndexOf("</extract>");

                    response = response.Substring(indexFirstTag, indexLastTag - indexFirstTag);

                    response = Regex.Replace(response, @"<\/?(?!b)(?!i)\w*\b[^>]*>", "");
                }
            }
            return response;
        }
    }
}
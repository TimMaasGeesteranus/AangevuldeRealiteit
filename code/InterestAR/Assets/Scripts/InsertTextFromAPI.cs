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

public class InsertTextFromAPI : MonoBehaviour
{

    public Text ChangingText;
    public String Returnvalue;
    async void Start()
    {
        if (Returnvalue == "text")
        {
            ChangingText.text = await GetData("Eiffeltoren");
        }
        else if(Returnvalue == "title")
        {
            ChangingText.text = await GetOpenSearch("Eiffeltoren");
        }
    }



    static async Task<string> GetOpenSearch(string term)
    {
        term = Regex.Replace(term, @"s", "_");
        string openSearchUrl = $"https://nl.wikipedia.org//w/api.php?action=opensearch&format=json&origin=*&search={term}";

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

            string title = stringArray[0].Replace(" ", "_");
            if (title == string.Empty)
            {
                throw new ArgumentNullException();
            }
            return title;
        }
    }
    private static async Task<string> GetData(string args)
    {
        try
        {
            string article = await GetOpenSearch(args);
            string dataUrl = $"https://nl.wikipedia.org/w/api.php?action=query&titles={article}&format=xml&redirects=true&prop=extracts";

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.GetAsync(dataUrl))
            using (HttpContent content = res.Content)
            {
                string response = await content.ReadAsStringAsync();
                response = WebUtility.HtmlDecode(response);

                int indexFirstTag = response.IndexOf("<extract xml:space=\"preserve\">");
                int indexLastTag = response.IndexOf("</extract>");

                response = response.Substring(indexFirstTag, indexLastTag - indexFirstTag);

                string acceptable = "b|i";
                response = Regex.Replace(response, @"</?(?(?=" + acceptable + @")notag|[a-zA-Z0-9]+)(?:\s[a-zA-Z0-9\-]+=?(?:(["",']?).?\1?)?)\s*/?>", "");

                return response;
            }
        }
        catch (Exception)
        {
            return "Could not load information";
        }
    }
}

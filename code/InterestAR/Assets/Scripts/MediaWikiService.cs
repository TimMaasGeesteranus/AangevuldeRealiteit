using System;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediaWikiService : MonoBehaviour
{
    private static async Task<string> GetOpenSearch(string term)
    {
        term = Regex.Replace(term, " ", "_");
        string openSearchUrl = $"https://en.wikipedia.org//w/api.php?action=opensearch&format=json&origin=*&search={term}";

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

    public static async Task<string> GetData(string args)
    {
        try
        {
            string article = await GetOpenSearch(args);
            string dataUrl = $"https://en.wikipedia.org/w/api.php?action=query&titles={article}&format=xml&redirects=true&prop=extracts";

            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.GetAsync(dataUrl))
            using (HttpContent content = res.Content)
            {
                string response = await content.ReadAsStringAsync();
                response = HttpUtility.HtmlDecode(response);

                int indexFirstTag = response.IndexOf("<extract xml:space=\"preserve\">");
                int indexLastTag = response.IndexOf("</extract>");

                response = response.Substring(indexFirstTag, indexLastTag - indexFirstTag);

                string acceptable = "b|i";
                response = Regex.Replace(response, @"</?(?(?=" + acceptable + @")notag|[a-zA-Z0-9]+)(?:\s[a-zA-Z0-9\-]+=?(?:(["",']?).*?\1?)?)*\s*/?>", "");

                return response;
            }
        }
        catch (Exception)
        {
            return "Could not load information";
        }
    }
}


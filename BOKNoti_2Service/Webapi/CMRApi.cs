using Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace BOKNoti_2Service.Webapi;

public class CMRApi
{

    private readonly HttpClient _httpClient = new HttpClient();

    /// <summary>
    /// 臺南市37區道路路樹盤點調查表-2016年前CSV
    /// </summary>
    private readonly string _url = @"https://soa.tainan.gov.tw/Api/Service/Get/f7aee1d5-ea9a-40ef-a475-70a928b46af2";

    private readonly Dictionary<string, string> _apiurl = new Dictionary<string, string>();

    public CMRApi()
    {
        _apiurl.Add("tree", _url);
    }


    public async Task<string> Listening()
    {
        await Task.Delay(1000);

        string stringData = await _httpClient.GetStringAsync(_url);

        dynamic JOBJ = JObject.Parse(stringData);

        List<TreeMap>? alldata = ((JArray)JOBJ.data).ToObject<List<TreeMap>>();

        string rval = "";

        if (alldata is null)
        {
            return $"null{Environment.NewLine}";
        }

        foreach (TreeMap item in alldata.Take(100))
        {
            rval += $"{item}{Environment.NewLine}";
        }

        return rval;
    }


    public async Task<string> GetStringAsync(string url)
    {
        await Task.Delay(1000);

        string stringData = await _httpClient.GetStringAsync(url);

        return stringData;
    }

    public async Task<string> PostAsync(string url, HttpContent content)
    {
        await Task.Delay(500);

        HttpResponseMessage response = await _httpClient.PostAsync(url, content);

        string stringData = await response.Content.ReadAsStringAsync();

        return stringData;
    }

    int AddTwoNumbers(int a, int b)
    {
        return a + b;
    }

    
}

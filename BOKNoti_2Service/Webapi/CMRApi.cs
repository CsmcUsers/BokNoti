using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BOKNoti_2Service.Webapi;

public class CMRApi
{

    private readonly HttpClient _httpClient = new HttpClient();

    private readonly string _url = "";

    public async Task<string> Listening()
    {

        await Task.Delay(1000);

        var stringData = await _httpClient.GetStringAsync(_url);

        return $"Listening...   {stringData}";
    }

}

using System.Net.Http.Json;

using EDCalculations.APIs.EliteBgs.Models;

namespace EDCalculations.APIs.EliteBgs;

public class EbgsQueries : QueriesBase
{
    public EbgsQueries(HttpClient client) : base(client) { }

    public async Task<EbgsFactionsV5> GetFactionsAsync(string factionName)
    {
        const string apiUrl = ApiConstants.ebgsFactions;
        string query = $"?name={Uri.EscapeDataString(factionName)}";

        return (await GetFromApi<Response<EbgsFactionsV5>>(apiUrl + query)).Docs.First();
    }
}

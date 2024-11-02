using Google.Cloud.Language.V1;
using System.Diagnostics;
using System.Threading.Tasks;

public class SentimentAnalysisService
{
    private readonly LanguageServiceClient _client;

    public SentimentAnalysisService(string apiKey)
    {
        _client = new LanguageServiceClientBuilder
        {
            ApiKey = apiKey
        }.Build();
    }

    public async Task<AnalyzeSentimentResponse> AnalyzeSentimentAsync(string text)
    {
        var document = Document.FromPlainText(text);
        return await _client.AnalyzeSentimentAsync(document);
    }
}

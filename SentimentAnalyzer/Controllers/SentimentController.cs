using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class SentimentController : ControllerBase
{
    private readonly SentimentAnalysisService _sentimentService;

    public SentimentController(SentimentAnalysisService sentimentService)
    {
        _sentimentService = sentimentService;
    }

    [HttpPost("analyze")]
    public async Task<IActionResult> Analyze([FromBody] string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return BadRequest("Text cannot be empty.");
        }

        var result = await _sentimentService.AnalyzeSentimentAsync(text);

        if (result.DocumentSentiment == null)
        {
            return BadRequest("Sentiment analysis failed to return results.");
        }

        return Ok(new
        {
            SentimentScore = result.DocumentSentiment.Score,
            Magnitude = result.DocumentSentiment.Magnitude
        });
    }
}

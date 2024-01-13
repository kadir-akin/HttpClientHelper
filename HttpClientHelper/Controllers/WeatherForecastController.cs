using HttpClientHelper.HttpClient.Abstract;
using HttpClientHelper.HttpClient.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace HttpClientHelper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IAknHttpClient<TestInternalServiceConfiguration> _testInternalService;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IAknHttpClient<TestInternalServiceConfiguration> testInternalService)
        {
            _logger = logger;
            _testInternalService = testInternalService;
        }

        [HttpGet]
        public async Task<object> Get()
        {
            var result = await _testInternalService.SendAsync<List<TestInternalServiceResponse>, object>("/posts", HttpMethodType.GET);

            return result;
        }
    }
}
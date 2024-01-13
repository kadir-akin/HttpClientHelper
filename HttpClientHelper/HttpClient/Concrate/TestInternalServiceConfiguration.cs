
using HttpClientHelper.HttpClient.Concrate;
using System.Collections.Generic;

namespace HttpClientHelper
{
    public class TestInternalServiceConfiguration : IAknHttpConfiguration
    {
        public string BaseUrl { get; set; }
        public int Timeout { get; set; }
        public Dictionary<string, string> DefaulHeaders { get; set; }
        public bool IgnoreNullValues { get; set; }
        public bool PropertyNameCaseInsensitive { get; set; }
    }
}

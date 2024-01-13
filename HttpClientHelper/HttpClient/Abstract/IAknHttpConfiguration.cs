
namespace HttpClientHelper.HttpClient.Concrate
{
    public interface IAknHttpConfiguration
    {
        public string BaseUrl { get; set; }
        public int Timeout { get; set; }
        public Dictionary<string,string> DefaulHeaders { get; set; }
        public bool IgnoreNullValues { get; set; } 
        public bool PropertyNameCaseInsensitive { get; set; }


    }
}

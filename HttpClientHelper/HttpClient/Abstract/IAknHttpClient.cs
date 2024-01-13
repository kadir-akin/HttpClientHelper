using HttpClientHelper.HttpClient.Concrate;

namespace HttpClientHelper.HttpClient.Abstract
{
    public interface IAknHttpClient<TConfiguration>  where TConfiguration : class, IAknHttpConfiguration 
    {
        public Task<AknHttpResponse<TSuccess,TError>> SendAsync<TSuccess, TError>(string prefixUrl, HttpMethodType httpMethodType, HttpContent httpContent=null , Dictionary<string, string> headers = null) where TSuccess : class where TError :class;
        public Task<AknHttpResponse<TError>> SendAsync<TError>(string prefixUrl, HttpMethodType httpMethodType, HttpContent httpContent=null,  Dictionary<string, string> headers = null) where TError : class;
    }

}

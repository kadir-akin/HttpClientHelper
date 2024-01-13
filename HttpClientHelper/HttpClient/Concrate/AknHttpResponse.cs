using System;
using System.Collections.Generic;
using System.Text;

namespace HttpClientHelper.HttpClient.Concrate
{
    public class AknHttpResponse<TSuccess,TError> : AknHttpResponse<TError> where TSuccess : class
    {
        public AknHttpResponse(System.Net.Http.HttpResponseMessage httpResponse, TSuccess data) :base(httpResponse)
        {
            SuccessData = data;
        }
        public AknHttpResponse(System.Net.Http.HttpResponseMessage httpResponse, TError data) : base(httpResponse)
        {
            ErrorData = data;
        }
        public TSuccess SuccessData { get; set; }

    }
    public class AknHttpResponse<TError> 
    {       
        public AknHttpResponse(System.Net.Http.HttpResponseMessage httpResponse,TError errorData=default(TError))
        {
            IsSuccess = httpResponse.IsSuccessStatusCode;
            HttpStatusCode = (int)httpResponse.StatusCode;
            ErrorData = errorData;
        }
    
        public bool IsSuccess{ get; set; }
        public int HttpStatusCode { get; set; }
        public TError ErrorData { get; set; }

    }
}

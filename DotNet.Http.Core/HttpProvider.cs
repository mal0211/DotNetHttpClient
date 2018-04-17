namespace DotNet.Http.Core
{
    public class HttpProvider:IHttpProvider
    {
        public HttpResponseParameter Excute(HttpRequestParameter requestParameter)
        {
            return HttpUtil.Excute(requestParameter);
        }

        public string ExcutePostJson(string url, string jsonString)
        {
            return HttpUtil.ExcutePostJson(url, jsonString);
        }
    }
}

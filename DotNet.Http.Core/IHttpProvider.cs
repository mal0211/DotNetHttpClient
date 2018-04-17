namespace DotNet.Http.Core
{
    public interface IHttpProvider
    {
        HttpResponseParameter Excute(HttpRequestParameter requestParameter);
    }
}

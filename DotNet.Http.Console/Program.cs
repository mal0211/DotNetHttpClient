using System.Collections.Generic;
using System.Text;
using DotNet.Http.Core;

namespace DotNet.Http.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IHttpProvider httpProvider = new HttpProvider();

            // 1. 模拟一个Get请求方式
            HttpResponseParameter responseParameter1 = httpProvider.Excute(new HttpRequestParameter
            {
                Url = "http://www.baidu.com",
                IsPost = false,
                Encoding = Encoding.UTF8
                //Cookie = new HttpCookieType() 如果需要Cookie
            });
            System.Console.WriteLine(responseParameter1.Body);

            // 2. 模拟一个Post请求方式（例：登录)
            IDictionary<string, string> postData = new Dictionary<string, string>();
            postData.Add("userName", "登录用户名");
            postData.Add("userPwd", "用户名密码");
            HttpResponseParameter responseParameter2 = httpProvider.Excute(new HttpRequestParameter
            {
                Url = "你的登录url",
                IsPost = true,
                Encoding = Encoding.UTF8,
                Parameters = postData
            });
            System.Console.WriteLine(responseParameter2.Body);

            System.Console.ReadLine();
        }
    }
}

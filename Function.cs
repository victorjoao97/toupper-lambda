using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ToUpper
{
    public class Function
    {
        public async Task<bool> FunctionHandler(RequestImportacaoDataConsig request, ILambdaContext context)
        {
            var client = new HttpClient();
            var result = await client.GetAsync("https://www.google.com/search?q=ingles+para+portugues&oq=ingles&aqs=chrome.0.69i59j69i57j0i395i433l2j0i395j0i395i433j46i395j0i395i433.903j1j7&sourceid=chrome&ie=UTF-8");
            Console.WriteLine(result.StatusCode.ToString());
            return request.Entidade_Id % 2 == 0;
        }
    }

    public class RequestImportacaoDataConsig
    {
        public int Entidade_Id { get; set; }
        public int? Usuario_Id { get; set; }
        public int? Unidade_Id { get; set; }
    }
}

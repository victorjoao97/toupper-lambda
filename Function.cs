using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace ToUpper
{
    public class Function
    {
        public bool FunctionHandler(int entidade_id, ILambdaContext context)
        {
            return entidade_id % 2 == 0;
        }
    }
}

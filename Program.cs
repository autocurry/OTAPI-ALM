using System;
using System.Configuration;
using System.IO;
using Microsoft.Extensions.Configuration;
namespace OTAPI_ALM
{
    class Program
    {
            public static IConfiguration _configuration {get;set;}
        public static void Main(string[] args)
        {
     
         var builder = new ConfigurationBuilder()
      .AddJsonFile("appsettings.json", optional:true, reloadOnChange:true)
      .SetBasePath(Directory.GetCurrentDirectory())
      .AddEnvironmentVariables();

      _configuration = builder.Build();

      var value = _configuration["Message"];
        }
    }
}

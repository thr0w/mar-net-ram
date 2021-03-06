﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;

namespace AwsWebApp1
{
    public class gravar : IHttpHandler
    {

        private static AmazonDynamoDBClient client;
        private static string tableNome = "dados";

        public void ProcessRequest(HttpContext context)
        {
            var config = new AmazonDynamoDBConfig();
            config.ServiceURL = "http://dynamodb.us-east-1.amazonaws.com";
            client = new AmazonDynamoDBClient(config);

            Table dados = Table.LoadTable(client, tableNome);
            var dado = new Document();
            
            dado["chave"] = context.Request.Params["chave"];
            dado["dados"] = context.Request.Params["dado"];
            dados.PutItem(dado);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}

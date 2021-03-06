﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Amazon.DynamoDBv2;
using Amazon.DynamoDBv2.DocumentModel;
using Amazon.Runtime;

namespace AwsWebApp1
{
    /// <summary>
    /// Summary description for gravar
    /// </summary>
    public class rec : IHttpHandler
    {

        private static AmazonDynamoDBClient cliente;
        private static string tableNomes = "dados";

        public void ProcessRequest(HttpContext context)
        {
            var config = new AmazonDynamoDBConfig();
            config.ServiceURL = "http://dynamodb.us-east-1.amazonaws.com";
            cliente = new AmazonDynamoDBClient( config);
            
            Table dados = Table.LoadTable(cliente, tableNomes);
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

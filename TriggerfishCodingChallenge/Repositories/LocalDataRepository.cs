using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using TriggerfishCodingChallenge.Models;

namespace TriggerfishCodingChallenge.Repositories
{
    public class LocalDataRepository: IDataRepository
    {
        private readonly string _articleLocalData;
        private readonly string _articleLocalDataFilePath = ConfigurationManager.AppSettings["ArticleLocalDataFilePath"];

        public LocalDataRepository()
        {
            _articleLocalData = File.ReadAllText(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _articleLocalDataFilePath));
        }
        public IEnumerable<Article> GetArticleCollection()
        {
            List<Article> allArtiles = JsonConvert.DeserializeObject<List<Article>>(_articleLocalData);

            return allArtiles;
        }
        
    }
}
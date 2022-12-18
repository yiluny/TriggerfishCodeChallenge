using System.Collections.Generic;
using TriggerfishCodingChallenge.Models;

namespace TriggerfishCodingChallenge.Repositories
{
    public interface IDataRepository
    {
        IEnumerable<Article> GetArticleCollection();

    }
}
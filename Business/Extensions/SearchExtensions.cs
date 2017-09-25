using EPiServer.Find;
using EPiServer.Find.Api.Querying.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace BbmUnderlakare.Business.Extensions
{
    public static class SearchExtensions
    {
        public static ITypeSearch<T> WildCardQuery<T>(
            this ITypeSearch<T> search,
            string query,
            Expression<Func<T, string>> fieldSelector,
            double? boost = null)
        {
            //Create the Wildcard query object
            var fieldName = search.Client.Conventions
                .FieldNameConvention
                .GetFieldNameForAnalyzed(fieldSelector);
            var wildcardQuery = new WildcardQuery(
                fieldName,
                query.ToLowerInvariant());
            wildcardQuery.Boost = boost;

            //Add it to the search request body
            return new Search<T, WildcardQuery>(search, context =>
            {
                if (context.RequestBody.Query != null)
                {
                    var boolQuery = new BoolQuery();
                    boolQuery.Should.Add(context.RequestBody.Query);
                    boolQuery.Should.Add(wildcardQuery);
                    boolQuery.MinimumNumberShouldMatch = 1;
                    context.RequestBody.Query = boolQuery;
                }
                else
                {
                    context.RequestBody.Query = wildcardQuery;
                }
            });
        }
    }
}
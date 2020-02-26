using System;
using System.Collections.Generic;

namespace Verbaros.Json2Doc
{
    public class ObjectDocument : DataSource
    {
        private string docString = "";

        private Dictionary<string,dynamic> doc = new Dictionary<string, dynamic>();

        public override bool IsPath(string path)
        {
            return path.StartsWith('.');
        }

        public override dynamic GetValue(string path)
        {
            throw new NotImplementedException();
        }

        //isQuery validates if the input string can be a query parsable by the data source
        public override bool IsQuery(string query)
        {
            return query.StartsWith('.');
        }

        //getCollection retuns a collection of paths
        public override IEnumerable<string> GetQueryValuePaths(string query)
        {
            throw new NotImplementedException();
        }   



    }
}
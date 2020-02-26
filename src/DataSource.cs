using System.Collections.Generic;

namespace Verbaros.Json2Doc
{
    public abstract class DataSource
    {
        //isPath validates if the input string can be a path to a value (it does not validate if the value exists)
        public abstract bool IsPath(string path);

        //getValue gets a value based on the supplied paths
        public abstract dynamic GetValue(string path);

        //isQuery validates if the input string can be a query parsable by the data source
        public abstract bool IsQuery(string query);

        //getCollection retuns a collection of paths
        public abstract IEnumerable<string> GetQueryValuePaths(string query);         
    }
}

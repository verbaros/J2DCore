using System.Collections.Generic;

namespace Verbaros.J2DCore
{
    internal abstract class DataSource
    {
        //isPath validates if the input string can be a path to a value (it does not validate if the value exists)
        internal abstract bool IsPath(string path);

        //getValue gets a value based on the supplied paths
        internal abstract dynamic GetValue(string path);

        //isQuery validates if the input string can be a query parsable by the data source
        internal abstract bool IsQuery(string query);

        //getCollection retuns a collection of paths
        internal abstract IEnumerable<string> GetQueryValuePaths(string query);         
    }
}

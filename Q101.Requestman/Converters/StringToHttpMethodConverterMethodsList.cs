using System.Collections.Generic;
using System.Net.Http;

namespace Q101.Requestman.Converters
{
    /// <summary>
    /// Http Methods List
    /// </summary>
    public class StringToHttpMethodConverterMethodsList
    {
        /// <summary>
        /// Http Methods List
        /// </summary>
        public Dictionary<string, HttpMethod> List =>
            new Dictionary<string, HttpMethod>
            {
                { "get", HttpMethod.Get },
                { "post", HttpMethod.Post },
                { "put", HttpMethod.Put },
                { "delete", HttpMethod.Delete },
                { "head", HttpMethod.Head },
                { "options", HttpMethod.Options },
                { "trace", HttpMethod.Trace }
            };
    }
}

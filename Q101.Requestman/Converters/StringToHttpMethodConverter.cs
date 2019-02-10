using System.Collections.Generic;
using System.Net.Http;

namespace Q101.Requestman.Converters
{
    /// <summary>
    /// Converter string to http method
    /// </summary>
    public class StringToHttpMethodConverter
    {
        private readonly Dictionary<string, HttpMethod> _methods;

        public StringToHttpMethodConverter(Dictionary<string, HttpMethod> methods)
        {
            _methods = methods;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="stringValue"></param>
        /// <returns></returns>
        public HttpMethod Convert(string stringValue)
        {
            var method = HttpMethod.Get;

            if (string.IsNullOrEmpty(stringValue))
            {
                return method;
            }

            stringValue = stringValue.ToLower();

            if (_methods.ContainsKey(stringValue))
            {
                method = _methods[stringValue];
            }

            return method;
        }
    }
}

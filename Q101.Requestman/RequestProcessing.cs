using System;
using Q101.Requestman.Converters;
using Q101.Requestman.Helpers;
using Q101.Requestman.Models;

namespace Q101.Requestman
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestProcessing
    {
        private readonly RequestHelper _requestHelper;

        private readonly StringToHttpMethodConverter _httpMethodConverter;

        public RequestProcessing(RequestHelper requestHelper,
                                 StringToHttpMethodConverter httpMethodConverter)
        {
            _requestHelper = requestHelper;

            _httpMethodConverter = httpMethodConverter;
        }

        /// <summary>
        /// SendRequest
        /// </summary>
        /// <param name="request"></param>
        public void SendRequest(RequestModel request)
        {
            request.DateTime = DateTime.Now;

            var requestMethod = _httpMethodConverter.Convert(request.Method);

            request.Response = _requestHelper.SendRequest(
                requestMethod,
                request.Url,
                request.Body,
                request.Headers).Result;
        }
    }
}

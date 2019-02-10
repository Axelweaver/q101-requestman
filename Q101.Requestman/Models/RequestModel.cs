using System;

namespace Q101.Requestman.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class RequestModel
    {
        /// <summary>
        /// Id request
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Date Time begin request
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Url address web server
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Http Request Method
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Http Request Headers
        /// </summary>
        public string[] Headers { get; set; }

        /// <summary>
        /// Http Request Body
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Http Response From Web Server
        /// </summary>
        public ResponseModel Response { get; set; }
    }
}

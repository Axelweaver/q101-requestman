using System;

namespace Q101.Requestman.Models
{
    /// <summary>
    /// Response Model For Statistic
    /// </summary>
    public class ResponseModel
    {
        /// <summary>
        /// Response DateTime
        /// </summary>
        public DateTime TimeStamp { get; set; }

        /// <summary>
        /// Http Status Code
        /// </summary>
        public int HttpStatusCode { get; set; }

        /// <summary>
        /// Response content from web server
        /// </summary>
        public string Content { get; set; }
    }
}

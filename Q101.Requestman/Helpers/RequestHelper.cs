using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Q101.Requestman.Models;

namespace Q101.Requestman.Helpers
{
    /// <summary>
    /// Работа с http запросами
    /// </summary>
    public class RequestHelper
    {
        /// <summary>
        /// Послать http запрос
        /// </summary>
        /// <param name="method">Метод</param>
        /// <param name="url">URL адрес</param>
        /// <param name="body">Request body</param>
        /// <param name="headers">Http Request Headers</param>
        /// <returns></returns>
        public async Task<ResponseModel> SendRequest(HttpMethod method,
                                              string url,
                                              string body,
                                              string[] headers)
        {
            using (var httpClient = new HttpClient())
            {
                SetHeaders(httpClient, headers);
                var uri = new Uri(url);

                var requestMessage = new HttpRequestMessage(method, uri);

                if (method != HttpMethod.Get && !string.IsNullOrEmpty(body))
                {
                    requestMessage.Content = new StringContent(body);
                }

                using (var responseMessage = await httpClient.SendAsync(requestMessage))
                {
                    var response = new ResponseModel
                    {
                        HttpStatusCode = (int)responseMessage.StatusCode,
                        TimeStamp = DateTime.Now,
                        Content = await responseMessage.Content.ReadAsStringAsync()
                    };

                    return response;
                }
            }
        }

        /// <summary>
        /// Установить авторизацию
        /// </summary>
        /// <param name="httpClient">http клиент</param>
        /// <param name="username">Логин</param>
        /// <param name="password">Пароль</param>
        private void SetAuth(HttpClient httpClient, string username, string password)
        {
            var phrase = $"{username}:{password}";

            var bytesPhrase = Encoding.UTF8.GetBytes(phrase);

            var base64StringPhrase = Convert.ToBase64String(bytesPhrase);

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64StringPhrase);
        }

        private void SetHeaders(HttpClient httpClient, string[] headersText)
        {
            foreach (var header in headersText)
            {
                if (string.IsNullOrEmpty(header))
                {
                    continue;
                }

                var valueArr = header.Split(':');

                if (valueArr.Length < 2 
                    || string.IsNullOrEmpty(valueArr[0])
                    || string.IsNullOrEmpty(valueArr[1]))
                {
                    continue;
                }

                httpClient.DefaultRequestHeaders.Add(valueArr[0].Trim(), valueArr[1].Trim());
            }
        }
    }
}

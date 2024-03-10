using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TestApiExaminer.APIRequestTypes.RequestPOST
{
    public class RequestPOST
    {
        private string jsonData;

        //public
        public async Task POST(string url, string TypeClassApi, string POST,object Data,string Key)
        {
            //switch (Key)
            //{
            //    case "":


            //    break;
            //}
            using (HttpClient httpClient = new HttpClient())
            {
                // Устанавливаем заголовок Content-Type для указания типа данных JSON
                httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                // Создаем содержимое запроса из JSON-данных
                HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Выполняем POST-запрос
                using (HttpResponseMessage response = await httpClient.PostAsync(url + TypeClassApi + POST, content))
                {
                    // Убеждаемся, что запрос успешно выполнен (код состояния 200)
                    response.EnsureSuccessStatusCode();

                    // Считываем содержимое ответа
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseContent);
                }
            }
        }
    }
}
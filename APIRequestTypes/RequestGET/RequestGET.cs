using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiExaminer.APIRequestTypes.RequestGET
{
    public class RequestGET
    {

        public async Task Get(string url, string TypeClassApi, string Get)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                // Выполняем запрос GET
                using (HttpResponseMessage response = await httpClient.GetAsync(url + TypeClassApi + Get))
                {
                    // Убедимся, что запрос успешно выполнен (код состояния 200)
                    Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

                    // Считываем содержимое ответа
                    string responseContent = await response.Content.ReadAsStringAsync();
                    Debug.WriteLine(responseContent);
                }
            }
        }
    }
}

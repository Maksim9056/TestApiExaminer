

using System.Diagnostics.Metrics;
using System.Reflection;

namespace TestApiExaminer.APIRequestTypes.RequestGET
{
    public class RequestGET
    {
        public async Task<string> Get(string url, string TypeClassApi, string Get)
        {
            string obj ="";
            using (HttpClient httpClient = new HttpClient())
            {
                // Выполняем запрос GET
                using (HttpResponseMessage response = await httpClient.GetAsync(url + TypeClassApi + Get))
                {
                    // Убедимся, что запрос успешно выполнен (код состояния 200)
                    Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

                    // Считываем содержимое ответа
                    string responseContent = await response.Content.ReadAsStringAsync();
                    obj = responseContent;
                    //Debug.WriteLine(responseContent);
                    Debug.WriteLine(responseContent);
                }
            }
            return obj;
        }
    }
}

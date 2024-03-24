
namespace TestApiExaminer.APIRequestTypes.RequestPOST
{
    public class RequestPOST
    {
        private string jsonData;

        //public
        public async Task<string> POST(string url, string TypeClassApi, string POST,object Data,string Key)
        {
            ExamModels.User user;
            string str = "";
            switch (Key)
            {
                case "User":
                    user = (ExamModels.User)Data ;
                    break;
                
            }
            
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
                    Debug.WriteLine(responseContent);
                }
            }
            return str;
        }
    }
}      //switch (Key)
            //{
            //    case "":
            //    break;
            //}

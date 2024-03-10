using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiExaminer.User
{
    public class UserTest
    {
        string TypeClassApi { get; set; } = "Users/";
        public RequestGET RequestGet { get; set; }
        public int idUser { get; set; } = 5;
        public UserTest(RequestGET requestGet)
        {
            RequestGet = requestGet;

        }
        public async Task GetUserAll(string url, string Getid)
        {

         await   RequestGet.Get(url, TypeClassApi, Getid);
       
        }


        public async Task GetUserId(string url, string Getid)
        {
            await RequestGet.Get(url, TypeClassApi, Getid+ idUser);

        }


    }
}
//using (HttpClient httpClient = new HttpClient())
//{
//    // Выполняем запрос GET
//    using (HttpResponseMessage response = await httpClient.GetAsync(url + TypeClassApi + Getid))
//    {
//        // Убедимся, что запрос успешно выполнен (код состояния 200)
//        Assert.AreEqual(System.Net.HttpStatusCode.OK, response.StatusCode);

//        // Считываем содержимое ответа
//        string responseContent = await response.Content.ReadAsStringAsync();
//    }
//}
namespace TestApiExaminer
{
    public class Tests
    {
        //string FillessS{ get; set; } = "C:\\Users\\Maks\\Pictures\\Screenshots\\Снимок экрана 2023-11-25 113905.png";
        string url = "https://localhost:7240/api/";
        public string User = "";
        //Сколько пользователей сколько экзаменов и так далее
        public string Get = "GET";
        public string Getid = "GETId/";
        public string Post = "POST";
        public string PUT = "PUTId/";
        [Test]
        public async Task ApiTest()
        {
            RequestGET RequestGet = new RequestGET();

             UserTest userTest = new UserTest(RequestGet);
             await  userTest.GetUserAll(url, Get);

             await userTest.GetUserId(url, Getid);

            //await userTest.PostUser(url, Post);
        }

    }
   

}

//    MemoryStream memoryStream = new MemoryStream();
//    FileStream fs = new FileStream(Filless, FileMode.Open);

//    fs.CopyTo(memoryStream); 
//    Filles filles = new Filles(0, memoryStream.ToArray());
//    string jsonData = JsonConvert.SerializeObject(filles);
//string jsonData="";
//// Create an instance of HttpClient
//HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

//using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get , url+Filless+ Get    ))
//{
//    request.Content = content;

//    using (HttpResponseMessage response = httpClient.SendAsync(request).Result)
//    {
//        var responseContent = response.Content.ReadAsStringAsync().Result;
//        ////LogTestResult("TestCreateAddress", HttpMethod.Post, url, (int)response.StatusCode);
//        //Console.WriteLine("POST Create Address Response content: " + responseContent);
//        //Console.WriteLine("POST Create Address Status code: " + (int)response.StatusCode);
//        //Assert.AreEqual(200, (int)response.StatusCode); // Ïðîâåðêà óñïåøíîãî ñîçäàíèÿ àäðåñà
//        Assert.AreEqual(200, (int)response.StatusCode);
//    }
//}
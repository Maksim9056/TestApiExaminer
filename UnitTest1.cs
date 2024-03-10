using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Text;
using static System.Reflection.Metadata.BlobBuilder;

namespace TestApiExaminer
{
    public class Tests
    {
        private HttpClient httpClient = new HttpClient();
        string Filless { get; set; } = "C:\\Users\\Maks\\Pictures\\Screenshots\\Снимок экрана 2023-11-25 113905.png";
        string url = "https://localhost:7240/api/";
        public string User = "";

        public string Get = "GET";
        public string Getid = "GETId/";
        public string Post = "POST";
        [Test]
        public async Task Test1()
        {
            MemoryStream memoryStream = new MemoryStream();
            FileStream fs = new FileStream(Filless, FileMode.Open);
            
            fs.CopyTo(memoryStream); 
            Filles filles = new Filles(0, memoryStream.ToArray());
            string jsonData = JsonConvert.SerializeObject(filles);

            // Create an instance of HttpClient
             HttpContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            using (HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get , url))
            {
                request.Content = content;

                using (HttpResponseMessage response = httpClient.SendAsync(request).Result)
                {
                    var responseContent = response.Content.ReadAsStringAsync().Result;
                    //LogTestResult("TestCreateAddress", HttpMethod.Post, url, (int)response.StatusCode);
                    Console.WriteLine("POST Create Address Response content: " + responseContent);
                    Console.WriteLine("POST Create Address Status code: " + (int)response.StatusCode);
                    Assert.AreEqual(200, (int)response.StatusCode); // Ïðîâåðêà óñïåøíîãî ñîçäàíèÿ àäðåñà
                }
            }
        }
        [Serializable]
        public class Filles
        {
            public Filles() { }

            /// <summary>
            /// Id Filles
            /// </summary>
            public int Id { get; set; }

            // Преобразование массива байтов Name в строку Base64 для сериализации в JSON
            //public string NameBase64
            //{
            //    get => Convert.ToBase64String(Name);
            //    set => Name = Convert.FromBase64String(value);
            //}

            //[JsonIgnore] // Игнорирование поля Name при сериализации JSON
            public byte[] Name { get; set; }

            public Filles(int id, byte[] name)
            {
                Id = id;
                Name = name;
            }
        }
        }
}
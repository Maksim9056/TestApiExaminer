namespace TestApiExaminer.User
{
    public class UserTest: StructureUser
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
            string Class    = await   RequestGet.Get(url, TypeClassApi, Getid);
            
        }


        public async Task GetUserId(string url, string Getid)
        {
            string Class = await RequestGet.Get(url, TypeClassApi, Getid+ idUser);

        }

        public async Task PostUser(string url, string Getid)
        {
            await RequestGet.Get(url, TypeClassApi, Getid );

        }


        public void RandomDateUser()
        {
            // Генерация фальшивых данных для пользователей
            var users = new Faker<ExamModels.User>()
                .StrictMode(true)
                .RuleFor(u => u.Id, f => f.IndexFaker)
                .RuleFor(u => u.Name_Employee, f => f.Name.FirstName())
                .RuleFor(u => u.Password, f => f.Internet.Password())
                 .RuleFor(u => u.DataMess, f => f.Date.Past().ToString("F")) // Используем DateTime.Now
                .Ignore(u => u.Id_roles_users) // Игнорирование Id_roles_users
                .RuleFor(u => u.Employee_Mail, f => f.Internet.Email())
                .Generate(10); // Генерация 10 пользователей

        }

        public async Task CheckUser(string url, string Getid, string email, string password)
        {

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
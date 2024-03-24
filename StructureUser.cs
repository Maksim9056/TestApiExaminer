
namespace TestApiExaminer
{
    internal interface StructureUser
    {
        Task GetUserAll(string url, string Getid);
        Task GetUserId(string url, string Getid);
        Task PostUser(string url, string Getid);
        Task CheckUser(string url, string Getid,string email ,string password);

        void RandomDateUser();
    }
}

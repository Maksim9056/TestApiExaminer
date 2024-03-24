
namespace TestApiExaminer
{
    internal interface StructureTest
    {
        Task GetTestAll(string url, string Getid);
        Task GetTestId(string url, string Getid);
        Task PostTest(string url, string Getid);
        void RandomDateTest();
    }
}

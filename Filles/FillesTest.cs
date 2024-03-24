
using TestApiExaminer.APIRequestTypes.RequestGET;
using TestApiExaminer.Filles;

namespace TestApiExaminer.Filles
{
    public class FillesTest: StructureFillesTest
    {      
        public string TypeClassApi { get; set; } = "Filles/";
        public RequestGET RequestGet { get; set; }
        public FillesTest(RequestGET requestGet)
        {
            RequestGet = requestGet;
        }

        public async Task GetFillesTestAll(string url, string Getid)
        {

        }

        public async Task GetFillesTestId(string url, string Getid)
        {

        }

        public async Task PostFillesTest(string url, string Getid)
        {

        }

        public void RandomDateFillesTest()
        {
            throw new NotImplementedException();
        }
    }
}

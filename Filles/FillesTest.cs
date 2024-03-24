
using System.IO;

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
            var File =   ImageData();

            var Filles = File.Result;

        }

        public async Task<ExamModels.Filles> ImageData()
        {
            MemoryStream memoryStream = new MemoryStream();

            FileStream fileStream = new FileStream("9725c85b78837dc18da13a93a400049edc8b49a72 (2)", FileMode.Open);
            await fileStream.CopyToAsync(memoryStream);


            ExamModels.Filles add = new ExamModels.Filles()
            {
                Name = memoryStream.ToArray(),
            };
            return add;

        }
        public void RandomDateFillesTest()
        {

        }
    }
}

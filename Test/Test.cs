namespace TestApiExaminer.Test
{
    public class Test : StructureTest
    {
        public string TypeClassApi { get; set; } = "Tests/";
        public RequestGET RequestGet { get; set; }
        public Test(RequestGET requestGet)
        {
            RequestGet = requestGet;
        }

        public async Task GetTestAll(string url, string Getid)
        {

        }

        public async Task GetTestId(string url, string Getid)
        {

        }
        public async Task PostTest(string url, string Getid)
        {

        }

        public void RandomDateTest()
        {

        }
    }
}

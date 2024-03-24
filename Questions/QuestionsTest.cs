using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApiExaminer.Questions;

namespace TestApiExaminer.Questions
{
    public class QuestionsTest : StructureQuestionsTest
    {   
        public string TypeClassApi { get; set; } = "Questions/";
        public RequestGET RequestGet { get; set; }

        public QuestionsTest(RequestGET requestGet)
        {
            RequestGet = requestGet;
             
        }
        public async Task GetQuestionsTestAll(string url, string Getid)
        {
            await RequestGet.Get(url, TypeClassApi, Getid);
        }

        public async Task GetQuestionsTestId(string url, string Getid)
        {

        }

        public async Task PostQuestionsTest(string url, string Getid)
        {

        }

        public void RandomDateQuestionsTest()
        {

        }
    }
}

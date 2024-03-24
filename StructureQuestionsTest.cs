using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiExaminer
{
    internal interface StructureQuestionsTest
    {
        Task GetQuestionsTestAll(string url, string Getid);
        Task GetQuestionsTestId(string url, string Getid);
        Task PostQuestionsTest(string url, string Getid);
        void RandomDateQuestionsTest();
    }
}

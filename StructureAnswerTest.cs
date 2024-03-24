using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiExaminer
{
    internal interface StructureAnswerTest
    {
        Task GetAnswerTestAll(string url, string Getid);
        Task GetAnswerTestId(string url, string Getid);
        Task PostAnswerTest(string url, string Getid);
        void RandomDateAnswerTest();
    }
}

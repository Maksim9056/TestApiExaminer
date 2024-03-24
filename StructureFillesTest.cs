using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiExaminer
{
    internal interface StructureFillesTest
    {
        Task GetFillesTestAll(string url, string Getid);
        Task GetFillesTestId(string url, string Getid);
        Task PostFillesTest(string url, string Getid);
        void RandomDateFillesTest();
    }
}

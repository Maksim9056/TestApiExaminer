using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApiExaminer
{
    internal interface StructureUser
    {
        Task GetUserAll(string url, string Getid);
        Task GetUserId(string url, string Getid);
        Task PostUser(string url, string Getid);

        void RandomDateUser();
    }
}

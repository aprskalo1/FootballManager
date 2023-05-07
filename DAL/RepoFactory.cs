using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RepoFactory
    {
        public static IRepo GetRepo() => new FileRepo();
    }
}

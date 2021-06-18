using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetupSearch
{
    public class MeetupRepo
    {
        public List<string> getRegistered() {
            List<string> r = new List<string>();
            r.Add("azure");
            r.Add("aws");
            r.Add("ML");
            return r;
        }
    }
}

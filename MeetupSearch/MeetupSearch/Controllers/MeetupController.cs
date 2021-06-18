using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetupSearch.Model;
using MeetupSearch;
namespace MeetupSearch.Controllers
{
    
    
    
    public class MeetupController : ControllerBase
    {
        string[] registered = { "azure", "aws", "ML" };
        string search = "ML";
        
        [Route("Meetup/search")]
        public List<string> searchByName(string search)
        {

            List<string> l = new List<string>();
            if (!String.IsNullOrEmpty(search))
            {
                for(int i = 0; i < registered.Length; i++)
                {
                    if (registered[i].Equals(search))
                    {
                        l.Add(search);
                        return l;
                    }
                }
            }
            l.Add("Not registered to " + search);
            return l;
        }
        string mName = "ML";

        [Route("Meetup/register")]
        public List<string> register(string mName)
        {

            List<string> l = new List<string>();
            if (!String.IsNullOrEmpty(search))
            {
                for (int i = 0; i < registered.Length; i++)
                {
                    l.Add(registered[i]);
                }
                l.Add(mName);
            }
            return l;
        }

    }
}

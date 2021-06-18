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
    
    [ApiController]
    [Route("[controller]")]
    public class MeetupController : ControllerBase
    {
        string[] registered = { "azure", "aws", "ML" };
        string search = "ML";
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
            l.Add(search + " Not found");
            return l;
        }

    }
}

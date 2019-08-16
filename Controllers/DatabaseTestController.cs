using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace NataliaMusic.Controllers
{
    [Route("api/[controller]")]
    public class DatabaseTestController : Controller
    {

        [HttpGet("[action]")]
        public string ConnectionTest()
        {
            var student_list = DatabaseConnect.GetDatabaseStudents();

            return JsonConvert.SerializeObject(student_list);
        }

    }
}

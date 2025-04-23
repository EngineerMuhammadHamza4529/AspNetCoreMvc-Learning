using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace project_2_webapi_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsAPIController : ControllerBase
    {

//       Your FruitsAPIController is a simple Web API controller in ASP.NET Core that provides two endpoints:

         //GET api/FruitsAPI - Returns a list of fruits.

         //GET api/FruitsAPI/{id
         //    } - Returns a fruit by its index.
        public List<string> Fruits = new List<string>()
        {
            "apple",
            "mango",
            "grapes",
            "cheery"
        };


        [HttpGet]
        public List<string> GetFruits()
        {
            return Fruits;
        }

        [HttpGet("{id}")]
        public string GetFruitsByIndex(int id)
        {
            return Fruits.ElementAt(id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1_API.Models;
using WebApplication1_API.Services;

namespace WebApplication1_API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class HomeController : Controller
    {
        MainServices MainSV = new MainServices();

        [HttpGet]
        [Route("Test/Get")]
        public string Index()
        {
            return "OK";
        }

        [HttpPost]
        [Route("Test/Post")]
        public string TestPost(string id)
        {
            string strreturn = "";
            if (string.IsNullOrEmpty(id))
            {
                strreturn = "Data is null or Empty";
            }
            else
            {
                strreturn = "Data is " + id;
            }
            return strreturn;
        }
        [HttpPost]
        [Route("Test/Services")]
        public bool TestServices(MainModel data)
        {
            return MainSV.TestServices(data);
        }
        [HttpPost]
        [Route("Test/CheckPUBG")]
        public async Task<ResponseModel> CheckPUBG(MainModel data)
        {
            ResponseModel response = new ResponseModel();

            response.status = 200;
            response.success = true;
            response.message = null;
            response.error = null;
            response.errorCode = null;
            response.data = await MainSV.CheckPUBG(data);

            return response;
        }
        [HttpPost]
        [Route("Test/ListModel")]
        public async Task<IActionResult> ListModel(MainModel data)
        {
            ResponseModel response = new ResponseModel();
            try
            {
                response.status = 200;
                response.success = true;
                response.message = null;
                response.error = null;
                response.errorCode = null;
                response.data = await MainSV.ListModel(data);
                return Ok(response);

            }
            catch (Exception ex)
            {
                response.status = ex.HResult;
                response.success = false;
                response.message = ex.Message;
                response.error = ex.StackTrace;
                return BadRequest(response);

            }
        }

        [HttpGet]
        [Route("Product/ListProducts")]
        public async Task<IActionResult> ListProducts()
        {
            ResponseModel response = new ResponseModel();
            try
            {
                response.status = 200;
                response.success = true;
                response.message = null;
                response.error = null;
                response.errorCode = null;
                response.data = await MainSV.ListProducts();
                return Ok(response);

            }
            catch (Exception ex)
            {
                response.status = ex.HResult;
                response.success = false;
                response.message = ex.Message;
                response.error = ex.StackTrace;
                return BadRequest(response);

            }
        }
    }
}

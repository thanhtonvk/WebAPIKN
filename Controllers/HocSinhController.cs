using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIKN.Models;

namespace WebAPIKN.Controllers
{
    public class HocSinhController : ApiController
    {
        List<HocSinh> hocSinhs = new List<HocSinh>() { new HocSinh() { ID = 1, Name = "Huong", Age = 20 }, new HocSinh() { ID = 2, Name = "Tondz", Age = 21 } };
        [HttpGet]
        [Route("api/hocsinh/getdshocsinh")]
        public IEnumerable<HocSinh> GetHocSinhs()
        {
            return hocSinhs;
        }
        [HttpGet]
        [Route("api/hocsinh/gethocsinhbyid")]
        //param
        public HocSinh GetHocSinhByID(int ID)
        {
            return hocSinhs.FirstOrDefault(x => x.ID == ID);
        }
        [HttpPost]
        [Route("api/hocsinh/themhocsinh")]
        public IEnumerable<HocSinh> ThemHocSinh([FromBody] HocSinh hocSinh)
        {
            hocSinhs.Add(hocSinh);
            return hocSinhs;
        }
        [HttpPut]
        [Route("api/hocsinh/suahocsinh")]
        public IEnumerable<HocSinh> SuaHocSinh([FromBody] HocSinh hocSinh)
        {
            var model = hocSinhs.FirstOrDefault(x => x.ID == hocSinh.ID);
            hocSinhs.Remove(model);
            hocSinhs.Add(hocSinh);
            return hocSinhs;
        }
        [HttpDelete]
        [Route("api/hocsinh/xoahocsinh")]
        public IEnumerable<HocSinh> XoaHocSinh(int ID)
        {

            var model = hocSinhs.FirstOrDefault(x => x.ID == ID);
            hocSinhs.Remove(model);
            return hocSinhs;
        }


    }
}

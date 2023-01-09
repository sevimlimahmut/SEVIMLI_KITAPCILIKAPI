using SEVIMLI_KITAPCILIKAPI.Models.DTO;
using SEVIMLI_KITAPCILIKAPI.Models.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Web.Http;

namespace SEVIMLI_KITAPCILIKAPI.Controllers
{
    public class DefaultController : ApiController
    {
        Entities db = null;
        public DefaultController()
        {
            db = new Entities();
        }
        [AllowAnonymous]
        [HttpGet]
        [Route("api/kitap/getall")]
        public List<Class1> GetListOfSEVİMLİ_KİTAPCİLİK()
        {
            List<Class1> getkitaplist = db.SEVİMLİ_KİTAPCİLİK.Select(x => new Class1()
            {

                _id = x.İD,
                _eser = x.ESERİN_ADİ,
                _yazar = x.ESERİN_YAZARI,
                _konum = x.KONUMU,
                _adet = x.ADEDİ,
                _fiyat= (int)x.FİYATİ




            }).ToList();
            return getkitaplist;
        }
    }
}

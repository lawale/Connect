using AutoMapper;
using Connect.Controllers.Resources;
using Connect.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Connect.Controllers
{
    public class VocationsController : ApiController
    {
        private readonly ApplicationDbContext context;

        public VocationsController()
        {

            context = new ApplicationDbContext();
        }

        

        //[HttpGet]
        //public IEnumerable<VocationResource> GetVocations()
        //{
        //    var vocations = context.Vocations.ToList();
        //    var vocationResources = Mapper.Map< List<Vocation>,List <VocationResource>>(vocations);
        //    return vocationResources;
        //}

        [HttpGet]
        public IEnumerable<Vocation> GetVocations()
        {
            var vocations = context.Vocations.Include(x => x.Category).ToList();
            return vocations;
        }
        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }

    }
}

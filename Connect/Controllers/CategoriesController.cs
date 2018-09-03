using AutoMapper;
using Connect.Controllers.Resources;
using Connect.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Connect.Controllers
{
    public class CategoriesController : ApiController
    {
        private readonly ApplicationDbContext context;

        public CategoriesController()
        {
            context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
            base.Dispose(disposing);
        }

        [HttpGet]
        public IEnumerable<Category> GetCategories()
        {
            var categories = context.Categories.Include(x => x.Vocations).ToList();
            return categories;
        }
    }
}

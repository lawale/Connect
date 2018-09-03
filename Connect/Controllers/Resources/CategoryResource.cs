using Connect.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Connect.Controllers.Resources
{
    public class CategoryResource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<VocationResource> Vocations { get; set; }

        public CategoryResource()
        {
            Vocations = new Collection<VocationResource>();
        }
    }
}
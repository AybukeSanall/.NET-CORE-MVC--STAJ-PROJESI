using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StajProjesi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajProjesi.Data
{
    public class UserContext:IdentityDbContext<AppUser>
    {

        public UserContext(DbContextOptions<UserContext> options)
    :   base(options)
        {
        }



        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=BIDB002;initial catalog=StajProjesiIdentity; integrated security=true");
        //    base.OnConfiguring(optionsBuilder);
        //}


    }
}

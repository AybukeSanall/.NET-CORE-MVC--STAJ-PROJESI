using Microsoft.AspNetCore.Identity;
using StajProjesi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StajProjesi
{
    public class IdentityInitializer
    {

       
        public  void OlusturAdminAsync(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            AppUser appUser = new AppUser
            {
                FirstName="Aybuke",
                SurName="Sanal",
                UserName="aybuk"
            };

            var usr =  userManager.FindByNameAsync("aybuke"); 

            //if (userManager.FindByNameAsync("Aybuke").Result == null)  
            if (usr.Status== TaskStatus.Faulted)  
            {
                var identityResult = userManager.CreateAsync(appUser,"123Qwe!!");

                //if (!identityResult.Succeeded)
                //{
                //    return;
                //}

                //var identityResult = userManager.CreateAsync(appUser,"1").Result;
            }
            //if (roleManager.FindByNameAsync("Admin").Result == null)
            //{
            //    IdentityRole role = new IdentityRole
            //    {
            //        Name = "admin"
            //    };
            //  var identityResult=roleManager.CreateAsync(role).Result;
            //    userManager.AddToRoleAsync(appUser,role.Name);
            //}

        }
    }
}

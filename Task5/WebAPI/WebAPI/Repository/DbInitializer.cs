using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.DbModel;

namespace WebAPI.Repository
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {

            localDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<localDbContext>();

            if (!context.Users.Any())
            {
                for (int i = 1; i <= 100; i++)
                {
                    context.Users.Add(new Users
                    {
                        FirstName = "Martyna" + i.ToString(),
                        LastName = "Paszkowska" + i.ToString()
                    }
                    ); ;

                }
            }

            context.SaveChanges();
        }
    }
}

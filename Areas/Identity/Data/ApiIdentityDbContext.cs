using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FriendsAppApi.Areas.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FriendsAppApi.Areas.Identity.Data
{
    public class ApiIdentityDbContext : IdentityDbContext
    {
        public ApiIdentityDbContext(DbContextOptions<ApiIdentityDbContext> options) : base(options)
        {

        }

        public DbSet <ApiUser> ApiUsers { get; set; }
    }
}

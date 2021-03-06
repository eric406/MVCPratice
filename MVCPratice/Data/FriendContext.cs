using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCPratice.Models;
using MVCPratice.Models.HtmlHelpers;

namespace MVCPratice.Data
{
    public class FriendContext : DbContext
    {
        public FriendContext (DbContextOptions<FriendContext> options)
            : base(options)
        {
        }

        public DbSet<MVCPratice.Models.Friend> Friend { get; set; }

        public DbSet<MVCPratice.Models.Student> Student { get; set; }

        public DbSet<MVCPratice.Models.HtmlHelpers.User> User { get; set; }
    }
}

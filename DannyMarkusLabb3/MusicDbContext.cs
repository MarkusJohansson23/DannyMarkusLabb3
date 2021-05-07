using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DannyMarkusLabb3
{
    public partial class MusicDbContext : DbContext
    {
        public MusicDbContext()
        {

        }
        public MusicDbContext(DbContextOptions<MusicDbContext> options) : base(options)
        {
        }
    }
}

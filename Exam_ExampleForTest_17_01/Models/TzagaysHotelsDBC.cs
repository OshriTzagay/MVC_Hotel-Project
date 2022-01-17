using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Exam_ExampleForTest_17_01.Models
{
    public partial class TzagaysHotelsDBC : DbContext
    {
        public TzagaysHotelsDBC()
            : base("name=TzagaysHotelsDBC")
        {
        }
        public DbSet<Guest> Guests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace LatihanMVVM
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    class wpfcontext : DbContext
    {
        public DbSet<ItemPenjualan> DaftarItemPenjualan { get; set; }
    }
}
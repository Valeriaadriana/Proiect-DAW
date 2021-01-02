using DAWProject.Models;
using Microsoft.EntityFrameworkCore;

namespace DAWProject.Data
{
    public class DawAppContext : DbContext
    {
        public DawAppContext(DbContextOptions<DawAppContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Product>()
                .HasOne(p => p.ProductType)
                .WithMany(pt => pt.Products)
                .HasForeignKey(p => p.ProductTypeId)
                .OnDelete(DeleteBehavior.SetNull);

            builder.Entity<Order>()
                .HasOne(o => o.Invoice)
                .WithOne(i => i.Order)
                .HasForeignKey<Invoice>(i => i.OrderId);
            
            builder.Entity<Order>()
                .HasOne(o => o.DeliveryType)
                .WithMany(dt => dt.Orders)
                .HasForeignKey(p => p.DeliveryTypeId)
                .OnDelete(DeleteBehavior.SetNull);
            
            builder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);
            
            builder.Entity<OrderProduct>()
                .HasKey(et => new { et.OrderId, et.ProductId });
            
            builder.Entity<OrderProduct>()
                .HasOne(op => op.Order)
                .WithMany(user => user.Products)
                .HasForeignKey(op => op.OrderId);  
             
            builder.Entity<OrderProduct>()
                .HasOne(op => op.Product)
                .WithMany(p => p.Orders)
                .HasForeignKey(op => op.ProductId);

            base.OnModelCreating(builder);
        }

    }
}

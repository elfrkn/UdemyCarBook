using Microsoft.EntityFrameworkCore;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Persistence.Context
{
    public class CarBookContext : DbContext

    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;initial Catalog=UdemyCarBook;integrated Security=true;TrustServerCertificate=true;");
        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarDescription> CarDescriptions { get; set; }
        public DbSet<CarFeature> CarFeatures { get; set; }
        public DbSet<CarPricing> CarPricings { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<FooterAddress> FooterAddresses { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Pricing> Pricings { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<TagCloud> TagClouds { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<RentACar> RentACars { get; set; }
        public DbSet<RentACarProcess> RentACarProcesses { get; set; }

        //Bir tablo içerisinde iki farklı Id yi karşı tarafın tek Id sı ile birleştirmek için kullanılıyor.Burada Rezervasyon tablosundaki PickUpLocationID ve DroppOffLocationID yi Location tablosundaki LocationID ile eşleştiriyoruz/birleştiriyoruz.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Reservation>()
                .HasOne(x => x.PickUpLocation) // pickuplocationu alıyoruz.
                .WithMany(y => y.PickUpReservation) // pickuprezervation ile iliskilendirdik location tablosundaki.
                .HasForeignKey(z => z.PickUpLocationID) // pickuplocationID sutunü ile ilişkilendirdik.
                .OnDelete(DeleteBehavior.ClientSetNull); // Silindiğinde hata vermemesi için kullandık.

            modelBuilder.Entity<Reservation>()
                .HasOne(x => x.DropOffLocation)
                .WithMany(y => y.DropOffReservation)
                .HasForeignKey(z => z.DropOffLocationID)
                .OnDelete(DeleteBehavior.ClientSetNull);

        }

    }
}

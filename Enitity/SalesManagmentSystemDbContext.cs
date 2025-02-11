using Microsoft.EntityFrameworkCore;
using SalesManagementSystem.DATA.Configurations;
using SalesManagementSystem.DATA.Entites;

namespace SalesManagementSystem.DATA
{
    public class SalesManagmentSystemDbContext : DbContext
    { 
        public DbSet<Category>? Categorys { get; set; }   
        public DbSet<Order>? Orders { get; set; }
        public DbSet<OrderItem>? OrderItems { get; set; }
        public DbSet<OrderStatus>? OrderStatus { get; set; } // დავამატე Entites. რადგან მეორე OnModelCreating  დააერორა
        public DbSet<PaymentType>? PaymentTypes { get; set; }
        public DbSet<Person>? Persons { get; set; }  
        public DbSet<Product>? Products { get; set; }
        public DbSet<Rating>? Ratings { get; set; }
        public DbSet<Role>? Roles { get; set; }
        public DbSet<User>? Users { get; set; }
        public DbSet<PersonType>? PersonTypes { get; set; }


        public SalesManagmentSystemDbContext()
        {
        
        }

        public SalesManagmentSystemDbContext(DbContextOptions<SalesManagmentSystemDbContext>contect) : base(contect) 
        {
        
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(); //we need this for migration

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new CategoryConfiguaration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderItemConfiguration());
            modelBuilder.ApplyConfiguration(new OrderStatusConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguation());
            modelBuilder.ApplyConfiguration(new RatingConfiguration());
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration()); 
            modelBuilder.ApplyConfiguration(new PersonTypeConfiguration());  

        }



        //  მეორე OnModelCreating დამატების მერე დააერორა  დააერორა
        //სხვაგანაც დავამატე და იქ საერთოთ არმუშაობდა
        //შეიძლება ამ seeding-ების ის წაშლაც ..
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    //rating seeding
        //    modelBuilder.Entity<Rating>().HasData(


        //        new Rating()
        //        {
        //            RatingId = 1,
        //            RatingA = 2
        //        },

        //        new Rating()
        //        {
        //            RatingId = 2,
        //            RatingA = 2.5
        //        },

        //        new Rating()
        //        {
        //            RatingId = 3,
        //            RatingA = 3
        //        },

        //        new Rating()
        //        {
        //            RatingId = 4,
        //            RatingA = 3.5
        //        },

        //        new Rating()
        //        {
        //            RatingId = 5,
        //            RatingA = 4
        //        },

        //        new Rating()
        //        {
        //            RatingId = 6,
        //            RatingA = 4.5
        //        },

        //        new Rating()
        //        {
        //            RatingId = 7,
        //            RatingA = 5
        //        },

        //        new Rating()
        //        {
        //            RatingId = 8,
        //            RatingA = 5.5
        //        },

        //        new Rating()
        //        {
        //            RatingId = 9,
        //            RatingA = 6
        //        },

        //        new Rating()
        //        {
        //            RatingId = 10,
        //            RatingA = 6.5
        //        },

        //        new Rating()
        //        {
        //            RatingId = 11,
        //            RatingA = 7
        //        },

        //        new Rating()
        //        {
        //            RatingId = 12,
        //            RatingA = 7.5
        //        },

        //        new Rating()
        //        {
        //            RatingId = 13,
        //            RatingA = 8
        //        },

        //        new Rating()
        //        {
        //            RatingId = 14,
        //            RatingA = 8.5
        //        },

        //        new Rating()
        //        {
        //            RatingId = 15,
        //            RatingA = 9
        //        },

        //        new Rating()
        //        {
        //            RatingId = 16,
        //            RatingA = 9.5
        //        },

        //        new Rating()
        //        {
        //            RatingId = 17,
        //            RatingA = 10
        //        }


        //    );
        //    modelBuilder.Entity<Category>().HasData(

        //        new Category()
        //        {
        //            CategoryId = 1,
        //            CategoryName = "Phones",
        //            Description = "All type of Phone Brands"
        //        },
        //        new Category()
        //        {
        //            CategoryId = 2,
        //            CategoryName = "Leptops",
        //            Description = "this category is about Leptops ",
        //            //შემიძლია თუარა კატეგორიას კიდე კატეგორიები შევუქმნა და როგორ
        //        },

        //        new Category()
        //        {
        //            CategoryId = 3, 
        //            CategoryName = "Gaming",
        //            Description = "this category is about Gaming ,Consoles and Games"
        //        },
        //        new Category()
        //        {
        //            CategoryId= 4,
        //            CategoryName = "TV",
        //            Description = "All type of TV Brands ,All Resulution and other stuff"
        //        }


        //        //i need more categorys 





        //        );

        //    modelBuilder.Entity<PaymentType>().HasData(
        //        new PaymentType()
        //        {
        //            PaymentTypeId = 1,
        //            PaymentName = "Card"
        //        },
        //        new PaymentType()
        //        {
        //            PaymentTypeId = 2,
        //            PaymentName="Cash"
        //        },
        //        new PaymentType()
        //        {
        //            PaymentTypeId = 3,
        //            PaymentName = "Coupon"
        //        }

        //        );

        //    modelBuilder.Entity<Entites.OrderStatus>().HasData(

        //        new Entites.OrderStatus()
        //        { 
        //            OrderStatusId = 1,
        //            OrderStatusA = "Pending "
        //        },

        //        new Entites.OrderStatus()
        //        {
        //            OrderStatusId= 2,
        //            OrderStatusA = "Completed "
        //        },

        //        new Entites.OrderStatus()
        //        { 
        //            OrderStatusId= 3,
        //            OrderStatusA= "Cancelled " 
        //        }

        //        );



        //    //როგორ ავამუშვო Coupon ?? ასევე მჭირდება ცალკე კლასი სადაც
        //    //უშვალოდ ფუნქციას გავაკეთებ და invoke ით გამოვიძახებ controler -ში

        //    //Coupon Seeding
        //    modelBuilder.Entity<Coupon>().HasData(
        //        new Coupon()
        //        {
        //            CouponId = 1,
        //            CouponCode = "CrudAcademyCRUD",
        //            DiscountAmount = 250,
        //            IsActive = true,
        //        },

        //        new Coupon()
        //        {
        //            CouponId= 2,
        //            CouponCode ="ComicSolvencyGoat",
        //            DiscountAmount = 120.80,
        //            IsActive = true,
        //        },

        //        new Coupon()
        //        {
        //            CouponId= 3,
        //            CouponCode ="Coupon2025",
        //            DiscountAmount = 100 ,
        //            IsActive = false,
        //        }



        //        );
        //    //Coupon Seeding
        //    modelBuilder.Entity<PersonType>().HasData(
        //        new PersonType
        //        {
        //            PersontypeId = 1,
        //            PersonTypeName = "",
        //            PersonTypeDescription = ""

        //        },

        //        new PersonType
        //        {
        //            PersontypeId = 2,
        //            PersonTypeName = "",
        //            PersonTypeDescription = ""
        //        },

        //        new PersonType
        //        {
        //            PersontypeId = 3 ,
        //            PersonTypeName = "",
        //            PersonTypeDescription =""
        //        }



                                
                    
        //        );

        //    //Role Seeding
        //    modelBuilder.Entity<Role>().HasData(

        //      new Role
        //      {

        //      RoleId = 1,
        //      RoleName = "",
        //      RoleDescription = ""

        //      },

        //      new Role
        //      {

        //      RoleId =2,
        //      RoleName = "",
        //      RoleDescription = ""


        //      },

        //      new Role
        //      {
        //          RoleId = 3,
        //          RoleName = "",
        //          RoleDescription = ""
        //      }





        //        );
        
        //}

    }
}

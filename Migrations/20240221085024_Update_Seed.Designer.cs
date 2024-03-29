﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using RestaurantAPI.Data;

#nullable disable

namespace RestaurantAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240221085024_Update_Seed")]
    partial class Update_Seed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("RestaurantAPI.Models.CartItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("MenuItemId")
                        .HasColumnType("integer");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.Property<int>("ShoppingCartId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("ShoppingCartId");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("RestaurantAPI.Models.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("PriceInUSD")
                        .HasColumnType("double precision");

                    b.Property<string>("SpecialTag")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("MenuItems");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Sopas",
                            Description = "Este plato presenta una variedad de vegetales cocinados en un caldo sabroso. Es una opción saludable y nutritiva, a la vez reconfortante y deliciosa.",
                            Image = "images/items/vinitha-v-aApxuprXL_4-unsplash.jpg",
                            Name = "Sopa de Verduras",
                            PriceInUSD = 8.9900000000000002,
                            SpecialTag = "Especialidad de la casa"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Ensaladas",
                            Description = "Patatas rojas asadas, palta, frijoles negros y col rizada cruda se mezclan con una deliciosa vestidura de limón en esta ensalada de remolacha roja vegetariana.",
                            Image = "images/items/kostiantyn-vierkieiev-86L7IAWiNLE-unsplash.jpg",
                            Name = "Ensalada de Remolacha Roja con Crema Vistaña",
                            PriceInUSD = 12.99,
                            SpecialTag = ""
                        },
                        new
                        {
                            Id = 3,
                            Category = "Ensaladas",
                            Description = "Cargada con nueces, así como frutas secas y frescas, esta ensalada vegetariana es ideal como un delicioso almuerzo ligero.",
                            Image = "images/items/monika-grabkowska-pCxJvSeSB5A-unsplash.jpg",
                            Name = "Ensalada de Lechuga Rallada con Crema Vistaña y Miel",
                            PriceInUSD = 9.4900000000000002,
                            SpecialTag = ""
                        },
                        new
                        {
                            Id = 4,
                            Category = "Platos principales",
                            Description = "Los vegetales asados, las frijoles sabrosos y la crema de palta limón-ajo se colocan sobre una cama de arroz de cilantro-limón en este delicioso burrito bowl vegetariano.",
                            Image = "images/items/eugen-kucheruk-TvcjBk5y0wU-unsplash.jpg",
                            Name = "Burrito Vegetariano con Crema de Palta",
                            PriceInUSD = 11.49,
                            SpecialTag = "Mejor valorado"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Platos principales",
                            Description = "Finado con una deliciosa salsa de curry verde, este plato vegetal es el más saludable que jamás hayas probado.",
                            Image = "images/items/pirata-studio-film-78t6dVjtJl8-unsplash.jpg",
                            Name = "Curry Verde para Buda",
                            PriceInUSD = 13.99,
                            SpecialTag = ""
                        },
                        new
                        {
                            Id = 6,
                            Category = "Guarniciones",
                            Description = "La ratatouille -una combinación clásica de verduras tardías veranos-, cocinada hasta la perfección, es un ideal compañero para la polenta de queso de cabra cremoso.",
                            Image = "images/items/max-griss-x_ObRUc51S0-unsplash.jpg",
                            Name = "Polenta de Queso de Cabra con Ratatouille",
                            PriceInUSD = 15.99,
                            SpecialTag = "Especialidad del Chef"
                        },
                        new
                        {
                            Id = 7,
                            Category = "Ensaladas",
                            Description = "Esta ensalada cargada está llena hasta el borde y es ideal para comer.",
                            Image = "images/items/sonny-mauricio-yhc4pSbl01A-unsplash.jpg",
                            Name = "Ensalada Curry con Quinoa",
                            PriceInUSD = 10.49,
                            SpecialTag = ""
                        },
                        new
                        {
                            Id = 8,
                            Category = "Sopas",
                            Description = "Suave y brillantemente colorido, este caldo vegano curry es profundamente amado en nuestros hogares.",
                            Image = "images/items/matthew-hamilton-RA4mwm9_jKA-unsplash.jpg",
                            Name = "Caldo de Calabaza con Curry",
                            PriceInUSD = 8.9900000000000002,
                            SpecialTag = ""
                        },
                        new
                        {
                            Id = 9,
                            Category = "Ensaladas",
                            Description = "Vestida con una deliciosa vestidura limón-cebolla, las semillas de girasol crudas y las frambuesas secas dan vida a esta receta de ensalada primaveral.",
                            Image = "images/items/farhad-ibrahimzade-59lfMHMZugY-unsplash.jpg",
                            Name = "Ensalada Primaveral con Trigo y Vistaña Limón-Cebolla",
                            PriceInUSD = 12.49,
                            SpecialTag = ""
                        },
                        new
                        {
                            Id = 10,
                            Category = "Sopas",
                            Description = "La sopa cremosa hecha con manzanas dulces, ajo y romero es la perfecta sopa cómoda para el otoño.",
                            Image = "images/items/cala-w6ftFbPCs9I-unsplash.jpg",
                            Name = "Caldo de Calabaza con Manzanas",
                            PriceInUSD = 14.99,
                            SpecialTag = ""
                        },
                        new
                        {
                            Id = 11,
                            Category = "Platos principales",
                            Description = "Mac & Cheese es un plato vegetariano totalmente cómodo. Está listo en solo quince minutos.",
                            Image = "images/items/tina-witherspoon-A8Gze997X-E-unsplash.jpg",
                            Name = "Mac & Cheese",
                            PriceInUSD = 9.9900000000000002,
                            SpecialTag = ""
                        },
                        new
                        {
                            Id = 12,
                            Category = "Sopas",
                            Description = "Ramen Noodles Sésamo-Ajo es una versión única del clásico plato de fideos ramen, con sabores de sésamo y ajo.",
                            Image = "images/items/ikhsan-baihaqi-RwAXb8Hv_sU-unsplash.jpg",
                            Name = "Ramen Sésamo-Ajo con Fideos",
                            PriceInUSD = 7.0,
                            SpecialTag = ""
                        },
                        new
                        {
                            Id = 13,
                            Category = "Guarniciones",
                            Description = "Vuelve siempre al queso asado. Almuerzo, cena o merienda -este es un plato vegetariano totalmente cómodo para todos los momentos del día.",
                            Image = "images/items/asnim-ansari-SqYmTDQYMjo-unsplash.jpg",
                            Name = "Queso asado",
                            PriceInUSD = 5.9900000000000002,
                            SpecialTag = "Mejor valorado"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Platos principales",
                            Description = "La salsa de soja-limón-chile picante hace que estos rollitos vegetarianos sean simplemente deliciosos. ",
                            Image = "images/items/max-griss-Spp1G283dow-unsplash.jpg",
                            Name = "Rollos De Tofu ",
                            PriceInUSD = 10.49,
                            SpecialTag = "Especialidad del Chef"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Guarniciones",
                            Description = "Sabrosa y extraordinariamente nutritiva, esta receta de salsa de nueces y lentejas Boloñesa es ideal para los comensales vegetarianos.",
                            Image = "images/items/homescreenify-sA3wymYqyaI-unsplash.jpg",
                            Name = "Salsa de Nueces y Lentejas Boloñesa",
                            PriceInUSD = 10.99,
                            SpecialTag = "Especialidad de la casa"
                        });
                });

            modelBuilder.Entity("RestaurantAPI.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderDetailId"));

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("MenuItemId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderHeaderId")
                        .HasColumnType("integer");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderHeaderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("RestaurantAPI.Models.OrderHeader", b =>
                {
                    b.Property<int>("OrderHeaderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderHeaderId"));

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContactEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContactName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ContactPhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<double>("OrderTotal")
                        .HasColumnType("double precision");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("StripePaymentIntentId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("TotalItems")
                        .HasColumnType("integer");

                    b.HasKey("OrderHeaderId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("OrderHeaders");
                });

            modelBuilder.Entity("RestaurantAPI.Models.ShoppingCart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("ShoppingCarts");
                });

            modelBuilder.Entity("RestaurantAPI.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RestaurantAPI.Models.CartItem", b =>
                {
                    b.HasOne("RestaurantAPI.Models.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.ShoppingCart", null)
                        .WithMany("CartItems")
                        .HasForeignKey("ShoppingCartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("RestaurantAPI.Models.OrderDetails", b =>
                {
                    b.HasOne("RestaurantAPI.Models.MenuItem", "MenuItem")
                        .WithMany()
                        .HasForeignKey("MenuItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RestaurantAPI.Models.OrderHeader", null)
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderHeaderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MenuItem");
                });

            modelBuilder.Entity("RestaurantAPI.Models.OrderHeader", b =>
                {
                    b.HasOne("RestaurantAPI.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("RestaurantAPI.Models.OrderHeader", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("RestaurantAPI.Models.ShoppingCart", b =>
                {
                    b.Navigation("CartItems");
                });
#pragma warning restore 612, 618
        }
    }
}

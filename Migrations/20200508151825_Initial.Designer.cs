﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using browsersqlserver.database.windows;

namespace BrowserAdventures.Migrations
{
    [DbContext(typeof(BrowserAdventureContext))]
    [Migration("20200508151825_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BrowserAdventures.Models.AccessPoint", b =>
                {
                    b.Property<int>("AccessPointID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("From")
                        .HasColumnType("int");

                    b.Property<int>("To")
                        .HasColumnType("int");

                    b.HasKey("AccessPointID");

                    b.ToTable("AccessPoint");
                });

            modelBuilder.Entity("BrowserAdventures.Models.AccessRequirements", b =>
                {
                    b.Property<int>("AccessRequirementsID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessPointID")
                        .HasColumnType("int");

                    b.Property<string>("ClosedMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpenMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RequiredItemID")
                        .HasColumnType("int");

                    b.HasKey("AccessRequirementsID");

                    b.ToTable("AccessRequirements");
                });

            modelBuilder.Entity("BrowserAdventures.Models.Consumable", b =>
                {
                    b.Property<int>("ConsumableID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConsumeMessage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Heals")
                        .HasColumnType("int");

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.HasKey("ConsumableID");

                    b.ToTable("Consumables");
                });

            modelBuilder.Entity("BrowserAdventures.Models.Enemy", b =>
                {
                    b.Property<int>("EnemyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnemyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnemyDie")
                        .HasColumnType("int");

                    b.Property<int>("EnemyExperience")
                        .HasColumnType("int");

                    b.Property<int>("EnemyHealth")
                        .HasColumnType("int");

                    b.Property<int>("EnemyModifier")
                        .HasColumnType("int");

                    b.Property<int>("EnemyMultipler")
                        .HasColumnType("int");

                    b.Property<string>("EnemyName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyID");

                    b.ToTable("Enemy");
                });

            modelBuilder.Entity("BrowserAdventures.Models.FightLog", b =>
                {
                    b.Property<int>("FightLogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DamageDone")
                        .HasColumnType("int");

                    b.Property<string>("Entry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EntryType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScreenEnemyID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("FightLogID");

                    b.ToTable("FightLogs");
                });

            modelBuilder.Entity("BrowserAdventures.Models.InventoryItem", b =>
                {
                    b.Property<int>("InventoryItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("ScreenItemID")
                        .HasColumnType("int");

                    b.Property<int>("UserID")
                        .HasColumnType("int");

                    b.HasKey("InventoryItemID");

                    b.HasIndex("ItemID");

                    b.HasIndex("UserID");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("BrowserAdventures.Models.Item", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Container")
                        .HasColumnType("bit");

                    b.Property<string>("ItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemTypeID")
                        .HasColumnType("int");

                    b.Property<int?>("UserID")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.HasIndex("UserID");

                    b.ToTable("Item");
                });

            modelBuilder.Entity("BrowserAdventures.Models.ItemType", b =>
                {
                    b.Property<int>("ItemTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemTypeID");

                    b.ToTable("ItemType");
                });

            modelBuilder.Entity("BrowserAdventures.Models.Screen", b =>
                {
                    b.Property<int>("ScreenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ScreenDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScreenID");

                    b.ToTable("Screen");
                });

            modelBuilder.Entity("BrowserAdventures.Models.ScreenEnemy", b =>
                {
                    b.Property<int>("ScreenEnemyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EnemyDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnemyID")
                        .HasColumnType("int");

                    b.Property<string>("ScreenEnemyAction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ScreenID")
                        .HasColumnType("int");

                    b.HasKey("ScreenEnemyID");

                    b.HasIndex("ScreenID");

                    b.ToTable("ScreenEnemy");
                });

            modelBuilder.Entity("BrowserAdventures.Models.ScreenItem", b =>
                {
                    b.Property<int>("ScreenItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("ScreenID")
                        .HasColumnType("int");

                    b.Property<string>("ScreenItemAction")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenItemDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ScreenItemTakenDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ScreenItemID");

                    b.HasIndex("ItemID");

                    b.HasIndex("ScreenID");

                    b.ToTable("ScreenItem");
                });

            modelBuilder.Entity("BrowserAdventures.Models.User", b =>
                {
                    b.Property<int>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<int>("Health")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Screen")
                        .HasColumnType("int");

                    b.Property<bool>("WeaponEquipped")
                        .HasColumnType("bit");

                    b.Property<int>("WeaponID")
                        .HasColumnType("int");

                    b.HasKey("UserID");

                    b.ToTable("User");
                });

            modelBuilder.Entity("BrowserAdventures.Models.Weapon", b =>
                {
                    b.Property<int>("WeaponID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemID")
                        .HasColumnType("int");

                    b.Property<int>("WeaponDie")
                        .HasColumnType("int");

                    b.Property<int>("WeaponModifier")
                        .HasColumnType("int");

                    b.Property<int>("WeaponMultipler")
                        .HasColumnType("int");

                    b.HasKey("WeaponID");

                    b.ToTable("Weapons");
                });

            modelBuilder.Entity("BrowserAdventures.Models.InventoryItem", b =>
                {
                    b.HasOne("BrowserAdventures.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BrowserAdventures.Models.User", null)
                        .WithMany("InventoryItems")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BrowserAdventures.Models.Item", b =>
                {
                    b.HasOne("BrowserAdventures.Models.User", null)
                        .WithMany("Inventory")
                        .HasForeignKey("UserID");
                });

            modelBuilder.Entity("BrowserAdventures.Models.ScreenEnemy", b =>
                {
                    b.HasOne("BrowserAdventures.Models.Screen", null)
                        .WithMany("ScreenEnemies")
                        .HasForeignKey("ScreenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BrowserAdventures.Models.ScreenItem", b =>
                {
                    b.HasOne("BrowserAdventures.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BrowserAdventures.Models.Screen", null)
                        .WithMany("ScreenInventory")
                        .HasForeignKey("ScreenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

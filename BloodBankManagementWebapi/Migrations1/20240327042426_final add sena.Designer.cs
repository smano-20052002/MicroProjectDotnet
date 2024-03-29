﻿// <auto-generated />
using BloodBankManagementWebapi.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BloodBankManagementWebapi.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240327042426_final add sena")]
    partial class finaladdsena
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("BloodBankManagementWebapi.Model.Account", b =>
                {
                    b.Property<string>("AccountId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("AccountId");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.AccountRole", b =>
                {
                    b.Property<string>("AccountRoleId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(95)");

                    b.HasKey("AccountRoleId");

                    b.HasIndex("AccountId");

                    b.HasIndex("RoleId");

                    b.ToTable("AccountRole");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.AccountUserDetailsAddress", b =>
                {
                    b.Property<string>("AccountUserDetailsAddressId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("AddressId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("UserDetailsId")
                        .HasColumnType("varchar(95)");

                    b.HasKey("AccountUserDetailsAddressId");

                    b.HasIndex("AccountId");

                    b.HasIndex("AddressId");

                    b.HasIndex("UserDetailsId");

                    b.ToTable("AccountUserDetailsAddress");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.Address", b =>
                {
                    b.Property<string>("AddressId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("DoorNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodBankBloodStock", b =>
                {
                    b.Property<string>("BloodBankBloodStockId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("BloodStockId")
                        .HasColumnType("varchar(95)");

                    b.HasKey("BloodBankBloodStockId");

                    b.HasIndex("AccountId");

                    b.HasIndex("BloodStockId");

                    b.ToTable("BloodBankBloodStock");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodCamp", b =>
                {
                    b.Property<string>("BloodCampId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("BloodCampLocation")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("BloodCampName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BloodCampId");

                    b.ToTable("BloodCamp");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodCampBloodBank", b =>
                {
                    b.Property<string>("BloodCampBloodBankId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("BloodCampId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.HasKey("BloodCampBloodBankId");

                    b.HasIndex("AccountId");

                    b.HasIndex("BloodCampId");

                    b.ToTable("BloodCampBloodBank");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodRequest", b =>
                {
                    b.Property<string>("BloodRequestId")
                        .HasColumnType("varchar(95)");

                    b.Property<long>("AadhaarNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("AcceptStatus")
                        .HasColumnType("int");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<long>("PhoneNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Units")
                        .HasColumnType("int");

                    b.Property<string>("ValidTime")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BloodRequestId");

                    b.ToTable("BloodRequest");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodStock", b =>
                {
                    b.Property<string>("BloodStockId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Units")
                        .HasColumnType("int");

                    b.HasKey("BloodStockId");

                    b.ToTable("BloodStock");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodStockRequester", b =>
                {
                    b.Property<string>("BloodStockRequesterId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("AddressId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("BloodRequestId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("UserDetailsId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.HasKey("BloodStockRequesterId");

                    b.HasIndex("AccountId");

                    b.HasIndex("AddressId");

                    b.HasIndex("BloodRequestId");

                    b.HasIndex("UserDetailsId");

                    b.ToTable("bloodStockRequesters");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodTransaction", b =>
                {
                    b.Property<string>("BloodTransactionId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("BloodRequestId")
                        .IsRequired()
                        .HasColumnType("varchar(95)");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Time")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("units")
                        .HasColumnType("int");

                    b.HasKey("BloodTransactionId");

                    b.HasIndex("AccountId");

                    b.HasIndex("BloodRequestId");

                    b.ToTable("BloodTransaction");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.Role", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(95)");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.UserDetails", b =>
                {
                    b.Property<string>("UserDetailsId")
                        .HasColumnType("varchar(95)");

                    b.Property<long>("AadhaarNumber")
                        .HasColumnType("bigint");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("BloodType")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<byte[]>("Document")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("GovernmentId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("rolestatus")
                        .HasColumnType("int");

                    b.HasKey("UserDetailsId");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.AccountRole", b =>
                {
                    b.HasOne("BloodBankManagementWebapi.Model.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodBankManagementWebapi.Model.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Account");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.AccountUserDetailsAddress", b =>
                {
                    b.HasOne("BloodBankManagementWebapi.Model.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodBankManagementWebapi.Model.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("BloodBankManagementWebapi.Model.UserDetails", "UserDetails")
                        .WithMany()
                        .HasForeignKey("UserDetailsId");

                    b.Navigation("Account");

                    b.Navigation("Address");

                    b.Navigation("UserDetails");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodBankBloodStock", b =>
                {
                    b.HasOne("BloodBankManagementWebapi.Model.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodBankManagementWebapi.Model.BloodStock", "BloodStock")
                        .WithMany()
                        .HasForeignKey("BloodStockId");

                    b.Navigation("Account");

                    b.Navigation("BloodStock");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodCampBloodBank", b =>
                {
                    b.HasOne("BloodBankManagementWebapi.Model.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodBankManagementWebapi.Model.BloodCamp", "BloodCamp")
                        .WithMany()
                        .HasForeignKey("BloodCampId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("BloodCamp");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodStockRequester", b =>
                {
                    b.HasOne("BloodBankManagementWebapi.Model.Account", "Account")
                        .WithMany("StockRequests")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodBankManagementWebapi.Model.Address", "Address")
                        .WithMany("StockRequests")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodBankManagementWebapi.Model.BloodRequest", "BloodRequest")
                        .WithMany("StockRequests")
                        .HasForeignKey("BloodRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodBankManagementWebapi.Model.UserDetails", "UserDetails")
                        .WithMany("StockRequests")
                        .HasForeignKey("UserDetailsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Address");

                    b.Navigation("BloodRequest");

                    b.Navigation("UserDetails");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodTransaction", b =>
                {
                    b.HasOne("BloodBankManagementWebapi.Model.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BloodBankManagementWebapi.Model.BloodRequest", "BloodRequest")
                        .WithMany()
                        .HasForeignKey("BloodRequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("BloodRequest");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.Account", b =>
                {
                    b.Navigation("StockRequests");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.Address", b =>
                {
                    b.Navigation("StockRequests");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.BloodRequest", b =>
                {
                    b.Navigation("StockRequests");
                });

            modelBuilder.Entity("BloodBankManagementWebapi.Model.UserDetails", b =>
                {
                    b.Navigation("StockRequests");
                });
#pragma warning restore 612, 618
        }
    }
}

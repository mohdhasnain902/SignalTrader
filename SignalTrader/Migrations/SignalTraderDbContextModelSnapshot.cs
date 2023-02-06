﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SignalTrader.Data;

#nullable disable

namespace SignalTrader.Migrations
{
    [DbContext(typeof(SignalTraderDbContext))]
    partial class SignalTraderDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("signaltrader")
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("SignalTrader.Data.Entities.Account", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("AccountType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ApiKey")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("ApiPassphrase")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("ApiSecret")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(2000)");

                    b.Property<string>("Comment")
                        .HasMaxLength(1000)
                        .HasColumnType("varchar(4000)");

                    b.Property<long>("CreatedUtcMillis")
                        .HasColumnType("bigint");

                    b.Property<string>("Exchange")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ExchangeAccountId")
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<string>("ExchangeType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("QuoteAsset")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<long>("UpdatedUtcMillis")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AccountType");

                    b.HasIndex("Exchange");

                    b.HasIndex("ExchangeAccountId");

                    b.HasIndex("ExchangeType");

                    b.HasIndex("QuoteAsset");

                    b.HasIndex("Exchange", "ExchangeAccountId")
                        .IsUnique();

                    b.ToTable("Accounts", "signaltrader");
                });

            modelBuilder.Entity("SignalTrader.Data.Entities.Order", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<string>("BaseAsset")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<long>("CreatedUtcMillis")
                        .HasColumnType("bigint");

                    b.Property<string>("Exchange")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<string>("ExchangeOrderId")
                        .HasColumnType("text");

                    b.Property<long>("PositionId")
                        .HasColumnType("bigint");

                    b.Property<decimal?>("Price")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<decimal>("QuantityFilled")
                        .HasColumnType("numeric");

                    b.Property<string>("QuoteAsset")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<bool?>("ReduceOnly")
                        .HasColumnType("boolean");

                    b.Property<string>("Side")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("StopLoss")
                        .HasColumnType("numeric");

                    b.Property<decimal?>("TakeProfit")
                        .HasColumnType("numeric");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("UpdatedUtcMillis")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("BaseAsset");

                    b.HasIndex("Exchange");

                    b.HasIndex("ExchangeOrderId");

                    b.HasIndex("PositionId");

                    b.HasIndex("QuoteAsset");

                    b.HasIndex("Side");

                    b.HasIndex("Status");

                    b.ToTable("Orders", "signaltrader");
                });

            modelBuilder.Entity("SignalTrader.Data.Entities.Position", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("AccountId")
                        .HasColumnType("bigint");

                    b.Property<string>("BaseAsset")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<long>("CompletedUtcMillis")
                        .HasColumnType("bigint");

                    b.Property<long>("CreatedUtcMillis")
                        .HasColumnType("bigint");

                    b.Property<string>("Direction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Exchange")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal?>("LeverageMultiplier")
                        .HasColumnType("numeric");

                    b.Property<string>("LeverageType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("LiquidationPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("numeric");

                    b.Property<string>("QuoteAsset")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<decimal>("RealisedPnl")
                        .HasColumnType("numeric");

                    b.Property<decimal>("RealisedPnlPercent")
                        .HasColumnType("numeric");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal?>("StopLoss")
                        .HasColumnType("numeric");

                    b.Property<decimal>("UnrealisedPnl")
                        .HasColumnType("numeric");

                    b.Property<decimal>("UnrealisedPnlPercent")
                        .HasColumnType("numeric");

                    b.Property<long>("UpdatedUtcMillis")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("BaseAsset");

                    b.HasIndex("Direction");

                    b.HasIndex("Exchange");

                    b.HasIndex("QuoteAsset");

                    b.HasIndex("Status");

                    b.ToTable("Positions", "signaltrader");
                });

            modelBuilder.Entity("SignalTrader.Data.Entities.Signal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<long>("BarTimeUtcMillis")
                        .HasColumnType("bigint");

                    b.Property<string>("BaseAsset")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Close")
                        .HasColumnType("numeric");

                    b.Property<long>("CreatedUtcMillis")
                        .HasColumnType("bigint");

                    b.Property<string>("Exchange")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("High")
                        .HasColumnType("numeric");

                    b.Property<string>("Interval")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LongEnabled")
                        .HasColumnType("boolean");

                    b.Property<decimal>("Low")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Open")
                        .HasColumnType("numeric");

                    b.Property<string>("QuoteAsset")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("ShortEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("SignalName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<long>("SignalTimeUtcMillis")
                        .HasColumnType("bigint");

                    b.Property<string>("StrategyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Ticker")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Volume")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("BarTimeUtcMillis");

                    b.HasIndex("BaseAsset");

                    b.HasIndex("Exchange");

                    b.HasIndex("Interval");

                    b.HasIndex("QuoteAsset");

                    b.HasIndex("SignalName");

                    b.HasIndex("SignalTimeUtcMillis");

                    b.HasIndex("StrategyName");

                    b.HasIndex("Ticker");

                    b.ToTable("Signals", "signaltrader");
                });

            modelBuilder.Entity("SignalTrader.Data.Entities.Order", b =>
                {
                    b.HasOne("SignalTrader.Data.Entities.Account", "Account")
                        .WithMany("Orders")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SignalTrader.Data.Entities.Position", "Position")
                        .WithMany("Orders")
                        .HasForeignKey("PositionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("SignalTrader.Data.Entities.Position", b =>
                {
                    b.HasOne("SignalTrader.Data.Entities.Account", "Account")
                        .WithMany("Positions")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("SignalTrader.Data.Entities.Account", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("Positions");
                });

            modelBuilder.Entity("SignalTrader.Data.Entities.Position", b =>
                {
                    b.Navigation("Orders");
                });
#pragma warning restore 612, 618
        }
    }
}

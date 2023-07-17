using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace KeysysAPI.Entities;

public partial class KeysysDbContext : DbContext
{
    public KeysysDbContext()
    {
    }

    public KeysysDbContext(DbContextOptions<KeysysDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       
    }

    public virtual DbSet<InvoiceOption> InvoiceOptions { get; set; }

  

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<InvoiceOption>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("invoice_options");

            entity.Property(e => e.CorrelationId).HasColumnType("text");
            entity.Property(e => e.MessageId).HasColumnType("text");
            entity.Property(e => e.Ns3CategoryDescription)
                .HasColumnType("text")
                .HasColumnName("ns3:CategoryDescription");
            entity.Property(e => e.Ns3CategoryId).HasColumnName("ns3:CategoryID");
            entity.Property(e => e.Ns3InvoiceTypeCode).HasColumnName("ns3:InvoiceTypeCode");
            entity.Property(e => e.Ns3InvoiceTypeDescription)
                .HasColumnType("text")
                .HasColumnName("ns3:InvoiceTypeDescription");
            entity.Property(e => e.Ns3SubCategoryDescription)
                .HasColumnType("text")
                .HasColumnName("ns3:SubCategoryDescription");
            entity.Property(e => e.Ns3SubCategoryId).HasColumnName("ns3:SubCategoryID");
            entity.Property(e => e.Ns4AcknowledgementCode).HasColumnName("ns4:AcknowledgementCode");
            entity.Property(e => e.Ns4AcknowledgementMessage)
                .HasColumnType("text")
                .HasColumnName("ns4:AcknowledgementMessage");
            entity.Property(e => e.Ns4BillingCode).HasColumnName("ns4:BillingCode");
            entity.Property(e => e.Ns4BillingDateTime)
                .HasColumnType("text")
                .HasColumnName("ns4:BillingDateTime");
            entity.Property(e => e.Ns4BillingEntity).HasColumnName("ns4:BillingEntity");
            entity.Property(e => e.Ns4Company)
                .HasColumnType("text")
                .HasColumnName("ns4:Company");
            entity.Property(e => e.Ns4LoanNumber).HasColumnName("ns4:LoanNumber");
            entity.Property(e => e.Ns4Servicer).HasColumnName("ns4:Servicer");
            entity.Property(e => e.Ns4TransactionId)
                .HasColumnType("text")
                .HasColumnName("ns4:TransactionID");
            entity.Property(e => e.Ns5ContactInformation)
                .HasColumnType("text")
                .HasColumnName("ns5:ContactInformation");
            entity.Property(e => e.Ns5CorrelationId)
                .HasColumnType("text")
                .HasColumnName("ns5:CorrelationID");
            entity.Property(e => e.SoftwareVersionNumber).HasColumnType("text");
            entity.Property(e => e.StatusCode).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

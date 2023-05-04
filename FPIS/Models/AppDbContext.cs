using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace FPIS.Models
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string password = ConfigurationManager.AppSettings["database_password"];
            optionsBuilder.UseNpgsql($"Host=localhost;Port=5432;Database=FPIS;Username=postgres;Password={password}");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
        modelBuilder.Entity<User>().HasIndex(user => user.EmpID).IsUnique();
        
            modelBuilder.Entity<SampleDetail>()
                .HasOne(s => s.Sample)
                .WithMany(sd => sd.SampleDetails)
                .HasForeignKey(s => s.SampleId);

            modelBuilder.Entity<SampleDetail>()
                .HasOne(ai => ai.AnalysisItem)
                .WithMany(sd => sd.SampleDetails)
                .HasForeignKey(ai => ai.AnalysisItemId);

            modelBuilder.Entity<SampleResultDetail>()
               .HasOne(sr => sr.SampleResult)
               .WithMany(srd => srd.SampleResultDetails)
               .HasForeignKey(sr => sr.SampleResultId);

            modelBuilder.Entity<SampleResult>()
               .HasOne(u => u.User)
               .WithMany(srd => srd.SampleResults)
               .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<SampleResultsDetailsWithParameter>()
               .HasOne(srd => srd.SampleResultDetail)
               .WithMany(srdwp => srdwp.sampleResultsDetailsWithParameters)
               .HasForeignKey(srd => srd.SampleResultDetailId);

            modelBuilder.Entity<SampleResultsDetailsWithParameter>()
               .HasOne(sd => sd.SampleResultDetail)
               .WithMany(srdwp => srdwp.sampleResultsDetailsWithParameters)
               .HasForeignKey(sd => sd.SampleResultDetailId);

            modelBuilder.Entity<SampleResultsDetailsWithParameter>()
               .HasOne(ap => ap.AnalysisParameter)
               .WithMany(srdwp => srdwp.sampleResultsDetailsWithParameters)
               .HasForeignKey(ap => ap.AnalysisParameterId);

            modelBuilder.Entity<AnalysisRemark>()
               .HasOne(sd => sd.SampleDetail)
               .WithMany(ar => ar.AnalysisRemarks)
               .HasForeignKey(sd => sd.SampleDetailId);

            modelBuilder.Entity<AnalysisRemark>()
               .HasOne(srd => srd.SampleResultDetail)
               .WithMany(ar => ar.AnalysisRemarks)
               .HasForeignKey(srd => srd.SampleResultDetailId);

            modelBuilder.Entity<AnalysisRemark>()
               .HasOne(u => u.User)
               .WithMany(ar => ar.AnalysisRemarks)
               .HasForeignKey(u => u.UserId);

            modelBuilder.Entity<ProcurementParameter>()
               .HasOne(mp => mp.MaterialProcurement)
               .WithMany(pp => pp.ProcurementParameters)
               .HasForeignKey(mp => mp.ProcurementId);

            modelBuilder.Entity<ProcurementParameter>()
               .HasOne(pp => pp.ProductParameter)
               .WithMany(pp => pp.ProcurementParameters)
               .HasForeignKey(pp => pp.ProductParameterId);

            modelBuilder.Entity<ProcurementAttribute>()
               .HasOne(mp => mp.MaterialProcurement)
               .WithMany(pa => pa.ProcurementAttributes)
               .HasForeignKey(mp => mp.ProcurementId);

            modelBuilder.Entity<ProcurementAttribute>()
               .HasOne(ma => ma.MaterialAttribute)
               .WithMany(pa => pa.ProcurementAttributes)
               .HasForeignKey(ma => ma.MaterialAttributeId);

        }

        public DbSet<Department> Departments { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public DbSet<ProductParameter> ProductParameters { get; set; }
        public virtual DbSet<Water> Waters { get; set; }
        public DbSet<WaterParameter> WaterParameters { get; set; }
        public DbSet<MaterialAttribute> MaterialAttributes { get; set; }
        public virtual DbSet<StockItem> StockItems { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public DbSet<AnalysisItem> AnalysisItems { get; set; }
        public DbSet<Sample> Samples { get; set; }
        public DbSet<SampleResult> SampleResults { get; set; }
        public DbSet<AnalysisParameter> AnalysisParameters { get; set; }
        public DbSet<ProductionDailyReport> ProductionDailyReports { get; set;}
        public DbSet<MaterialProcurement> MaterialProcurements { get; set;}
        public DbSet<Receiving> Receivings { get; set; }
        public DbSet<Releasing> Releasings { get; set; }
        public DbSet<FinishedProduct> FinishedProducts { get; set; }
        public DbSet<ReceivedStock> ReceivedStocks { get; set; }
        public DbSet<IssuedStock> IssuedStocks { get; set;}
        public virtual DbSet<AnalysisProduct> AnalysisProducts { get; set; }
        public virtual DbSet<AnalysisWater> AnalysisWaters { get; set; }
        public DbSet<ProductAnalysisParameter> ProductAnalysisParameters { get; set; }
        public DbSet<WaterAnalysisParameter> WaterAnalysisParameters { get; set; }
        public DbSet<SampleDetail> SampleDetails { get; set; }
        public DbSet<SampleResultDetail> SampleResultDetails { get; set; }
        public DbSet<SampleResultsDetailsWithParameter> SampleResultsDetailsWithParameters { get; set; }
        public DbSet<AnalysisRemark> AnalysisRemarks { get; set; }
        public DbSet<ProcurementParameter> ProcurementParameters { get; set; }
        public DbSet<ProcurementAttribute> ProcurementAttributes { get; set; }
        public DbSet<CalculatorVariable> CalculatorVariables { get; set; }
    }
}

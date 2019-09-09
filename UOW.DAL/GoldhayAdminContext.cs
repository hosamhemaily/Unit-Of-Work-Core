using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace UOW.DAL.Models
{
    public partial class GoldhayAdminContext : DbContext
    {
        public GoldhayAdminContext()
        {
        }

        public GoldhayAdminContext(DbContextOptions<GoldhayAdminContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountDevices> AccountDevices { get; set; }
        public virtual DbSet<AccountPermissions> AccountPermissions { get; set; }
        public virtual DbSet<AccountingGroups> AccountingGroups { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AccountsRoles> AccountsRoles { get; set; }
        public virtual DbSet<ActionPlanMedias> ActionPlanMedias { get; set; }
        public virtual DbSet<ActionPlans> ActionPlans { get; set; }
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Airlines> Airlines { get; set; }
        public virtual DbSet<Airports> Airports { get; set; }
        public virtual DbSet<ApplicationDepartments> ApplicationDepartments { get; set; }
        public virtual DbSet<Applications> Applications { get; set; }
        public virtual DbSet<AreaAttributes> AreaAttributes { get; set; }
        public virtual DbSet<AreasAr> AreasAr { get; set; }
        public virtual DbSet<AreasEn> AreasEn { get; set; }
        public virtual DbSet<AreasRegions> AreasRegions { get; set; }
        public virtual DbSet<ArticleAttributes> ArticleAttributes { get; set; }
        public virtual DbSet<ArticleFiles> ArticleFiles { get; set; }
        public virtual DbSet<ArticleWorkflows> ArticleWorkflows { get; set; }
        public virtual DbSet<Articles> Articles { get; set; }
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AttributeGroups> AttributeGroups { get; set; }
        public virtual DbSet<Attributes> Attributes { get; set; }
        public virtual DbSet<Booking> Booking { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<ChartOfAccounts> ChartOfAccounts { get; set; }
        public virtual DbSet<CitiesAr> CitiesAr { get; set; }
        public virtual DbSet<CitiesEn> CitiesEn { get; set; }
        public virtual DbSet<CitiesRegions> CitiesRegions { get; set; }
        public virtual DbSet<ContentGroups> ContentGroups { get; set; }
        public virtual DbSet<CountiesAr> CountiesAr { get; set; }
        public virtual DbSet<CountiesEn> CountiesEn { get; set; }
        public virtual DbSet<CountiesRegions> CountiesRegions { get; set; }
        public virtual DbSet<CountriesAr> CountriesAr { get; set; }
        public virtual DbSet<CountriesEn> CountriesEn { get; set; }
        public virtual DbSet<CustomerElectronicMarktOpts> CustomerElectronicMarktOpts { get; set; }
        public virtual DbSet<CustomerEmailOpts> CustomerEmailOpts { get; set; }
        public virtual DbSet<CustomerMarktExclusionOpts> CustomerMarktExclusionOpts { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Dashboards> Dashboards { get; set; }
        public virtual DbSet<ElectronicMarketingOptions> ElectronicMarketingOptions { get; set; }
        public virtual DbSet<EmailOptions> EmailOptions { get; set; }
        public virtual DbSet<Enquiries> Enquiries { get; set; }
        public virtual DbSet<FileTypes> FileTypes { get; set; }
        public virtual DbSet<Grades> Grades { get; set; }
        public virtual DbSet<HttpMimeTypes> HttpMimeTypes { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<JobProcessAttributes> JobProcessAttributes { get; set; }
        public virtual DbSet<JobProcessMedias> JobProcessMedias { get; set; }
        public virtual DbSet<JobProcessOptionMedias> JobProcessOptionMedias { get; set; }
        public virtual DbSet<JobProcessOptions> JobProcessOptions { get; set; }
        public virtual DbSet<JobProcessStatuses> JobProcessStatuses { get; set; }
        public virtual DbSet<JobProcesses> JobProcesses { get; set; }
        public virtual DbSet<Jobs> Jobs { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<MarketingExclusionOptions> MarketingExclusionOptions { get; set; }
        public virtual DbSet<MediaFileAttributes> MediaFileAttributes { get; set; }
        public virtual DbSet<MediaFiles> MediaFiles { get; set; }
        public virtual DbSet<MessageFiles> MessageFiles { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<NotificationTypes> NotificationTypes { get; set; }
        public virtual DbSet<Notifications> Notifications { get; set; }
        public virtual DbSet<Offices> Offices { get; set; }
        public virtual DbSet<Payrolls> Payrolls { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<Postcodes> Postcodes { get; set; }
        public virtual DbSet<PostcodesRegions> PostcodesRegions { get; set; }
        public virtual DbSet<Priorities> Priorities { get; set; }
        public virtual DbSet<ProcessItems> ProcessItems { get; set; }
        public virtual DbSet<Processes> Processes { get; set; }
        public virtual DbSet<ProductStatuses> ProductStatuses { get; set; }
        public virtual DbSet<QualityStatuses> QualityStatuses { get; set; }
        public virtual DbSet<Regions> Regions { get; set; }
        public virtual DbSet<RenderMedias> RenderMedias { get; set; }
        public virtual DbSet<RoleClaims> RoleClaims { get; set; }
        public virtual DbSet<RolePermissions> RolePermissions { get; set; }
        public virtual DbSet<ServiceSessions> ServiceSessions { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Severities> Severities { get; set; }
        public virtual DbSet<StageItemStatuses> StageItemStatuses { get; set; }
        public virtual DbSet<Statuses> Statuses { get; set; }
        public virtual DbSet<Themes> Themes { get; set; }
        public virtual DbSet<TransactionTypes> TransactionTypes { get; set; }
        public virtual DbSet<Transactions> Transactions { get; set; }
        public virtual DbSet<TreeItemTypes> TreeItemTypes { get; set; }
        public virtual DbSet<UserClaims> UserClaims { get; set; }
        public virtual DbSet<UserContentGroups> UserContentGroups { get; set; }
        public virtual DbSet<UserLogins> UserLogins { get; set; }
        public virtual DbSet<UserMessages> UserMessages { get; set; }
        public virtual DbSet<UserPermissions> UserPermissions { get; set; }
        public virtual DbSet<UserProfiles> UserProfiles { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<UserTokens> UserTokens { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<ValueTypes> ValueTypes { get; set; }
        public virtual DbSet<Widgets> Widgets { get; set; }
        public virtual DbSet<WorkflowAttributes> WorkflowAttributes { get; set; }
        public virtual DbSet<WorkflowStageAttributes> WorkflowStageAttributes { get; set; }
        public virtual DbSet<WorkflowStageItemAttributes> WorkflowStageItemAttributes { get; set; }
        public virtual DbSet<WorkflowStageItemOptions> WorkflowStageItemOptions { get; set; }
        public virtual DbSet<WorkflowStageItems> WorkflowStageItems { get; set; }
        public virtual DbSet<WorkflowStages> WorkflowStages { get; set; }
        public virtual DbSet<WorkflowTriggers> WorkflowTriggers { get; set; }
        public virtual DbSet<Workflows> Workflows { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server=data.goldhay.com;Database=GoldhayAdmin; User Id=GoldhayAdmin;password=kf_e^23m+Uy;Integrated Security=False;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<AccountDevices>(entity =>
            {
                entity.HasIndex(e => e.AccountId);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountDevices)
                    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<AccountPermissions>(entity =>
            {
                entity.HasKey(e => e.AccountPermissionId);

                entity.HasIndex(e => e.AccountId);

                entity.HasIndex(e => e.PermissionId);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountPermissions)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.AccountPermissions)
                    .HasForeignKey(d => d.PermissionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<AccountingGroups>(entity =>
            {
                entity.HasKey(e => e.AccountingGroupId);

                entity.HasIndex(e => e.AccountId);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountingGroups)
                    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<Accounts>(entity =>
            {
                entity.HasKey(e => e.AccountId);

                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.ContractSignedOn).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.CategoryId);
            });

            modelBuilder.Entity<AccountsRoles>(entity =>
            {
                entity.HasIndex(e => e.AccountId);

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.AccountsRoles)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AccountsRoles)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<ActionPlanMedias>(entity =>
            {
                entity.HasKey(e => e.ActionPlanMediaId);

                entity.HasIndex(e => e.ActionPlanId);

                entity.HasIndex(e => e.MediaFileId);

                entity.HasOne(d => d.ActionPlan)
                    .WithMany(p => p.ActionPlanMedias)
                    .HasForeignKey(d => d.ActionPlanId);

                entity.HasOne(d => d.MediaFile)
                    .WithMany(p => p.ActionPlanMedias)
                    .HasForeignKey(d => d.MediaFileId);
            });

            modelBuilder.Entity<ActionPlans>(entity =>
            {
                entity.HasKey(e => e.ActionPlanId);

                entity.HasIndex(e => e.JobProcessId);

                entity.HasIndex(e => e.JobProcessStatusId);

                entity.HasOne(d => d.JobProcess)
                    .WithMany(p => p.ActionPlans)
                    .HasForeignKey(d => d.JobProcessId);

                entity.HasOne(d => d.JobProcessStatus)
                    .WithMany(p => p.ActionPlans)
                    .HasForeignKey(d => d.JobProcessStatusId);
            });

            modelBuilder.Entity<Addresses>(entity =>
            {
                entity.HasKey(e => e.AddressId);

                entity.HasIndex(e => e.PostcodeId);

                entity.HasOne(d => d.Postcode)
                    .WithMany(p => p.Addresses)
                    .HasForeignKey(d => d.PostcodeId);
            });

            modelBuilder.Entity<Airlines>(entity =>
            {
                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.Iatadesignator)
                    .HasColumnName("IATADesignator")
                    .HasMaxLength(50);

                entity.Property(e => e.Icaodesignator)
                    .IsRequired()
                    .HasColumnName("ICAODesignator")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<Airports>(entity =>
            {
                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CountryAbbrev).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ApplicationDepartments>(entity =>
            {
                entity.HasKey(e => e.ApplicationDepartmentId);

                entity.HasIndex(e => e.ApplicationId);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ApplicationDepartments)
                    .HasForeignKey(d => d.ApplicationId);
            });

            modelBuilder.Entity<Applications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId);

                entity.HasIndex(e => e.AccountId);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Applications)
                    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<AreaAttributes>(entity =>
            {
                entity.HasIndex(e => e.AreaId);

                entity.HasIndex(e => e.AttributeId);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AreaAttributes)
                    .HasForeignKey(d => d.AreaId);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.AreaAttributes)
                    .HasForeignKey(d => d.AttributeId);
            });

            modelBuilder.Entity<AreasAr>(entity =>
            {
                entity.HasKey(e => e.AreaArId);
            });

            modelBuilder.Entity<AreasEn>(entity =>
            {
                entity.HasKey(e => e.AreaEnId);

                entity.HasIndex(e => e.CityId);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AreasEn)
                    .HasForeignKey(d => d.CityId);
            });

            modelBuilder.Entity<AreasRegions>(entity =>
            {
                entity.HasIndex(e => e.AreaId);

                entity.HasIndex(e => e.RegionId);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.AreasRegions)
                    .HasForeignKey(d => d.AreaId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.AreasRegions)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<ArticleAttributes>(entity =>
            {
                entity.HasIndex(e => e.ArticleId);

                entity.HasIndex(e => e.AttributeId);

                entity.Property(e => e.ApplyDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ArticleAttributes)
                    .HasForeignKey(d => d.ArticleId);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.ArticleAttributes)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ArticleFiles>(entity =>
            {
                entity.HasIndex(e => e.ArticleId);

                entity.HasIndex(e => e.MediaFileId);

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ArticleFiles)
                    .HasForeignKey(d => d.ArticleId);

                entity.HasOne(d => d.MediaFile)
                    .WithMany(p => p.ArticleFiles)
                    .HasForeignKey(d => d.MediaFileId);
            });

            modelBuilder.Entity<ArticleWorkflows>(entity =>
            {
                entity.HasKey(e => e.ArticleWorkflowId);

                entity.HasIndex(e => e.ArticleId);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.ArticleWorkflows)
                    .HasForeignKey(d => d.ArticleId);
            });

            modelBuilder.Entity<Articles>(entity =>
            {
                entity.HasKey(e => e.ArticleId);

                entity.HasIndex(e => e.AddressId);

                entity.HasIndex(e => e.ContentGroupId);

                entity.HasIndex(e => e.OfficeId);

                entity.Property(e => e.OfficeId).HasDefaultValueSql("(CONVERT([bigint],(38)))");

                entity.Property(e => e.ProductStatusId).HasDefaultValueSql("(CONVERT([bigint],(0)))");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.AddressId);

                entity.HasOne(d => d.ContentGroup)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.ContentGroupId);

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Articles)
                    .HasForeignKey(d => d.OfficeId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName)
                    .HasName("RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Discriminator).IsRequired();

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AttributeGroups>(entity =>
            {
                entity.HasKey(e => e.AttributeGroupId);
            });

            modelBuilder.Entity<Attributes>(entity =>
            {
                entity.HasKey(e => e.AttributeId);

                entity.HasIndex(e => e.AttributeGroupId);

                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.AttributeId).ValueGeneratedNever();

                entity.Property(e => e.TaxValue).HasDefaultValueSql("((0.000000000000000e+000))");

                entity.HasOne(d => d.AttributeGroup)
                    .WithMany(p => p.Attributes)
                    .HasForeignKey(d => d.AttributeGroupId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Attributes)
                    .HasForeignKey(d => d.CategoryId);
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.Property(e => e.CheckIn).HasColumnType("date");

                entity.Property(e => e.CheckOut).HasColumnType("date");

                entity.Property(e => e.CheckedOut).HasDefaultValueSql("((0))");

                entity.Property(e => e.GuestName).HasMaxLength(100);

                entity.Property(e => e.GuestPhone).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("date");

                entity.Property(e => e.Notes).HasMaxLength(50);

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.HasOne(d => d.BookingStatus)
                    .WithMany(p => p.BookingBookingStatus)
                    .HasForeignKey(d => d.BookingStatusId)
                    .HasConstraintName("FK_Booking_Status");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.BookingRoom)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK_Booking_Room");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.Property(e => e.CategoryId).ValueGeneratedNever();
            });

            modelBuilder.Entity<ChartOfAccounts>(entity =>
            {
                entity.HasIndex(e => e.AccountingGroupId);

                entity.HasIndex(e => e.TreeItemTypeId);

                entity.HasOne(d => d.AccountingGroup)
                    .WithMany(p => p.ChartOfAccounts)
                    .HasForeignKey(d => d.AccountingGroupId);

                entity.HasOne(d => d.TreeItemType)
                    .WithMany(p => p.ChartOfAccounts)
                    .HasForeignKey(d => d.TreeItemTypeId);
            });

            modelBuilder.Entity<CitiesAr>(entity =>
            {
                entity.HasKey(e => e.CityArId);
            });

            modelBuilder.Entity<CitiesEn>(entity =>
            {
                entity.HasKey(e => e.CityEnId);

                entity.HasIndex(e => e.CountyId);

                entity.HasOne(d => d.County)
                    .WithMany(p => p.CitiesEn)
                    .HasForeignKey(d => d.CountyId);
            });

            modelBuilder.Entity<CitiesRegions>(entity =>
            {
                entity.HasIndex(e => e.CityId);

                entity.HasIndex(e => e.RegionId);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.CitiesRegions)
                    .HasForeignKey(d => d.CityId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.CitiesRegions)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<CountiesAr>(entity =>
            {
                entity.HasKey(e => e.CountyArId);
            });

            modelBuilder.Entity<CountiesEn>(entity =>
            {
                entity.HasKey(e => e.CountyEnId);

                entity.HasIndex(e => e.CountryId);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountiesEn)
                    .HasForeignKey(d => d.CountryId);
            });

            modelBuilder.Entity<CountiesRegions>(entity =>
            {
                entity.HasIndex(e => e.CountyId);

                entity.HasIndex(e => e.RegionId);

                entity.HasOne(d => d.County)
                    .WithMany(p => p.CountiesRegions)
                    .HasForeignKey(d => d.CountyId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.CountiesRegions)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<CountriesEn>(entity =>
            {
                entity.HasKey(e => e.CountryEnId);
            });

            modelBuilder.Entity<CustomerElectronicMarktOpts>(entity =>
            {
                entity.HasKey(e => e.CustomerElectronicMarktOptId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ElectronicMarketingOptionId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerElectronicMarktOpts)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.ElectronicMarketingOption)
                    .WithMany(p => p.CustomerElectronicMarktOpts)
                    .HasForeignKey(d => d.ElectronicMarketingOptionId);
            });

            modelBuilder.Entity<CustomerEmailOpts>(entity =>
            {
                entity.HasKey(e => e.CustomerEmailOptId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.EmailOptionId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerEmailOpts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.EmailOption)
                    .WithMany(p => p.CustomerEmailOpts)
                    .HasForeignKey(d => d.EmailOptionId);
            });

            modelBuilder.Entity<CustomerMarktExclusionOpts>(entity =>
            {
                entity.HasKey(e => e.CustomerMarktExclusionOptId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.MarketingExclusionOptionId);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerMarktExclusionOpts)
                    .HasForeignKey(d => d.CustomerId);

                entity.HasOne(d => d.MarketingExclusionOption)
                    .WithMany(p => p.CustomerMarktExclusionOpts)
                    .HasForeignKey(d => d.MarketingExclusionOptionId);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.HasIndex(e => e.AvatarMediaFileId);

                entity.HasIndex(e => e.OfficeId);

                entity.Property(e => e.Idtype).HasColumnName("IDType");

                entity.HasOne(d => d.AvatarMediaFile)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AvatarMediaFileId);

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.OfficeId);
            });

            modelBuilder.Entity<Dashboards>(entity =>
            {
                entity.HasKey(e => e.DashboardId);

                entity.HasIndex(e => e.ProfileId);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.Dashboards)
                    .HasForeignKey(d => d.ProfileId);
            });

            modelBuilder.Entity<ElectronicMarketingOptions>(entity =>
            {
                entity.HasKey(e => e.ElectronicMarketingOptionId);

                entity.Property(e => e.Name).HasMaxLength(300);
            });

            modelBuilder.Entity<EmailOptions>(entity =>
            {
                entity.HasKey(e => e.EmailOptionId);
            });

            modelBuilder.Entity<Enquiries>(entity =>
            {
                entity.HasKey(e => e.EnquiryId);
            });

            modelBuilder.Entity<FileTypes>(entity =>
            {
                entity.HasKey(e => e.FileTypeId);
            });

            modelBuilder.Entity<Grades>(entity =>
            {
                entity.HasKey(e => e.GradeId);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.GuestName).HasMaxLength(100);
            });

            modelBuilder.Entity<JobProcessAttributes>(entity =>
            {
                entity.HasIndex(e => e.AttributeId);

                entity.HasIndex(e => e.JobProcessId);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.JobProcessAttributes)
                    .HasForeignKey(d => d.AttributeId);

                entity.HasOne(d => d.JobProcess)
                    .WithMany(p => p.JobProcessAttributes)
                    .HasForeignKey(d => d.JobProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<JobProcessMedias>(entity =>
            {
                entity.HasKey(e => e.JobProcessMediaId);

                entity.HasIndex(e => e.JobProcessId);

                entity.HasIndex(e => e.MediaFileId);

                entity.HasOne(d => d.JobProcess)
                    .WithMany(p => p.JobProcessMedias)
                    .HasForeignKey(d => d.JobProcessId);

                entity.HasOne(d => d.MediaFile)
                    .WithMany(p => p.JobProcessMedias)
                    .HasForeignKey(d => d.MediaFileId);
            });

            modelBuilder.Entity<JobProcessOptionMedias>(entity =>
            {
                entity.HasIndex(e => e.JobProcessOptionId);

                entity.HasIndex(e => e.MediaFileId);

                entity.HasOne(d => d.JobProcessOption)
                    .WithMany(p => p.JobProcessOptionMedias)
                    .HasForeignKey(d => d.JobProcessOptionId);

                entity.HasOne(d => d.MediaFile)
                    .WithMany(p => p.JobProcessOptionMedias)
                    .HasForeignKey(d => d.MediaFileId);
            });

            modelBuilder.Entity<JobProcessOptions>(entity =>
            {
                entity.HasKey(e => e.JobProcessOptionId);

                entity.HasIndex(e => e.JobProcessId);

                entity.HasIndex(e => e.OptionId);

                entity.HasIndex(e => e.SeverityId);

                entity.HasOne(d => d.JobProcess)
                    .WithMany(p => p.JobProcessOptions)
                    .HasForeignKey(d => d.JobProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.JobProcessOptions)
                    .HasForeignKey(d => d.OptionId);

                entity.HasOne(d => d.Severity)
                    .WithMany(p => p.JobProcessOptions)
                    .HasForeignKey(d => d.SeverityId);
            });

            modelBuilder.Entity<JobProcessStatuses>(entity =>
            {
                entity.HasKey(e => e.JobProcessStatusId);
            });

            modelBuilder.Entity<JobProcesses>(entity =>
            {
                entity.HasKey(e => e.JobProcessId);

                entity.HasIndex(e => e.JobId);

                entity.HasIndex(e => e.OptionId);

                entity.HasIndex(e => e.SeverityId);

                entity.HasIndex(e => e.StageItemId);

                entity.HasIndex(e => e.StageItemStatusId);

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PinX).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PinY).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobProcesses)
                    .HasForeignKey(d => d.JobId);

                entity.HasOne(d => d.Option)
                    .WithMany(p => p.JobProcesses)
                    .HasForeignKey(d => d.OptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Severity)
                    .WithMany(p => p.JobProcesses)
                    .HasForeignKey(d => d.SeverityId);

                entity.HasOne(d => d.StageItem)
                    .WithMany(p => p.JobProcesses)
                    .HasForeignKey(d => d.StageItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.StageItemStatus)
                    .WithMany(p => p.JobProcesses)
                    .HasForeignKey(d => d.StageItemStatusId);
            });

            modelBuilder.Entity<Jobs>(entity =>
            {
                entity.HasKey(e => e.JobId);

                entity.HasIndex(e => e.AccountId);

                entity.HasIndex(e => e.ArticleId);

                entity.HasIndex(e => e.AssignedToId);

                entity.HasIndex(e => e.CustomerId);

                entity.HasIndex(e => e.ProcessId);

                entity.HasIndex(e => e.ServiceId);

                entity.HasIndex(e => e.StatusId);

                entity.Property(e => e.AmendedFee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Qcchecked).HasColumnName("QCChecked");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.JobsAccount)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.Article)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.ArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AssignedTo)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.AssignedToId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.JobsCustomer)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.ProcessId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.StatusId);
            });

            modelBuilder.Entity<Languages>(entity =>
            {
                entity.HasKey(e => e.LanguageId);
            });

            modelBuilder.Entity<MarketingExclusionOptions>(entity =>
            {
                entity.HasKey(e => e.MarketingExclusionOptionId);
            });

            modelBuilder.Entity<MediaFileAttributes>(entity =>
            {
                entity.HasIndex(e => e.AttributeId);

                entity.HasIndex(e => e.MediaFileId);

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.MediaFileAttributes)
                    .HasForeignKey(d => d.AttributeId);

                entity.HasOne(d => d.MediaFile)
                    .WithMany(p => p.MediaFileAttributes)
                    .HasForeignKey(d => d.MediaFileId);
            });

            modelBuilder.Entity<MediaFiles>(entity =>
            {
                entity.HasKey(e => e.MediaFileId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.FileTypeId);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.MediaFiles)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.FileType)
                    .WithMany(p => p.MediaFiles)
                    .HasForeignKey(d => d.FileTypeId);
            });

            modelBuilder.Entity<MessageFiles>(entity =>
            {
                entity.HasKey(e => e.MessageFileId);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.HasKey(e => e.MessageId);

                entity.HasIndex(e => e.SenderId);

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.SenderId);
            });

            modelBuilder.Entity<Notifications>(entity =>
            {
                entity.HasKey(e => e.NotificationId);

                entity.HasIndex(e => e.FromUserId);

                entity.HasIndex(e => e.NotificationTypeId);

                entity.HasIndex(e => e.ToUserId);

                entity.HasOne(d => d.FromUser)
                    .WithMany(p => p.NotificationsFromUser)
                    .HasForeignKey(d => d.FromUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.NotificationType)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.NotificationTypeId);

                entity.HasOne(d => d.ToUser)
                    .WithMany(p => p.NotificationsToUser)
                    .HasForeignKey(d => d.ToUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Offices>(entity =>
            {
                entity.HasKey(e => e.OfficeId);

                entity.HasIndex(e => e.AccountId);

                entity.HasIndex(e => e.AddressId);

                entity.Property(e => e.OfficeId).ValueGeneratedNever();

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Offices)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Offices)
                    .HasForeignKey(d => d.AddressId);
            });

            modelBuilder.Entity<Payrolls>(entity =>
            {
                entity.HasKey(e => e.PayrollId);

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Permissions>(entity =>
            {
                entity.HasKey(e => e.PermissionId);

                entity.HasIndex(e => e.DepartmentId);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Permissions)
                    .HasForeignKey(d => d.DepartmentId);
            });

            modelBuilder.Entity<Postcodes>(entity =>
            {
                entity.HasKey(e => e.PostcodeId);

                entity.HasIndex(e => e.AreaId);

                entity.HasOne(d => d.Area)
                    .WithMany(p => p.Postcodes)
                    .HasForeignKey(d => d.AreaId);
            });

            modelBuilder.Entity<PostcodesRegions>(entity =>
            {
                entity.HasIndex(e => e.PostcodeId);

                entity.HasIndex(e => e.RegionId);

                entity.HasOne(d => d.Postcode)
                    .WithMany(p => p.PostcodesRegions)
                    .HasForeignKey(d => d.PostcodeId);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.PostcodesRegions)
                    .HasForeignKey(d => d.RegionId);
            });

            modelBuilder.Entity<Priorities>(entity =>
            {
                entity.HasKey(e => e.PriorityId);
            });

            modelBuilder.Entity<ProcessItems>(entity =>
            {
                entity.HasIndex(e => e.ProcessId);

                entity.HasIndex(e => e.WorkflowStageItemId);

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.ProcessItems)
                    .HasForeignKey(d => d.ProcessId);

                entity.HasOne(d => d.WorkflowStageItem)
                    .WithMany(p => p.ProcessItems)
                    .HasForeignKey(d => d.WorkflowStageItemId);
            });

            modelBuilder.Entity<Processes>(entity =>
            {
                entity.HasKey(e => e.ProcessId);

                entity.HasIndex(e => e.CategoryId);

                entity.HasIndex(e => e.StatusId);

                entity.Property(e => e.Fee).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Processes)
                    .HasForeignKey(d => d.CategoryId);

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Processes)
                    .HasForeignKey(d => d.StatusId);
            });

            modelBuilder.Entity<ProductStatuses>(entity =>
            {
                entity.HasKey(e => e.ProductStatusId);
            });

            modelBuilder.Entity<QualityStatuses>(entity =>
            {
                entity.HasKey(e => e.QualityStatusId);
            });

            modelBuilder.Entity<Regions>(entity =>
            {
                entity.HasKey(e => e.RegionId);
            });

            modelBuilder.Entity<RenderMedias>(entity =>
            {
                entity.HasKey(e => e.RenderMediaId);

                entity.Property(e => e.RenderMediaId).HasColumnName("RenderMediaID");

                entity.Property(e => e.ArticleId).HasColumnName("ArticleID");

                entity.Property(e => e.MediaId).HasColumnName("MediaID");
            });

            modelBuilder.Entity<RoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<RolePermissions>(entity =>
            {
                entity.HasIndex(e => e.PermissionId);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.PermissionId);
            });

            modelBuilder.Entity<ServiceSessions>(entity =>
            {
                entity.HasIndex(e => e.ApplicationId);

                entity.HasIndex(e => e.UserId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.ServiceSessions)
                    .HasForeignKey(d => d.ApplicationId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServiceSessions)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Services>(entity =>
            {
                entity.HasKey(e => e.ServiceId);

                entity.HasIndex(e => e.AccountId);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.AccountId);
            });

            modelBuilder.Entity<Severities>(entity =>
            {
                entity.HasKey(e => e.SeverityId);
            });

            modelBuilder.Entity<StageItemStatuses>(entity =>
            {
                entity.HasKey(e => e.StageItemStatusId);
            });

            modelBuilder.Entity<Statuses>(entity =>
            {
                entity.HasKey(e => e.StatusId);
            });

            modelBuilder.Entity<Themes>(entity =>
            {
                entity.HasKey(e => e.ThemeId);

                entity.HasIndex(e => e.ApplicationId);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.Themes)
                    .HasForeignKey(d => d.ApplicationId);
            });

            modelBuilder.Entity<TransactionTypes>(entity =>
            {
                entity.HasKey(e => e.TransactionTypeId);
            });

            modelBuilder.Entity<Transactions>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.HasIndex(e => e.AccountId);

                entity.HasIndex(e => e.TransactionTypeId);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.AccountId);

                entity.HasOne(d => d.TransactionType)
                    .WithMany(p => p.Transactions)
                    .HasForeignKey(d => d.TransactionTypeId);
            });

            modelBuilder.Entity<TreeItemTypes>(entity =>
            {
                entity.HasKey(e => e.TreeItemTypeId);
            });

            modelBuilder.Entity<UserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserContentGroups>(entity =>
            {
                entity.HasIndex(e => e.ApplicationUserId);

                entity.HasIndex(e => e.ContentGroupId);

                entity.HasOne(d => d.ApplicationUser)
                    .WithMany(p => p.UserContentGroups)
                    .HasForeignKey(d => d.ApplicationUserId);

                entity.HasOne(d => d.ContentGroup)
                    .WithMany(p => p.UserContentGroups)
                    .HasForeignKey(d => d.ContentGroupId);
            });

            modelBuilder.Entity<UserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserMessages>(entity =>
            {
                entity.HasKey(e => e.UserMessageId);

                entity.HasIndex(e => e.MessageId);

                entity.HasIndex(e => e.RecieverId);

                entity.HasOne(d => d.Message)
                    .WithMany(p => p.UserMessages)
                    .HasForeignKey(d => d.MessageId);

                entity.HasOne(d => d.Reciever)
                    .WithMany(p => p.UserMessages)
                    .HasForeignKey(d => d.RecieverId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserPermissions>(entity =>
            {
                entity.HasIndex(e => e.PermissionId);

                entity.HasIndex(e => e.ProfileId);

                entity.HasOne(d => d.Permission)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.PermissionId);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.UserPermissions)
                    .HasForeignKey(d => d.ProfileId);
            });

            modelBuilder.Entity<UserProfiles>(entity =>
            {
                entity.HasKey(e => e.ProfileId);

                entity.HasIndex(e => e.AddressId);

                entity.HasIndex(e => e.UserId);

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.UserProfiles)
                    .HasForeignKey(d => d.AddressId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProfiles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.HasIndex(e => e.RoleId);

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<UserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasIndex(e => e.AccountId);

                entity.HasIndex(e => e.AvatarMediaFileId);

                entity.HasIndex(e => e.NormalizedEmail)
                    .HasName("EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName)
                    .HasName("UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.HasIndex(e => e.OfficeId);

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.AvatarMediaFile)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AvatarMediaFileId);

                entity.HasOne(d => d.Office)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.OfficeId);
            });

            modelBuilder.Entity<ValueTypes>(entity =>
            {
                entity.HasKey(e => e.ValueTypeId);
            });

            modelBuilder.Entity<Widgets>(entity =>
            {
                entity.HasKey(e => e.WidgetId);

                entity.HasIndex(e => e.DashboardId);

                entity.HasOne(d => d.Dashboard)
                    .WithMany(p => p.Widgets)
                    .HasForeignKey(d => d.DashboardId);
            });

            modelBuilder.Entity<WorkflowStageItemAttributes>(entity =>
            {
                entity.HasIndex(e => e.StageItemId);

                entity.HasOne(d => d.StageItem)
                    .WithMany(p => p.WorkflowStageItemAttributes)
                    .HasForeignKey(d => d.StageItemId);
            });

            modelBuilder.Entity<WorkflowStageItemOptions>(entity =>
            {
                entity.HasIndex(e => e.WorkflowStageItemId);

                entity.HasOne(d => d.WorkflowStageItem)
                    .WithMany(p => p.WorkflowStageItemOptions)
                    .HasForeignKey(d => d.WorkflowStageItemId);
            });

            modelBuilder.Entity<WorkflowStageItems>(entity =>
            {
                entity.HasKey(e => e.WorkflowStageItemId);

                entity.HasIndex(e => e.ValueTypeId);

                entity.HasIndex(e => e.WorkflowStageId);

                entity.HasOne(d => d.ValueType)
                    .WithMany(p => p.WorkflowStageItems)
                    .HasForeignKey(d => d.ValueTypeId);

                entity.HasOne(d => d.WorkflowStage)
                    .WithMany(p => p.WorkflowStageItems)
                    .HasForeignKey(d => d.WorkflowStageId);
            });

            modelBuilder.Entity<WorkflowStages>(entity =>
            {
                entity.HasKey(e => e.WorkflowStageId);

                entity.HasIndex(e => e.DepartmentId);

                entity.HasIndex(e => e.WorkflowId);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.WorkflowStages)
                    .HasForeignKey(d => d.DepartmentId);

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.WorkflowStages)
                    .HasForeignKey(d => d.WorkflowId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<WorkflowTriggers>(entity =>
            {
                entity.HasKey(e => e.WorkflowTriggerId);

                entity.HasIndex(e => e.ConditionAttributeId);

                entity.HasIndex(e => e.WorkflowStageId);

                entity.HasIndex(e => e.WorkflowStageItemId);

                entity.HasOne(d => d.ConditionAttribute)
                    .WithMany(p => p.WorkflowTriggers)
                    .HasForeignKey(d => d.ConditionAttributeId);

                entity.HasOne(d => d.WorkflowStage)
                    .WithMany(p => p.WorkflowTriggers)
                    .HasForeignKey(d => d.WorkflowStageId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.WorkflowStageItem)
                    .WithMany(p => p.WorkflowTriggers)
                    .HasForeignKey(d => d.WorkflowStageItemId);
            });

            modelBuilder.Entity<Workflows>(entity =>
            {
                entity.HasKey(e => e.WorkflowId);

                entity.HasIndex(e => e.AccountId);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Workflows)
                    .HasForeignKey(d => d.AccountId);
            });
        }
    }
}

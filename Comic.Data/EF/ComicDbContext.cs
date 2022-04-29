using Comic.Data.Configurations;
using Comic.Data.Entities;
using Comic.Data.Extensions;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Comic.Data.EF
{
    public class ComicDbContext : IdentityDbContext<AppUser, AppRole, Guid>
    {
        public ComicDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StatusConfiguration());
            modelBuilder.ApplyConfiguration(new GenderConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorInDetailComicConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryInDetailComicConfiguration());
            modelBuilder.ApplyConfiguration(new ChapterComicConfiguration());
            modelBuilder.ApplyConfiguration(new ComicStripConfiguration());
            modelBuilder.ApplyConfiguration(new DetailCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new DetailComicConfiguration());
            modelBuilder.ApplyConfiguration(new HistoryReadComicOfUserConfiguration());
            modelBuilder.ApplyConfiguration(new ListOfComicsUsersFollowConfiguration());
            modelBuilder.ApplyConfiguration(new UrlImageComicConfiguration());

            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);

            modelBuilder.Seed();
           // base.OnModelCreating(modelBuilder);
        }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Status> Statuses { get; set; }

        public DbSet<Author> Authors { get; set; }

        public DbSet<AuthorInDetailComic> AuthorInDetailComics { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CategoryInDetailComic> CategoryInDetailComics { get; set; }

        public DbSet<ChapterComic> ChapterComics { get; set; }

        public DbSet<ComicStrip> ComicStrips { get; set; }

        public DbSet<DetailCategory> DetailCategories { get; set; }

        public DbSet<DetailComic> DetailComics { get; set; }

        public DbSet<HistoryReadComicOfUser> HistoryReadComicOfUsers { get; set; }

        public DbSet<ListOfComicsUsersFollow> ListOfComicsUsersFollows { get; set; }

        public DbSet<UrlImageComic> UrlImageComics { get; set; }
    }
}

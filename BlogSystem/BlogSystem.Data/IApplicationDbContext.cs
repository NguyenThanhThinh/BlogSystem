using BlogSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;

namespace BlogSystem.Data
{
    public interface IApplicationDbContext : IDisposable
    {
        DbSet<Post> BlogPosts { get; set; }

        DbSet<Page> Pages { get; set; }

        DbSet<Setting> Settings { get; set; }

        DbSet<PostComment> PostComments { get; set; }

        DbSet<AppUser> Users { get; set; }

        DbSet<Video> Videos { get; set; }

        int SaveChanges();

        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;

        DbSet<T> Set<T>() where T : class;
    }
}

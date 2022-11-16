using image_picker.Models;
using Microsoft.EntityFrameworkCore;

namespace image_picker.Data
{
    public class ImagePickerContext : DbContext
    {
        public ImagePickerContext(DbContextOptions<ImagePickerContext> options) : base(options)
        {
            
        }

        public DbSet<ImagePickerModel> Images { get; set; }
        public DbSet<ImageFileModel> Files { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ImagePickerModel>().ToTable("ImagePicker");
            modelBuilder.Entity<ImageFileModel>().ToTable("ImageFile");
        }
    }

}

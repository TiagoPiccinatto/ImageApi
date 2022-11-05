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

    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace image_picker.Models
{
    public class ImageFileModel
    {
        
        public int? id { get; set; }
        [Required]
        public string? filename { get; set; }
        [Required]
        [FileExtensions(Extensions = "jpg,jpeg,png")]
        public IFormFile? file { get; set; }
    }
}

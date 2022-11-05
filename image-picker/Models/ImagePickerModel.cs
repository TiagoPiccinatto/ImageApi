using System.ComponentModel.DataAnnotations;

namespace image_picker.Models
{

    public class ImagePickerModel
    {
        public int id { get; set; }

        [Required]
        public string name { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public string image { get; set; }
        
    }
}

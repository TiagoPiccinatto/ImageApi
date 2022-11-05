using image_picker.Models;

namespace image_picker.Interface
{
    public interface IImagePickerRepository
    {

        Task<List<ImagePickerModel>> GetAllImage();

        Task<ImagePickerModel> GetImage(int id);

        Task<ImagePickerModel> AddImage(ImagePickerModel image);

        Task UpdateImage(ImagePickerModel image);

        Task DeleteImage(int id);

    }
}

using image_picker.Models;

namespace image_picker.Service
{
    public interface InterfaceService
    {
        Task<List<ImagePickerModel>> GetAllImages();
        Task<ImagePickerModel> GetImages(int id);
        Task<ImagePickerModel> AddImages(ImagePickerModel image);
        Task UpdateImages(ImagePickerModel image);
        Task DeleteImages(int id);

    }
}

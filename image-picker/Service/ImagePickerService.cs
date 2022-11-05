using image_picker.Data;
using image_picker.Interface;
using image_picker.Models;
using image_picker.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace image_picker.Service
{

    public class ImagePickerService : InterfaceService
    {
        #region ImagePickerRepository
        private readonly IImagePickerRepository _imagePickerRepository;

        public ImagePickerService(IImagePickerRepository imagePickerRepository)
        {
            _imagePickerRepository = imagePickerRepository;
        }
        #endregion

        #region GetAllImages
        public Task<List<ImagePickerModel>> GetAllImages()
        {        
            var rt = _imagePickerRepository.GetAllImage();
            if (rt == null)
            {
                throw new Exception("There is no data in the database");
            }
            return rt;
        }
        #endregion 
        
        #region GetImagesId
        public async Task<ImagePickerModel> GetImages(int id)
        {
           
           var rt = await _imagePickerRepository.GetImage(id);

            if (rt == null)
            {
                throw new Exception("Your Id Key is Required");
            }
            
            return rt;
                
        }
        #endregion 

        #region Add/Update/Delete/-Images
        public async Task<ImagePickerModel> AddImages(ImagePickerModel image)
        {
            return await _imagePickerRepository.AddImage(image);      
        }
        
        public Task UpdateImages(ImagePickerModel img)
        {
            return _imagePickerRepository.UpdateImage(img);          
        }

        public Task DeleteImages(int id)
        {
            return _imagePickerRepository.DeleteImage(id);
        }
        #endregion
    }
}

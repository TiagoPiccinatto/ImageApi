using image_picker.Data;
using image_picker.Interface;
using image_picker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace image_picker.Repository
{
    
    public class ImagePickerRepository : IImagePickerRepository
    {
        #region context

        ImagePickerContext _context;

        public ImagePickerRepository(ImagePickerContext pickerContext)
        {
            _context = pickerContext;
        }

        #endregion

        #region AddImage
        public async Task<ImagePickerModel> AddImage(ImagePickerModel image)
        {
            try
            {
                _context.Images.Add(image);
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw new Exception("Check The Fild");
            }
             

            return image;
        }
        #endregion

        #region DeleteImage
        public async Task DeleteImage(int id)
        {
            var res = await _context.Images.FindAsync(id);
            if(res == null)
            {

                //throw new Exception("Enter a valid id");
                throw new ArgumentException("Enter a valid id");

            }
            _context.Images.Remove(res);
             await _context.SaveChangesAsync();

        }
        #endregion

        #region UpdateImage
        public async Task UpdateImage(ImagePickerModel img)
        {
            try
            {
                _context.Entry(img).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {

                throw new Exception("Id Not Found in DataBase");
            }          
        }
        #endregion

        #region GetImage and GetImageId
        public async Task<ImagePickerModel> GetImage(int id)
        {
            return await _context.Images.FindAsync(id);          
        }

        public async Task<List<ImagePickerModel>> GetAllImage()
        {         
            return await _context.Images.ToListAsync();           
        }
        #endregion
    }
}

using image_picker.Interface;
using image_picker.Models;
using image_picker.Repository;
using image_picker.Service;
using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace image_picker.Controllers
{

    [Route("api/[controller]")]
    public class ImagePickerController : Controller
    {
        #region IService
        private readonly InterfaceService _Service;

        public ImagePickerController(InterfaceService ImagePickerService)
        {
            _Service = ImagePickerService;
        }
        #endregion

        #region GET
        [HttpGet]
        public async Task<IEnumerable<ImagePickerModel>> GetAllImg()
        {
            return await _Service.GetAllImages();

        }
        #endregion

        #region POST
        [HttpPost]
        public async Task<ActionResult<ImagePickerModel>> AddImage(ImagePickerModel img)
        {
            await _Service.AddImages(img);

            return Ok(img);
        }
        #endregion

        #region GET-ID
        [HttpGet("{id}")]
        public async Task<IActionResult> GetimgID(int id)
        {
            var retorno = await _Service.GetImages(id);

            return Ok(retorno);
        }
        #endregion

        #region PUT
        [HttpPut]
        public async Task<ActionResult> UpdateImage(ImagePickerModel img)
        {
            await _Service.UpdateImages(img);

            return Content("Adicionado Com Sucesso");
        }
        #endregion

        #region DELETE
        [HttpDelete("{id}")]
        public async Task<ActionResult<ImagePickerModel>> DeleteImage(int id)
        {
            await _Service.DeleteImages(id);

            return Ok();
        }
        #endregion

    }

}

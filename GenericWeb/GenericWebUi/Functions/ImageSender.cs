using Microsoft.AspNetCore.Http;
using System.IO;

namespace GenericWebUi.Functions
{
    public class ImageSender : IImageSender
    {
        public async void ImageSend(string Path, IFormFile FileImage)
        {
            using (var stream = new FileStream(Path, FileMode.Create))
            {
                await FileImage.CopyToAsync(stream);
            }
        }
    }
}

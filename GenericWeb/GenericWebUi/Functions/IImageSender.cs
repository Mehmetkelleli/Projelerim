using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace GenericWebUi.Functions
{
    public interface IImageSender
    {
        void ImageSend(string Path, IFormFile FileImage);
    }
}

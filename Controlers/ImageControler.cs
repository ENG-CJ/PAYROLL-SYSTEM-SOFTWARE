using System.Drawing;
using System.IO;
namespace HIMILO_ICT_PAYROLL_SYSTEM.Controlers
{
    internal class ImageControler
    {

        public static MemoryStream SaveImageIntoStream(Image image)
        {
            MemoryStream stream = new MemoryStream();
            image.Save(stream, image.RawFormat);
            return stream;
        }


        public static Image GteImageFromStream(object readder)
        {

            MemoryStream stream = new MemoryStream((byte[])readder);
            Image image = Image.FromStream(stream);
            return image;
        }
    }
}

using System.Web.Http;

namespace FavoriteColor
{
    public class ColorController : ApiController
    {
        private ColorModel _colorModel = new ColorModel();
        public IHttpActionResult Get()
        {
            return Json(_colorModel.GetColors());
        }
    }
}
using Context;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers.Generic
{

    public class AssetController : Controller
    {
        private AppDbContext _context;
        public AssetController(AppDbContext context) {
            this._context = context;
        }

        public IActionResult Add(IFormCollection formCollection)
        {
            if (formCollection.Files.Count > 0)
            {
                foreach (IFormFile formFile in formCollection.Files)
                {
                    Guid id = Guid.NewGuid();
                    string ext = Path.GetExtension(formFile.FileName);
                    Asset asset = new Asset
                    {
                        Id = id,
                        FileName = id.ToString() + ext,
                        OriginalFileName = formFile.FileName,
                        FileExtention = ext,
                        MimeType = formFile.ContentType
                    };
                    using (Stream stream = new FileStream("./Assets/" + asset.FileName,
                        FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                    {
                        formFile.CopyToAsync(stream);
                    }
                    _context.Set<Asset>().Add(asset);
                }
                _context.SaveChanges();
            }
            //return Redirect("/asset");
            return new StatusCodeResult(200);
        }

        public IActionResult GetAsset(Guid id, string path)
        {
            FileStream stream = new FileStream("C:/Users/year1/Pictures/11.jpg", 
                FileMode.Open, FileAccess.Read);
            return new FileStreamResult(stream, "image/jpeg");
        }
    }
}

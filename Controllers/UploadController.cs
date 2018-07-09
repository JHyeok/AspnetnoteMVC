using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspnetNote.MVC6.Controllers
{
    public class UploadController : Controller
    {
        private readonly IHostingEnvironment _environment;

        // 생성자를 통해서 _environment 를 받는다. environment : 환경
        public UploadController(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        // http://www.example.com/Uplaod/ImageUpload
        // http://www.example.com/api/upload
        [HttpPost, Route("api/upload")] // Route = 재정의
        public async Task<IActionResult> ImageUpload(IFormFile file)
        {
            // # 이미지나 파일을 업로드 할 때 필요한 구성
            // 1. Path(경로) - 어디에다 저장할지 결정
            var path = Path.Combine(_environment.WebRootPath, @"images\upload");
            // 이스케이프 시퀀스로 처음에 인식하는데 @ 기호를 통해 있는 그대로 인식하도록.
            // Path.Combine("1\", "2\", "3\", "4\");    // 1\2\3\4
            // 2. Name(파일이름) - Datetime(사람이 많이 이용하면 중복될 수 있음)
            // - GUID(전역 고유 식별자), GUID + Datetime, GUID + GUID
            // 3. Extension(확장자) - png, jpg, txt, pdf
            var fileFullName = file.FileName.Split('.');
            // 파일 이름에 . 이 들어갈 수 있으니 마지막 . 위치를 찾음
            int SplitCount = fileFullName.Length - 1;
            var fileName = $"{Guid.NewGuid()}.{fileFullName[SplitCount]}";

            using (var fileStream = new FileStream(Path.Combine(path, fileName), FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return Ok(new { file = "/images/upload/" + fileName, success = true });
            // # URL 접근 방식
            // ASP.NET - 라우트 이름을 지정했으면 호스트명이 기본적으로 들어가있음. '/' 까지 포함.
            // JavaScript - 호스트명 + api/upload => http://www.example.comapi/upload // '/' 가 들어가지 않음. 그래서 직접 / 를 붙여야함
        }
    }
}

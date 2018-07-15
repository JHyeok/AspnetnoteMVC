using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReflectionIT.Mvc.Paging;

namespace AspnetNote.MVC6
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            // DI 의존성 주입 - ASP.NET MVC 4, 5 의존성 주입하기 위해서는 + Unity(게임x)
            // var user = new User();  // 메서드 안에서 new 객체 선언해서 사용을 하면
            // 메서드 안에서의 지역변수이기 때문에 다른 메서드에서 쓰려면 다른곳에서도 선언을
            // 해서 user 클래스 접근이 가능한데. 그렇게 되면 객체 관리에서 쉽지 않기 때문에
            // 그것을 의존성 주입을 통해서 흔히 생성자에게 주입.
            // 어떤 메서드에서도 동일한 객체를 new 객체 선언 없이 사용할 수 있음.

            // Session - 서비스에 등록
            services.AddSession();
            // Identity

            // Web API 관련 기능

            // 게시판 페이징 기능
#pragma warning disable CS0618 // 형식 또는 멤버는 사용되지 않습니다.
            services.AddPaging();
#pragma warning restore CS0618 // 형식 또는 멤버는 사용되지 않습니다.

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            // 어플리케이션 단위에서의 세션을 사용하겠다
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

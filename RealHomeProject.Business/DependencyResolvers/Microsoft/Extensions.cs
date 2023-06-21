using Microsoft.Extensions.DependencyInjection;
using RealHomeProject.Business.Abstract;
using RealHomeProject.Business.Concrete;
using RealHomeProject.DataAccess.Abstract;
using RealHomeProject.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Business.DependencyResolvers.Microsoft
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services) 
        {
            services.AddScoped<IAboutUsService,AboutUsManager>();
            services.AddScoped<IAboutUsDal, EfAboutUsDal>();

            services.AddScoped<IBlogCategoryService, BlogCategoryManager>();
            services.AddScoped<IBlogCategoryDal, EfBlogCategoryDal>();
            
            services.AddScoped<IBlogCommentService, IBlogCommentService>();
            services.AddScoped<IBlogCommentDal, EfBlogCommentDal>();   
            
            services.AddScoped<IBlogPostService, BlogPostManager>();
            services.AddScoped<IBlogPostDal, EfBlogPostDal>();
            
            services.AddScoped<ICompanyService, CompanyServiceManager>();
            services.AddScoped<ICompanyServiceDal, EfCompanyServiceDal>();
            
            services.AddScoped<IOurPartnerService, OurPartnerManager>();
            services.AddScoped<IOurPartnerDal, EfOurPartnerDal>();

            services.AddScoped<IPopularRentHomeService, PopularRentHomeManager>();
            services.AddScoped<IPopularRentHomeDal, EfPopularRentHomeDal>();

            services.AddScoped<IPrivacyPolicyService, PrivacyPolicyManager>();
            services.AddScoped<IPrivacyPolicyDal, EfPrivacyPolicyDal>();

            services.AddScoped<ITermAndConditionService, TermAndConditionManager>();
            services.AddScoped<ITermAndConditionDal, EfTermAndConditionDal>();

            services.AddScoped<ITestimonialService, TestimonialManager>();
            services.AddScoped<ITestimonialDal, EfTestimonialDal>();

            services.AddScoped<IWhyChooseUsService, WhyChooseUsManager>();
            services.AddScoped<IWhyChooseUsDal, EfWhyChooseUsDal>();
        }
    }
}

using Autofac;
using RealHomeProject.Business.Abstract;
using RealHomeProject.Business.Concrete;
using RealHomeProject.DataAccess.Abstract;
using RealHomeProject.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealHomeProject.Business.DependencyResolvers.AutoFac
{
    public class AutoFacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AboutUsManager>().As<IAboutUsService>().SingleInstance();
            builder.RegisterType<EfAboutUsDal>().As<IAboutUsDal>().SingleInstance();

            builder.RegisterType<BlogCategoryManager>().As<IBlogCategoryService>().SingleInstance();
            builder.RegisterType<EfBlogCategoryDal>().As<IBlogCategoryDal>().SingleInstance();

            builder.RegisterType<BlogCommentManager>().As<IBlogCommentService>().SingleInstance();
            builder.RegisterType<EfBlogCommentDal>().As<IBlogCommentDal>().SingleInstance();

            builder.RegisterType<BlogPostManager>().As<IBlogPostService>().SingleInstance();
            builder.RegisterType<EfBlogPostDal>().As<IBlogPostDal>().SingleInstance();

            builder.RegisterType<CompanyServiceManager>().As<ICompanyService>().SingleInstance();
            builder.RegisterType<EfCompanyServiceDal>().As<ICompanyServiceDal>().SingleInstance();

            builder.RegisterType<OurPartnerManager>().As<IOurPartnerService>().SingleInstance();
            builder.RegisterType<EfOurPartnerDal>().As<IOurPartnerDal>().SingleInstance();

            builder.RegisterType<PopularRentHomeManager>().As<IPopularRentHomeService>().SingleInstance();
            builder.RegisterType<EfPopularRentHomeDal>().As<IPopularRentHomeDal>().SingleInstance();

            builder.RegisterType<PrivacyPolicyManager>().As<IPrivacyPolicyService>().SingleInstance();
            builder.RegisterType<EfPrivacyPolicyDal>().As<IPrivacyPolicyDal>().SingleInstance();

            builder.RegisterType<TermAndConditionManager>().As<ITermAndConditionService>().SingleInstance();
            builder.RegisterType<EfTermAndConditionDal>().As<ITermAndConditionDal>().SingleInstance();

            builder.RegisterType<TestimonialManager>().As<ITestimonialService>().SingleInstance();
            builder.RegisterType<EfTestimonialDal>().As<ITestimonialDal>().SingleInstance();

            builder.RegisterType<WhyChooseUsManager>().As<IWhyChooseUsService>().SingleInstance();
            builder.RegisterType<EfWhyChooseUsDal>().As<IWhyChooseUsDal>().SingleInstance();
        }
    }
}

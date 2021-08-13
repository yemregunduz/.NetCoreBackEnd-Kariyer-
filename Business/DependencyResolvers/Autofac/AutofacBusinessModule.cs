using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Abstract;
using DataAccess.Concrete;
using Core.Utilities.Security.JWT;
using Core.CrossCuttingConcerns.Caching;
using Core.CrossCuttingConcerns.Caching.Microsoft;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule :Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<AdayManager>().As<IAdayService>().SingleInstance();
            builder.RegisterType<EfAdayDal>().As<IAdayDal>().SingleInstance();

            builder.RegisterType<AdayTecrubeManager>().As<IAdayTecrubeService>().SingleInstance();
            builder.RegisterType<EfAdayTecrubeDal>().As<IAdayTecrubeDal>().SingleInstance();

            builder.RegisterType<BolumManager>().As<IBolumService>().SingleInstance();
            builder.RegisterType<EfBolumDal>().As<IBolumDal>().SingleInstance();

            builder.RegisterType<CvManager>().As<ICvService>().SingleInstance();
            builder.RegisterType<EfCvDal>().As<ICvDal>().SingleInstance();

            builder.RegisterType<IlanManager>().As<IIlanService>().SingleInstance();
            builder.RegisterType<EfIlanDal>().As<IIlanDal>().SingleInstance();

            builder.RegisterType<IsverenManager>().As<IIsverenService>().SingleInstance();
            builder.RegisterType<EfIsverenDal>().As<IIsverenDal>().SingleInstance();

            builder.RegisterType<OkulManager>().As<IOkulService>().SingleInstance();
            builder.RegisterType<EfOkulDal>().As<IOkulDal>().SingleInstance();

            builder.RegisterType<PozisyonManager>().As<IPozisyonService>().SingleInstance();
            builder.RegisterType<EfPozisyonDal>().As<IPozisyonDal>().SingleInstance();

            builder.RegisterType<SehirManager>().As<ISehirService>().SingleInstance();
            builder.RegisterType<EfSehirDal>().As<ISehirDal>().SingleInstance();

            builder.RegisterType<SirketManager>().As<ISirketService>().SingleInstance();
            builder.RegisterType<EfSirketDal>().As<ISirketDal>().SingleInstance();

            builder.RegisterType<SistemPersonelManager>().As<ISistemPersonelService>().SingleInstance();
            builder.RegisterType<EfSistemPersonelDal>().As<ISistemPersonelDal>().SingleInstance();


            builder.RegisterType<AuthManager>().As<IAuthService>().SingleInstance();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>().SingleInstance();

            builder.RegisterType<OkulBolumManager>().As<IOkulBolumService>().SingleInstance();
            builder.RegisterType<EfOkulBolumDal>().As<IOkulBolumDal>().SingleInstance();

            builder.RegisterType<AdayOkulBolumManager>().As<IAdayOkulBolumService>().SingleInstance();
            builder.RegisterType<EfAdayOkulBolumDal>().As<IAdayOkulBolumDal>().SingleInstance();

            builder.RegisterType<TakipManager>().As<ITakipService>().SingleInstance();
            builder.RegisterType<EfTakipDal>().As<ITakipDal>().SingleInstance();

            builder.RegisterType<YetenekTipManager>().As<IYetenekTipService>().SingleInstance();
            builder.RegisterType<EfYetenekTipDal>().As<IYetenekTipDal>().SingleInstance();

            builder.RegisterType<YetenekManager>().As<IYetenekService>().SingleInstance();
            builder.RegisterType<EfYetenekDal>().As<IYetenekDal>().SingleInstance();

            builder.RegisterType<AdayYetenekManager>().As<IAdayYetenekService>().SingleInstance();
            builder.RegisterType<EfAdayYetenekDal>().As<IAdayYetenekDal>().SingleInstance();

            builder.RegisterType<GonderiManager>().As<IGonderiService>().SingleInstance();
            builder.RegisterType<EfGonderiDal>().As<IGonderiDal>().SingleInstance();

            builder.RegisterType<YorumManager>().As<IYorumService>().SingleInstance();
            builder.RegisterType<EfYorumDal>().As<IYorumDal>().SingleInstance();



            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();


        }
    }
}

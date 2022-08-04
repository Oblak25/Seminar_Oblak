using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.ViewModel;
using AutoMapper;

namespace Seminar_Oblak.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {

            CreateMap<ProductBinding, Product>();
            CreateMap<Product, ProductViewModel>();
            CreateMap<ProductViewModel, Product>();
            CreateMap<ProductViewModel, ProductUpdateBinding>();
            CreateMap<ProductUpdateBinding, Product>();
            CreateMap<ProductUpdateBinding, ProductViewModel>();


            //CreateMap<ProductViewModel, Product>();
            //CreateMap<ProductViewModel, ProductCategory>();
            //CreateMap<ProductUpdateBinding, ProductViewModel>();

            CreateMap<ProductCategoryBinding, ProductCategory>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<ProductCategoryUpdateBinding, ProductCategory>();
            CreateMap<ProductCategoryViewModel, ProductCategory>();
            CreateMap<ProductCategoryViewModel, ProductCategoryUpdateBinding>();

           

            //CreateMap<ProductUpdateApiBinding, Product>();

            CreateMap<ApplicationUser, ApplicationUserViewModel>();
            CreateMap<AdressBinding, Adress>();
            CreateMap<Adress, AdressViewModel>();
            CreateMap<UserBinding, ApplicationUser>()
                .ForMember(dst => dst.UserName, opts => opts.MapFrom(src => src.Email))
                .ForMember(dst => dst.EmailConfirmed, opts => opts.MapFrom(src => true));
        }

    }
}

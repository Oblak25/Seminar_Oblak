using Seminar_Oblak.Models.Binding;
using Seminar_Oblak.Models.Dbo;
using Seminar_Oblak.Models.ViewModel;
using AutoMapper;
using Seminar_Oblak.Models.Models.Binding;

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

            CreateMap<ApplicationUserViewModel, ApplicationUserUpdateBinding>();
            CreateMap<ApplicationUser, ApplicationUserViewModel>();
            CreateMap<UserBinding, ApplicationUser>()
                .ForMember(dst => dst.UserName, opts => opts.MapFrom(src => src.Email))
                .ForMember(dst => dst.EmailConfirmed, opts => opts.MapFrom(src => true));

            CreateMap<FileStorage, FileStorageViewModel>();
            CreateMap<FileStorage, FileStorageExpendedViewModel>();
            CreateMap<FileStorageViewModel, FileStorage>().
                ForMember(dst => dst.Id, opts => opts.Ignore());
        }

    }
}

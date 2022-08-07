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
         
            CreateMap<ProductCategoryBinding, ProductCategory>();
            CreateMap<ProductCategory, ProductCategoryViewModel>();
            CreateMap<ProductCategoryUpdateBinding, ProductCategory>();
            CreateMap<ProductCategoryViewModel, ProductCategory>();
            CreateMap<ProductCategoryViewModel, ProductCategoryUpdateBinding>();
           
            CreateMap<ApplicationUserViewModel, ApplicationUserUpdateBinding>();
            CreateMap<ApplicationUser, ApplicationUserViewModel>();
            CreateMap<UserBinding, ApplicationUser>()
                .ForMember(dst => dst.UserName, opts => opts.MapFrom(src => src.Email));

            //dodano
            CreateMap<ApplicationUserUpdateBinding, ApplicationUserViewModel>();
            CreateMap<ApplicationUserUpdateBinding, ApplicationUser>();
            CreateMap<ApplicationUser, ApplicationUserViewModel>();
            CreateMap<ApplicationUserViewModel, ApplicationUser>();
            CreateMap<ApplicationUserViewModel, UserBinding>();


            CreateMap<FileStorage, FileStorageViewModel>();
            CreateMap<FileStorage, FileStorageExpendedViewModel>();
            CreateMap<FileStorageViewModel, FileStorage>().
                ForMember(dst => dst.Id, opts => opts.Ignore());
        }

    }
}

using AutoMapper;
using CleanArchitectureMVC.Application.DTOs;
using CleanArchitectureMVC.Application.Products.Commands;

namespace CleanArchitectureMVC.Application.Mappings
{
    public class DTOToCommandMappingProfile: Profile
    {
        public DTOToCommandMappingProfile()
        {
            CreateMap<ProductDTO, ProductCreateCommand>();
            CreateMap<ProductDTO, ProductUpdateCommand>();
        }
    }
}

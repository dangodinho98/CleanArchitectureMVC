using AutoMapper;
using CleanArchitectureMVC.Application.DTOs;
using CleanArchitectureMVC.Domain.Entities;

namespace CleanArchitectureMVC.Application.Mappings
{
    public class DomainToDTOMappingProfile : Profile
    {
        public DomainToDTOMappingProfile()
        {
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }
    }
}

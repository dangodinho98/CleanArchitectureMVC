using CleanArchitectureMVC.Domain.Entities;
using MediatR;

namespace CleanArchitectureMVC.Application.Products.Queries
{
    public class GetProductByIdQuery : IRequest<Product>
    {
        public int Id { get; private set; }
        public GetProductByIdQuery(int id)
        {
            Id = id;
        }
    }
}

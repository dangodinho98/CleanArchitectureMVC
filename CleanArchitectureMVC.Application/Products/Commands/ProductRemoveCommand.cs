using CleanArchitectureMVC.Domain.Entities;
using MediatR;

namespace CleanArchitectureMVC.Application.Products.Commands
{
    public class ProductRemoveCommand: IRequest<Product>
    {
        public int Id { get; private set; }
        public ProductRemoveCommand(int id)
        {
            Id = id;
        }
    }
}

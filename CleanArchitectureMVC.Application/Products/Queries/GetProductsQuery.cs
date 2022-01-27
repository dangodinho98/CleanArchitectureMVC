using CleanArchitectureMVC.Domain.Entities;
using MediatR;
using System.Collections.Generic;

namespace CleanArchitectureMVC.Application.Products.Queries
{
    public class GetProductsQuery : IRequest<IEnumerable<Product>>
    {
    }
}

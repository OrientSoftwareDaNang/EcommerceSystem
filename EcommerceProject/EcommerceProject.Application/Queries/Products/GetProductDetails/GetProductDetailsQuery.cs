﻿using EcommerceProject.Domain.AggregatesModel.ProductAggregate;
using EcommerceProject.Infrastructure.CQRS.Queries;

namespace EcommerceProject.Application.Queries.Products.GetProductById
{
    public class GetProductDetailsQuery : IQuery<Product>
    {
        public int ProductId { get; init; }
    }
}

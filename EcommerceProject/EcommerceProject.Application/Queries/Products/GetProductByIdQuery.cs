﻿using EcommerceProject.Domain.AggregatesModel.ProductAggregate;
using EcommerceProject.Infrastructure.CQRS.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceProject.Application.Queries.Products
{
    public class GetProductByIdQuery : IQuery<Product>
    {
        public int Id { get; init; }

    }
}

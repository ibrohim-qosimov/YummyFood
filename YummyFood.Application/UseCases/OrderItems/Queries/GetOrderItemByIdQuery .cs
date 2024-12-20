﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YummyFood.Domain.Entities;

namespace YummyFood.Application.UseCases.OrderItems.Queries
{
    public class GetOrderItemByIdQuery : IRequest<OrderItem>
    {
        public int OrderItemId { get; set; }
    }

}

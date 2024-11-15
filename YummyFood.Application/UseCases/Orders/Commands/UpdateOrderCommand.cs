﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YummyFood.Domain.Entities.DTOs;
using YummyFood.Domain.Enums;

namespace YummyFood.Application.UseCases.Orders.Commands
{
    public class UpdateOrderCommand : IRequest<ResponseModel>
    {
        public long Id { get; set; }
        public OrderStatus Status { get; set; }

    }
}

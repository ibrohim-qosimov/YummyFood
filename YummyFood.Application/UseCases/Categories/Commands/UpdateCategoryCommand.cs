using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YummyFood.Domain.Entities;

namespace YummyFood.Application.UseCases.Categories.Commands
{
    public class UpdateCategoryCommand : IRequest<Category>
    {
       
        public int GategoryId { get; set; }
        public string Name { get; set; }
        public string Sticker { get; set; }

    }
}

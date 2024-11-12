using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YummyFood.Application.Abstractions;
using YummyFood.Application.UseCases.Categories.Commands;
using YummyFood.Domain.Entities;

namespace YummyFood.Application.UseCases.Categories.Handlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand, Category>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCategoryCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Category> Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {


            var category = await _context.Categories.FirstOrDefaultAsync(x => x.Id == request.GategoryId);
            if (category == null)
            {
                throw new Exception("Not found");
            }


            category.Name = request.Name;
            category.Sticker = request.Sticker;

            _context.Categories.Update(category);
            await _context.SaveChangesAsync(cancellationToken);
            return category;










        }
    }
}

using CarBook.Domain.Entities;
using CarrBook.Application.Features.CQRS.Queries.AboutQueries;
using CarrBook.Application.Features.CQRS.Results.AboutResults;
using CarrBook.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrBook.Application.Features.CQRS.Handlers.AboutHandlers
{
      public class GetAboutByIdQueryHandler
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryHandler(IRepository<About> repository)
        {
            _repository = repository;
        }
        public async Task<GetAboutByIdQueryResult>Handle(GetAboutByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAboutByIdQueryResult
            {
                AboutID = values.AboutID,
                Description = values.Description,
                Title = values.Title,
                ImageUrl = values.ImageUrl
            };
        }




    }
}

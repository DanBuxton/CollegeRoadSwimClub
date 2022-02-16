using AutoMapper;
using AutoMapper.QueryableExtensions;
using CollegeRoadSwimClub.Application.Common.Interfaces;
using CollegeRoadSwimClub.Application.Common.Mappings;
using CollegeRoadSwimClub.Application.Common.Models;
using MediatR;

namespace CollegeRoadSwimClub.Application.Swimmers.Queries.GetSwimmersWithPagination;

public class GetSwimmersWithPaginationQuery : IRequest<PaginatedList<SwimmerDTO>>
{
    public int PageNumber { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}

public class GetSwimmersWithPaginationQueryHandler : IRequestHandler<GetSwimmersWithPaginationQuery, PaginatedList<SwimmerDTO>>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public GetSwimmersWithPaginationQueryHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<PaginatedList<SwimmerDTO>> Handle(GetSwimmersWithPaginationQuery request, CancellationToken cancellationToken)
    {
        return await _context.Swimmers
            .OrderBy(x => x.Username)
            .ProjectTo<SwimmerDTO>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(request.PageNumber, request.PageSize);
    }
}
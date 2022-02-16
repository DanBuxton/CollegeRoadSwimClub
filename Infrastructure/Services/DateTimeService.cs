using CollegeRoadSwimClub.Application.Common.Interfaces;

namespace CollegeRoadSwimClub.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
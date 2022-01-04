using AutoMapper;
using CatchException.Issues;

namespace CatchException;

public class CatchEApplicationAutoMapperProfile : Profile
{
    public CatchEApplicationAutoMapperProfile()
    {
        CreateMap<Issue, IssueDto>();
    }
}
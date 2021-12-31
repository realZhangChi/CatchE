using AutoMapper;

using CatchE.Issues;

namespace CatchE;

public class CatchEApplicationAutoMapperProfile : Profile
{
    public CatchEApplicationAutoMapperProfile()
    {
        CreateMap<Issue, IssueDto>();
    }
}
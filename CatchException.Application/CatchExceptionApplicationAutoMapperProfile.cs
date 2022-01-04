using AutoMapper;
using CatchException.Issues;

namespace CatchException;

public class CatchExceptionApplicationAutoMapperProfile : Profile
{
    public CatchExceptionApplicationAutoMapperProfile()
    {
        CreateMap<Issue, IssueDto>();
    }
}
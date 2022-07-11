using AutoMapper;
using SixMinApi.Dtos;
using SixMinApi.Models;

namespace SixMinApi.Profiles
{
  public class CommandsProfile : Profile
  {
    public CommandsProfile()
    {
      //Source -> Target
      CreateMap<Command, CommandReadDto>();
      CreateMap<CommandReadDto, Command>();
      CreateMap<CommandUpdateDto, Command>();
      CreateMap<CommandCreateDto, Command>();
    }
  }
}
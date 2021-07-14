using AutoMapper;
using CommandHelper.DTOs;
using CommandHelper.Models;

namespace CommandHelper.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            //Source -> Target
            CreateMap<Command, CommandReadDto>();

            CreateMap<CommandCreateDto, Command>();

            CreateMap<CommandUpdateDto, Command>();
        }
    }
}

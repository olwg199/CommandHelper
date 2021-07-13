using AutoMapper;
using CommandHelper.DTOs;
using CommandHelper.Models;

namespace CommandHelper.Profiles
{
    public class CommandsProfile : Profile
    {
        public CommandsProfile()
        {
            CreateMap<Command, CommandReadDto>();
        }
    }
}

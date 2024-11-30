using AutoMapper;
using Kazue.Domain.Entities.Barber;
using Kazue.Domain.Entities.Cliient;
using Kazue.Domain.Entities.QueueEntity;
using Kazue.Domain.Request.Barber;
using Kazue.Domain.Request.Client;
using Kazue.Domain.Request.Queue;
using Kazue.Domain.Response.Barber;
using Kazue.Domain.Response.Client;
using Kazue.Domain.Response.Queue;

namespace Kazue.Application.AutoMapper
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            RequestToEntity();
            EntityToResponse();
        }

        private void RequestToEntity()
        {
            CreateMap<CreateClientRequest, ClientEntity>();
            CreateMap<CreateBarberRequest, BarberEntity>();
            CreateMap<CreateQueueEntryRequest, QueueEntity>();
        }

        private void EntityToResponse()
        {
            CreateMap<ClientEntity, ClientResponse>();
            CreateMap<BarberEntity, BarberResponse>();
            CreateMap<QueueEntity, QueueResponse>()
                .ForMember(dest => dest.ClientName, opt => opt.MapFrom(src => src.Client.Name))
                .ForMember(dest => dest.BarberName, opt => opt.MapFrom(src => src.Barber != null ? src.Barber.Name : "Aguardando"));
        }
    }
}

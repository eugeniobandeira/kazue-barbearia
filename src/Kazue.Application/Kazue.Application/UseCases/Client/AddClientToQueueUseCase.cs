using AutoMapper;
using Kazue.Domain.Entities.QueueEntity;
using Kazue.Domain.Enums;
using Kazue.Domain.Interfaces.Client;
using Kazue.Domain.Interfaces.Queue;
using Kazue.Domain.Response.Queue;

namespace Kazue.Application.UseCases.Client
{
    internal class AddClientToQueueUseCase : IAddClientToQueueUseCase
    {
        private readonly IQueueRepository _queueRepository;
        private readonly IClientRepository _clientRepository;
        private readonly IMapper _mapper;

        public AddClientToQueueUseCase(
            IQueueRepository queueRepository,
            IClientRepository clientRepository,
            IMapper mapper)
        {
            _queueRepository = queueRepository;
            _clientRepository = clientRepository;
            _mapper = mapper;
        }

        public async Task<QueueResponse> Execute(long clientId)
        {
            var client = await _clientRepository.GetByIdAsync(clientId);
            if (client is null)
                throw new ArgumentException("Cliente não localizado");

            var queueEntry = new QueueEntity
            {
                Client = client,
                Status = StatusEnum.Waiting,
                CreatedAt = DateTime.UtcNow
            };

            await _queueRepository.AddAsync(queueEntry);

            return _mapper.Map<QueueResponse>(queueEntry);
        }
    }
}

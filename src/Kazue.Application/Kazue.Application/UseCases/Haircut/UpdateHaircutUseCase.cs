using Kazue.Domain;
using Kazue.Domain.Enums;
using Kazue.Domain.Interfaces.Barber;
using Kazue.Domain.Interfaces.Queue;

namespace Kazue.Application.UseCases.Haircut
{
    internal class UpdateHaircutUseCase : IUpdateHaircutUseCase
    {
        private readonly IQueueRepository _queueRepository;
        private readonly IBarberRepository _barberRepository;

        public UpdateHaircutUseCase(IQueueRepository queueRepository, IBarberRepository barberRepository)
        {
            _queueRepository = queueRepository;
            _barberRepository = barberRepository;
        }

        public async Task<bool> Execute(long queueEntryId, StatusEnum status)
        {
            var queueEntry = await _queueRepository.GetByIdAsync(queueEntryId);
            if (queueEntry is null) 
                throw new ArgumentNullException("Entrada de fila não localizada");

            if (queueEntry.Barber is null)
                throw new ArgumentNullException("Apenas barbeiros podem alterar o status do corte");

            queueEntry.Status = status;
            await _queueRepository.UpdateAsync(queueEntry);

            return true;
        }
    }
}

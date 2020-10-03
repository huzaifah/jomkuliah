using System.Threading.Tasks;
using JomKuliah.Application.SharedKernel.Interfaces;
using JomKuliah.Application.SharedKernel;

namespace JomKuliah.Application.UnitTests
{
    public class NoOpDomainEventDispatcher : IDomainEventDispatcher
    {
        public Task Dispatch(BaseDomainEvent domainEvent)
        {
            return Task.CompletedTask;
        }
    }
}

using System.Threading.Tasks;
using JomKuliah.Application.SharedKernel;

namespace JomKuliah.Application.SharedKernel.Interfaces
{
    public interface IDomainEventDispatcher
    {
        Task Dispatch(BaseDomainEvent domainEvent);
    }
}
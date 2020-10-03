using System.Threading.Tasks;
using JomKuliah.Application.SharedKernel;

namespace JomKuliah.Application.SharedKernel.Interfaces
{
    public interface IHandle<in T> where T : BaseDomainEvent
    {
        Task Handle(T domainEvent);
    }
}
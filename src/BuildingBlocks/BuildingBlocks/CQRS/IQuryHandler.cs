using MediatR;

namespace BuildingBlocks.CQRS;



public interface IQuryHandler<in TQuery,TRessponse>:IRequestHandler<TQuery,TRessponse>
    where TQuery:IQuery<TRessponse>
    where TRessponse : notnull
{
}

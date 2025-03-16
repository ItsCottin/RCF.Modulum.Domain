/*
 * Primeiro commit teste com publicação de package nuget
 * Segundo comentario teste
 */

namespace RCF.Modulum.Domain.Contracts
{
    public interface IEntity<TId> : IEntity
    {
        public TId Id { get; set; }
    }

    public interface IEntity
    {
    }
}
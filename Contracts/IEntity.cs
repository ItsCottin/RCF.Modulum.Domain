﻿/*
 * Primeiro commit teste com publicação de package nuget
 * 
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
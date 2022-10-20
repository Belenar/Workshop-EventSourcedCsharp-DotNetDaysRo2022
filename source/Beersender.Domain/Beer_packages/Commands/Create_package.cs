﻿using Beersender.Domain.Beer_packages.Interfaces;
using Beersender.Domain.Beer_packages.Shared;

namespace Beersender.Domain.Beer_packages.Commands;

public record struct Create_package(Guid AggregateId) : ICommand
{
    internal class Handler : CommandHandler<Create_package, Beer_package>
    {
        public Handler(Func<Guid, IEnumerable<object>> Event_stream, Action<object> Publish_event)
            : base(Event_stream, Publish_event)
        {
        }
    }
}
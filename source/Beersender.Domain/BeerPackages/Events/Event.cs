﻿namespace Beersender.Domain.BeerPackages.Events;

public record Event(Guid PackageId)
{
    public void Apply()
    {
        
    }
}
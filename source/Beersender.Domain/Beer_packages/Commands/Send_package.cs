﻿namespace Beersender.Domain.Beer_packages.Commands;

public record struct Send_package(Guid Package_id) : ICommand;
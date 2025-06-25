﻿using MediatR;

namespace Wallet.Application.Commands;

public abstract class CommandHandler<TCommand> : IRequestHandler<TCommand, Unit> where TCommand 
    : IRequest<Unit>
{
    public abstract Task<Unit> Handle(TCommand command, CancellationToken cancellationToken);
}

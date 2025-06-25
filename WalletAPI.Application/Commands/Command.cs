
using MediatR;

namespace Wallet.Application.Commands;

public abstract class Command : IRequest<Unit> { }
using Abstractions.Commands.CommandsInterfaces;
using System;
using UserControlSystem;
using Utils;
using Zenject;

public class AttackCommandCommandCreator : CommandCreatorBase<IAttackCommand>
{
	[Inject] private AssetsContext _context;
	[Inject] private AttackableValue _groundClicks;

	protected override async void classSpecificCommandCreation(Action<IAttackCommand> creationCallback)
	{
		creationCallback?.Invoke(_context.Inject(new AttackCommand(await _groundClicks)));
	}
}
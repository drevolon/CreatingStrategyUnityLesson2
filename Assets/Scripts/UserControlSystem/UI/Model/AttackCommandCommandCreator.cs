using Abstractions.Commands.CommandsInterfaces;
using System;
using System.Threading;
using UserControlSystem;
using Utils;
using Zenject;

public class AttackCommandCommandCreator : CancellableCommandCreatorBase<IAttackCommand, IAttackable>
{
   

    protected override IAttackCommand createCommand(IAttackable argument) => new AttackCommand(argument);
}
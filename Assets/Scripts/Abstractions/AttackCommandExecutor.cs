using Abstractions.Commands.CommandsInterfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCommandExecutor : IAttackCommand
{
    public IAttackable Target => throw new System.NotImplementedException();
}

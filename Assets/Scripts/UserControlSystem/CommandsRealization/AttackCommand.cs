using Abstractions.Commands.CommandsInterfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UserControlSystem.CommandsRealization
{
    public class AttackCommand : IAttackCommand
    {
        public IAttackable Target { get; }

        public AttackCommand(IAttackable target)
        {
            Target = target;
        }

        public AttackCommand()
        {
        }
    }


}

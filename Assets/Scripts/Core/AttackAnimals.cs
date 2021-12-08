using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackAnimals : CommandExecutorBase<IAttackCommand>, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

    public Transform PivotPoint => throw new System.NotImplementedException();

    [SerializeField] private Transform _unitsParent;

    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;

    private float _health = 100;

    public override void ExecuteSpecificCommand(IAttackCommand command)
    {
        Debug.Log("Press Attack");
    }
}

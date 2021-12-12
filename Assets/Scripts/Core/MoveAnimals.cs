using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class MoveAnimals: CommandExecutorBase<IMoveCommand>, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

    public Transform PivotPoint => throw new System.NotImplementedException();

    [SerializeField] private Transform _unitsParent;

    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;

    private float _health = 100;

    public override Task ExecuteSpecificCommand(IMoveCommand command)
    {
        throw new System.NotImplementedException();
    }
    //public override void ExecuteSpecificCommand(IMoveCommand command)
    //{
    //    Debug.Log("Press Move");
    //}
}



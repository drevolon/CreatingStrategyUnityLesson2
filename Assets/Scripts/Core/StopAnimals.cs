using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

public class StopAnimals : CommandExecutorBase<IStopCommand>, ISelectable
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

    [SerializeField] private Transform _unitsParent;

    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private Sprite _icon;

    private float _health = 100;

    public override void ExecuteSpecificCommand(IStopCommand command)
    {
        Debug.Log("Press STOP");
    }
}

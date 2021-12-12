using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Threading.Tasks;
using UnityEngine;

public sealed class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable 
{
    public float Health => _health;
    public float MaxHealth => _maxHealth;
    public Sprite Icon => _icon;

    public Transform PivotPoint => throw new System.NotImplementedException();

    [SerializeField] private Transform _unitsParent;

    [SerializeField] private float _maxHealth = 1000;
    [SerializeField] private Sprite _icon;
    [SerializeField] private Transform _pivotPoint;

    private float _health = 1000;

    public override async Task ExecuteSpecificCommand(IProduceUnitCommand command)
    {
        Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
    }

    public Vector3 RallyPoint { get; set; }


}
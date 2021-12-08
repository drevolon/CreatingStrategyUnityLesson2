using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;
using Utils;


    public class ProduceUnitCommand : IProduceUnitCommand
    {
        public GameObject UnitPrefab => _unitPrefab;
        [InjectAsset("Chomper")] public GameObject _unitPrefab;
    }


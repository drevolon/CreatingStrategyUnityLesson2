﻿using System;
using Abstractions;
using UnityEngine;

namespace UserControlSystem
{
    [CreateAssetMenu(fileName = nameof(AttackableValue), menuName = "Strategy Game/" + nameof(AttackableValue), order = 0)]
    public class AttackableValue : ScriptableObjectValueBase<IAttackable>
    {
        public IAttackable CurrentValue { get; private set; }
        public Action<IAttackable> OnSelected;

        public void SetValue(IAttackable value)
        {
            CurrentValue = value;
            OnSelected?.Invoke(value);
        }

        
    }

    
}
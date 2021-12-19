using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public sealed class UiViewInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        Container
            .Bind<BottomCenterView>()
            .FromComponentInHierarchy()
            .AsSingle();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    [SerializeField] private GameManager gameManager;
    public override void InstallBindings()
    {
        //For Monobehabiours
        Container.Bind<GameManager>().FromInstance(gameManager).AsSingle();
        //Find in Hierarchy
        Container.Bind<GameManager>().FromComponentInHierarchy().AsSingle().Lazy();
        
        //For Interfaces
        //Container.Bind<IEnemy>.To<Zombie>().AsTransient();
    }
}

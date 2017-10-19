using Entitas;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DebugMessageSystem : ReactiveSystem<GameEntity> {

    public DebugMessageSystem(Contexts context) :  base(context.game)
    {
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        // Sólo nos preocupamos de las entidades que tengan un DebugMessageComponent.
        // Context es la manufacturera: creas, destruyes y filtras entidades con él
        return context.CreateCollector(GameMatcher.DebugMessage);
    }

    protected override bool Filter(GameEntity entity)
    {
        // Es buena practica ejecutar un chequeo final en caso de que
        // alguna entidad haya sido alterada en otro sistema.
        return entity.hasDebugMessage;
    }

    protected override void Execute(List<GameEntity> entities)
    {
        for (int i = 0; i < entities.Count; i++)
        {
            // Accedemos a los componentes de las entidades y su data directamente.
            Debug.Log(entities[i].debugMessage.message);
        }
    }

}

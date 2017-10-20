using System;
using Entitas;

public class CleanupDebugMessageSystem : ICleanupSystem
{

    readonly GameContext _context;
    readonly IGroup<GameEntity> _debugMessages;

    public CleanupDebugMessageSystem(Contexts context)
    {
        _context = context.game;
        _debugMessages = _context.GetGroup(GameMatcher.DebugMessage);
    }

    public void Cleanup()
    {
        // group.GetEntities() siempre nos dará una lista actualizada de las entidades.
        for (int i = 0; i < _debugMessages.GetEntities().Length; i++)
        {
            _debugMessages.GetEntities()[i].Destroy();
        }
    }
}

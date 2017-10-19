using System;
using Entitas;

public class HelloWorldSystem : IInitializeSystem
{
    // Siempre es cómodo tener una referencia al contexto
    // si interactuaremos sobre él.
    readonly GameContext _context;

    public HelloWorldSystem(Contexts context)
    {
        _context = context.game;
    }
    public void Initialize()
    {
        _context.CreateEntity().AddDebugMessage("Hello World!");
    }
}

using System;
using Entitas;

//Inicializador. la loógica de Logear el debug es en DebugMessageSystem.
public class InitializeHelloWorldSystem : IInitializeSystem
{
    // Siempre es cómodo tener una referencia al contexto
    // si interactuaremos sobre él.
    readonly GameContext _context;

    public InitializeHelloWorldSystem(Contexts context)
    {
        _context = context.game;
    }
    public void Initialize()
    {
        _context.CreateEntity().AddDebugMessage("Hello World!");
    }
}

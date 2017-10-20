// Se crea para inicializar y luedo debugear.
public class TutorialSystems : Feature {
    public TutorialSystems (Contexts contexts) : base("Tutorial Systems")
    {
        Add(new InitializeHelloWorldSystem(contexts));
        Add(new LogMouseClickSystem(contexts));
        Add(new DebugMessageSystem(contexts));
        Add(new CleanupDebugMessageSystem(contexts));

    }
}

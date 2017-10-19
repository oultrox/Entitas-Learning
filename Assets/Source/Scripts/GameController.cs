using Entitas;
using UnityEngine;

public class GameController : MonoBehaviour {

    Systems _systems;
    // Use this for initialization
    void Start()
    {
        // Referencia los contextos
        var contexts = Contexts.sharedInstance;

        // Crea el sistema instanciando las features individualmente.
        _systems = new Feature("Systems").Add(new TutorialSystems(contexts));

        //Inicializa todos los IInitializeSystems.
        _systems.Initialize();
    }

    private void Update()
    {
        //llama Execute en todos los sistemas IExecute y ReactiveSystems
        // que fueron ejecutados en este frame.
        _systems.Execute();
        // Llama Cleanup() en todos los ICleanUpSystems.
        _systems.Cleanup();
    }
}

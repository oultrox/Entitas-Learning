using System;
using Entitas;
using UnityEngine;

public class LogMouseClickSystem : IExecuteSystem {

    readonly GameContext _context;

	public LogMouseClickSystem(Contexts context)
    {
        _context = context.game;
    }

    public void Execute()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _context.CreateEntity().AddDebugMessage("Left clicked!");
        }

        if(Input.GetMouseButtonDown(1))
        {
            _context.CreateEntity().AddDebugMessage("Right clicked!");
        }
    }
}

﻿namespace FarmGame;

public class State
{
    public Action Enter { get; set; } = () => { };
    public Action Update { get; set; } = () => { };
    public Action Transitions { get; set; } = () => { };
    public Action Exit { get; set; } = () => { };

    readonly string name;

    public State(string name = "")
    {
        this.name = name;
    }

    public override string ToString() => name;
}

using Godot;
using System;

public class RouteNode : Node
{
    const int INFINITY = 9999;
    public int id;
    public Vector2 pos;
    public bool visited = false;
    public bool current = false;
    public int sourceDist = INFINITY;
    public int prevNode;

    public RouteNode(int nodeId, Vector2 nodeLocation)
    {
        id = nodeId;
        pos = nodeLocation;
    }

    // Called when the node enters the scene tree for the first time.
    // public override void _Ready()
    // {

    // }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}

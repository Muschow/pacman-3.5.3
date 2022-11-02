using Godot;
using System;
using System.Collections.Generic;

public class Movement : Node
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";
    public Dictionary<Vector2, RouteNode> nodeDict;
    public Dictionary<Vector2, RouteNode> InitNodeDict()
    {
        TileMap mazeTm = GetNode<TileMap>("/root/Game/MazeContainer/Maze/MazeTilemap");
        return nodeDict = (Dictionary<Vector2, RouteNode>)mazeTm.Get("nodeDict");
    }

    public void Dijkstras(Vector2 source, Vector2 target) //takes in graph (adjMatrix) and source (Pos) Ghost MUST spawn on node
    {
        nodeDict[source].sourceDist = 0;




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

using Godot;
using System;

[GlobalClass]
public partial class BaseScene : Node2D
{
    [Signal]
    public delegate void SceneChangeEventHandler(int id);
}

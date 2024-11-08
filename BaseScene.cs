using Godot;
using System;

[GlobalClass]
public partial class BaseScene : Node2D
{
    public const int QUIT_ID = -1;
    public const int GAME_SCENE_ID = 0;
    public const int SETTINGS_MENU_ID = 1;
    public const int MAIN_MENU_ID = 2;
    [Signal]
    public delegate void SceneChangeEventHandler(int id);
}

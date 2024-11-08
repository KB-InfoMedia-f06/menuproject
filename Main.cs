using Godot;
using System;

public partial class Main : Node2D
{	
	[Export]
	public PackedScene MainMenuScene {get; set;}
	[Export]
	public PackedScene SettingsMenuScene {get; set;}
	[Export]
	public PackedScene GameScene {get; set;}
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		SetScene(2);
	}

	public void SetScene(int id){
		BaseScene currentScene = null;
		switch (id){
			case BaseScene.QUIT_ID:
				//Quit
				GetTree().Quit();
				break;
			case BaseScene.GAME_SCENE_ID:
				//game start
				currentScene = GameScene.Instantiate<BaseScene>();
				break;
			case BaseScene.SETTINGS_MENU_ID:
				//settings
				currentScene = SettingsMenuScene.Instantiate<BaseScene>();
				break;
			case BaseScene.MAIN_MENU_ID:
				//main menu
				currentScene = MainMenuScene.Instantiate<BaseScene>();
				break;
		}
		if(GetChildCount() > 0){
			GetChild(0).QueueFree();
		}
		currentScene.SceneChange += SetScene;
		AddChild(currentScene);
	}
}

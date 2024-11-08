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
			case -1:
				//Quit
				GetTree().Quit();
				break;
			case 0:
				//game start
				currentScene = GameScene.Instantiate<BaseScene>();
				break;
			case 1:
				//settings
				currentScene = SettingsMenuScene.Instantiate<BaseScene>();
				break;
			case 2:
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

using Godot;
using System;

public partial class MainMenu : BaseScene
{
	public void OnStartButtonPressed(){
		EmitSignal(SignalName.SceneChange, GAME_SCENE_ID);
	}

	public void OnSettingsButtonPressed(){
		EmitSignal(SignalName.SceneChange, SETTINGS_MENU_ID);
	}

	public void OnQuitButtonPressed(){
		EmitSignal(SignalName.SceneChange, QUIT_ID);
	}
}

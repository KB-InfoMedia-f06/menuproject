using Godot;
using System;

public partial class MainMenu : BaseScene
{
	public void OnStartButtonPressed(){
		EmitSignal(SignalName.SceneChange, 0);
	}

	public void OnSettingsButtonPressed(){
		EmitSignal(SignalName.SceneChange, 1);
	}

	public void OnQuitButtonPressed(){
		EmitSignal(SignalName.SceneChange, -1);
	}
}

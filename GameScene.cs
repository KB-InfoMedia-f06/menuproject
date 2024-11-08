using Godot;
using System;

public partial class GameScene : BaseScene
{
	public void OnQuitButtonPressed(){
		EmitSignal(SignalName.SceneChange, 2);
	}
}

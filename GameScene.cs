using Godot;
using System;

public partial class GameScene : BaseScene
{
	CanvasLayer PauseMenuLayer;
    public override void _Ready()
    {
		PauseMenuLayer = GetNode<CanvasLayer>("CanvasLayer");
    }
    public override void _Process(double delta){
		if(Input.IsActionJustPressed("Pause")){
			PauseMenuLayer.Visible = !PauseMenuLayer.Visible;
			GetTree().Paused = !GetTree().Paused;
		}
	}

	public void OnQuitButtonPressed(){
		GetTree().Paused = false;
		EmitSignal(SignalName.SceneChange, MAIN_MENU_ID);
		
	}
}

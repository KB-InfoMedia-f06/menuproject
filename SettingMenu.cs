using Godot;
using System;

public partial class SettingMenu : BaseScene
{
	public void OnBackButtonPressed(){
		EmitSignal(SignalName.SceneChange, MAIN_MENU_ID);
	}
}

﻿using DG.Tweening;
using Homebrew;

public class StarterGame : Starter {
	
	protected override void Setup()
	{
		Toolbox.Add<ProcessingGame>();
		Toolbox.Add<ProcessingBoard>();

		Toolbox.Get<ProcessingSceneLoad>().sceneClosing = CloseScene;
	}

	void CloseScene()
	{
		ProcessingTimer.Default.Dispose();
		DOTween.KillAll();
	}
}


﻿/// This is autogenerated code. If you wish to edit this file press Scene Names -> Save scene names in options. 
namespace Homebrew
{
public enum Scenes
{
sceneKernel = 0,
sceneUI = 1,
sceneGame = 2
}
public static class ExtScenes	{	public static void To(this Scenes s)	{	ProcessingSceneLoad.To((int) s);	}}}

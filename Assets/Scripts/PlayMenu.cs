using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour {


	public void OnMouseDown()
	{
		LoadLvl();
	}

	public void LoadLvl()
	{
		SceneManager.LoadScene("Scene1");
	}

	public void Exit()
	{
		Application.Quit();
	}

	public void Restart()
	{
		SceneManager.LoadScene("Scene1");
	}

	public void ToMainMenu()
	{
		SceneManager.LoadScene("MainMenu");
	}
}

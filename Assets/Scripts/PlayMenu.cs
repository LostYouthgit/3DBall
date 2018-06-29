using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayMenu : MonoBehaviour {


	public void OnMouseDrag()
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
}

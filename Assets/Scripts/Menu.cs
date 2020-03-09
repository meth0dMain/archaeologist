using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
	public void LoadByIndex(int sceneIndex)
	{
		SceneManager.LoadScene(sceneIndex);
	}

	public void quit()
	{
		Application.Quit();
	}
}

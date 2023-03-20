using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void ChangeScene(int num)
    {
        SceneManager.LoadScene(num);
    }

    public void Exit()
    {
        Application.Quit();
    }
}

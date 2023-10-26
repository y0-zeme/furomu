using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Resalt : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Title");
    }
}
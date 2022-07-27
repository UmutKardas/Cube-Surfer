using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainCubeDeadController : MonoBehaviour
{
    [SerializeField] private GameObject gameoverImage;
    [SerializeField] private GameObject restartButton;
    private void Start()
    {
        Time.timeScale = 1;
    }
    public void SetMainCubeDead()
    {
        gameoverImage.SetActive(true);
        restartButton.SetActive(true);
        Time.timeScale = 0;
    }
    public void RestartButton()
    {
        SceneManager.LoadScene(0);

    }
}

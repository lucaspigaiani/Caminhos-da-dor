using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] private GameObject playPanel;
    [SerializeField] private GameObject timerMenuConfig;
    [SerializeField] private GameObject feedback;
    [SerializeField] private GameObject knowMore;

    public void Menu()
    {
        menuPanel.SetActive(!menuPanel.activeInHierarchy);
        playPanel.SetActive(false);
    }

    public void Play()
    {
        playPanel.SetActive(!playPanel.activeInHierarchy);
        menuPanel.SetActive(false);
    }

    public void Feedback() 
    {
        feedback.SetActive(true);
        Invoke(nameof(DeactivateFeedbackPanels), 1f);
    }

    public void KnowMore() 
    {
        knowMore.SetActive(true);
        Invoke(nameof(DeactivateFeedbackPanels), 1f);
    }

    private void DeactivateFeedbackPanels() 
    {
        feedback.SetActive(false);
        knowMore.SetActive(false);
    }

    public void ApprenticeMode() 
    {
        SceneManager.LoadScene(1);
    }

    public void ExperiencedMode()
    {
        SceneManager.LoadScene(2);
    }

    public void Config()
    {
        timerMenuConfig.SetActive(!timerMenuConfig.activeInHierarchy);
    }

    public void QuitApplication() 
    {
        Application.Quit();
    }

}

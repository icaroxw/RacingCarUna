using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject menuPanel;

    void Start()
    {
        menuPanel.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ToggleMenu();
        }
    }

    public void ToggleMenu()
    {
        menuPanel.SetActive(!menuPanel.activeSelf);

        if (menuPanel.activeSelf)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;
    }
}

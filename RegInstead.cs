using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegInstead : MonoBehaviour
{
    public GameObject LoginBox;
    public GameObject RegBox;

    public GameObject ExitPanel;

    public void RegInsteadButton()
    {
        RegBox.SetActive(true);
        LoginBox.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
    public void CancelButton()
    {
        ExitPanel.SetActive(false);
        LoginBox.SetActive(true);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ExitPanel.SetActive(true);
            RegBox.SetActive(false);
            LoginBox.SetActive(false);
        }

    }
    public void GoBack()
    {
        RegBox.SetActive(false);
        LoginBox.SetActive(true);
    }

}

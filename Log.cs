using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Log : MonoBehaviour
{
    public InputField EmailInput;
    public InputField PasswordInput;
    public Button LoginButton;



    // Start is called before the first frame update
    void Start()
    {
        LoginButton.onClick.AddListener(() => {
            StartCoroutine(Main.Instance.Web.Login(EmailInput.text, PasswordInput.text));

            if (Main.Instance.Web.successfully == true)
            {
                Main.Instance.load.ClassLoader();
            }
        });

        
    }

    
}

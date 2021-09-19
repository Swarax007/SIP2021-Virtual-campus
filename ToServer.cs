using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System;

public class ToServer : MonoBehaviour
{
    public Text Errormsg;
    public Text success;
    public Text error;

    public bool successfully;

    void Start()
    {
        // StartCoroutine(Login());
        //  StartCoroutine(RegisterUser());
        
    }

    public IEnumerator Login(string email, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("email", email);
        form.AddField("password", password);

        using (UnityWebRequest www = UnityWebRequest.Post("https://08e5-2401-4900-1b61-fef5-4960-8350-8018-5182.ngrok.io/VirtualClassroom/Login.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                if(www.downloadHandler.text.Contains("Wrong"))
                {
                    error.text = "Wrong Credentials!!";
                }
                else if (www.downloadHandler.text.Contains("found"))
                {
                    error.text = "No such user found.";
                }
                else if (www.downloadHandler.text.Contains("Login"))
                {
                    successfully = true;
                }



            }
        }
    }
 

    public IEnumerator RegisterUser(string name, string email, string password, string repassword, string prn, string branch, string div)
    {
        WWWForm form = new WWWForm();
        
        form.AddField("name", name);
        form.AddField("email", email);
        form.AddField("prn", prn);
        form.AddField("division", div);
        form.AddField("password", password);
        form.AddField("repassword", repassword);
        form.AddField("branch", branch);
    

        // form.AddField("loginNumber", number);

        using (UnityWebRequest www = UnityWebRequest.Post("https://08e5-2401-4900-1b61-fef5-4960-8350-8018-5182.ngrok.io/VirtualClassroom/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();

            if (www.result != UnityWebRequest.Result.Success)
            {
                Debug.Log(www.error);
                
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text.Contains("Passwords"))
                {
                    Errormsg.text = "Passwords donot match!!";
                }
                if (www.downloadHandler.text.Contains("Email"))
                {
                    Errormsg.text = "Email already registered";
                }
                if (www.downloadHandler.text.Contains("New"))
                {
                   
                    success.text = "Your account has been registered.";
                    Errormsg.text = "";
                }
            }
        }
    }



}

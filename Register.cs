using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Register : MonoBehaviour
{
    public InputField EmailInput;
    public InputField PasswordInput;
    public InputField RePasswordInput;
    public InputField Name;
    public InputField prn;
    public InputField Div;

    public Button RegisterButton;

    public InputField BranchInput;

   

 //   public int n;


  /*  public void BranchInputData(int val)
    {
        if (val == 0)
        {
            BranchOutput.text = "CS";
        }
        if (val == 1)
        {
            BranchOutput.text = "IT";
        }
        if (val == 2)
        {
            BranchOutput.text = "E&TC";
        }
        if (val == 3)
        {
            BranchOutput.text = "MECH";
        }
        if (val == 4)
        {
            BranchOutput.text = "CIVIL";
        }
        if (val == 5)
        {
            BranchOutput.text = "AI&DS";
        }
    }
    public void DivInputData(int val)
    {
        if (val == 0)
        {
            DivOutput.text = "A";
        }
        if (val == 1)
        {
            DivOutput.text = "B";
        }
        if (val == 2)
        {
            DivOutput.text = "C";
        }

    } */

    void Start()
    {
        RegisterButton.onClick.AddListener(() => {
            StartCoroutine(Main.Instance.Web.RegisterUser(Name.text, EmailInput.text, PasswordInput.text, RePasswordInput.text, prn.text, BranchInput.text, Div.text));         
        });

    }
 /*   private void Update()
    {
        if(n == 0)
        {
            Errormsg.text = "Email already";
        }
        if (n == 1)
        {
            Errormsg.text = "password doesnt match";
        }
    } */

}

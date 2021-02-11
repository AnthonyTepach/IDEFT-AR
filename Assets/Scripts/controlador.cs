using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Firebase.Auth;

public class controlador : MonoBehaviour
{
    public static controlador instancia;
   
   
    private void Awake()
    {
        if (instancia == null) instancia = this;
        else if (instancia != this) Destroy(gameObject);
        DontDestroyOnLoad(this);
       
    }


    FirebaseAuth auth = FirebaseAuth.DefaultInstance;


    public InputField correo;
    public Text aleta=null;

    

    public void nextScene(string nameScene){
       SceneManager.LoadScene(nameScene);
    }

  

   
    public void login(string email,string password) {

        password pws = new password();


        auth.SignInWithEmailAndPasswordAsync(email, password).ContinueWith(task => {
            if (task.IsCanceled)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync was canceled.");
                return;
            }
            if (task.IsFaulted)
            {
                Debug.LogError("SignInWithEmailAndPasswordAsync encountered an error: " + task.Exception);
                return;
            }

            Firebase.Auth.FirebaseUser newUser = task.Result;
            Debug.LogFormat("User signed in successfully: {0} ({1})",
                newUser.DisplayName, newUser.UserId);
        });

    }



}

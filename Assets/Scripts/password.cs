using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class password : MonoBehaviour
{

    private string passwordToEdit = string.Empty;
   

    void OnGUI()
    {//menos es izquierda,menos es arriba,,
        passwordToEdit = GUI.PasswordField(new Rect(351f, 241f, 178f, 28f), passwordToEdit, "*"[0], 25);

    }

    public  string getPassword() {
        return passwordToEdit;
    }
}

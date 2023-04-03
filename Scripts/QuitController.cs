using UnityEngine;

public class QuitController : MonoBehaviour
{
    void Update(){
        // ctrl + Q (to quit)
        if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && Input.GetKeyDown(KeyCode.Q)){
            Application.Quit();
        }
    }
}

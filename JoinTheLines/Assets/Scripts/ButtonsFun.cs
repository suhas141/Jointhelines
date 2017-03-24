using UnityEngine;
using System.Collections;

public class ButtonsFun : MonoBehaviour
{
    public void ChangeScene(string SceneName)
    {
        Application.LoadLevel(SceneName);
    }
}
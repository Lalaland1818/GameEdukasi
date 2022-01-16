using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pindah_scene : MonoBehaviour
{
    public void MoveScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainWindowManager : MonoBehaviour {

	public void WindowClick()
    {
        SceneManager.LoadScene("Level_Selector");
    }
}

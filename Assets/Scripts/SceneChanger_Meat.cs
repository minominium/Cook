using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger_Meat : MonoBehaviour
{
    // Start is called before the first frame update
    public void SceneChange_Meat()
    {
        SceneManager.LoadScene("02_Meat");
    }
}

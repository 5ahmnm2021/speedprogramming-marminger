using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneSwitch : MonoBehaviour
{

        public void LoadSzene2()
        {
            SceneManager.LoadScene("Szene2");
        }

        public void LoadSzene3()
        {
            SceneManager.LoadScene("Szene3");
        }

        public void LoadSzene1()
        {
            SceneManager.LoadScene("Szene1");
        }
    
}

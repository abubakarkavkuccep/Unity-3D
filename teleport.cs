using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class teleport : SceneManager
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        {
            SceneManager.LoadScene("2", LoadSceneMode.Single);
        }
    }
}

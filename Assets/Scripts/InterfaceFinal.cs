using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InterfaceFinal : MonoBehaviour
{
    public Text textThrown;
    public Text textDestroyed;

    // Start is called before the first frame update
    void Start()
    {
        textThrown.text = "Stones thrown: " + GameManager.currentNumberStonesThrown;
        textDestroyed.text = "Stones destroyed: " + GameManager.currentNumberDestroyedStones;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Click()
    {
        SceneManager.LoadScene("Awake");
    }
}

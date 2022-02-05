using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public static UIController instance;
    public static int scorePoints = 0; //Static para ser acessada na classe Enemy

    public Text textScore;
    public GameObject deathScreen;
    public Image fadeScreen;

    private void Awake() //necessary to active objects in other classes
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = "Score: " + scorePoints.ToString("00000");
    }
}

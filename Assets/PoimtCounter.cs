using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class PoimtCounter : MonoBehaviour
{
    public GameObject green;
    public GameObject red;
    public GameObject yellow;
    public KeyCode pelaaja1;
    public KeyCode pelaaja2;
    public TextMeshProUGUI Pelaaja1;
    public TextMeshProUGUI Pelaaja2;
    int score;
    int score1;
    bool alku = false;
    // Start is called before the first frame update
    void Start()
    {

        Invoke("odotus", 3f);
    }
    void odotus()
    {
        alku = true;
        green.SetActive(true);
        red.SetActive(false);
    }

    //void keltainen()
    //{
    //    Invoke("vihree", 1f);
    //    yellow.SetActive(true);
    //}

    //void vihree()
    //{
    //    alku = true;
    //    green.SetActive(true);
    //    red.SetActive(false);
    //    yellow.SetActive(false);
    //}
    void Update()
    {

        if (Input.GetKeyDown(pelaaja1) && alku == true)
        {


            score++;
            Pelaaja1.text = score.ToString();
            if (score == 20)
            {
                Debug.Log("Pelaaja 1 voitti");
                SceneManager.LoadScene("pelaaja1");
            }


        }
        if (Input.GetKeyDown(pelaaja2) && alku == true)
        {
            score1++;
            Pelaaja2.text = score1.ToString();
            if (score1 == 20)
            {
                Debug.Log("Pelaaja 2 voitti");
                SceneManager.LoadScene("pelaaja2");
            }
        }

        if (Input.GetKeyDown(pelaaja1) && alku == false)
        {
            SceneManager.LoadScene("häviö1");
        }
        if (Input.GetKeyDown(pelaaja2) && alku == false)
        {
            SceneManager.LoadScene("häviö2");
        }
    }
}


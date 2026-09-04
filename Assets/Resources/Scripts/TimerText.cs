using UnityEngine;
using UnityEngine.UI;

public class TimerText : MonoBehaviour
{
    public string Timer;
    float TimeMin;
    float TimeSecond;
    float RoundSecond;
    Text UI;

    // AJOUTER : référence au mur globalblock
    public GameObject globalBlock;
    private bool wallHidden = false;

    void Start()
    {
        UI = this.GetComponent<Text>();
    }

    void Update()
    {
        Timing();
    }

    void Timing()
    {
        if (RoundSecond < 60)
        {
            TimeSecond += Time.deltaTime;
            RoundSecond = Mathf.Round(TimeSecond);
        }
        if (RoundSecond >= 60)
        {
            TimeMin += 1;
            TimeSecond = 0;
            RoundSecond = 0;
        }

        //  affiche le temps en MM:SS
        Timer = string.Format("{0:00}:{1:00}", (int)TimeMin, (int)RoundSecond);
        UI.text = Timer;

        //cache globalblock après 2 minutes
        if (!wallHidden && TimeMin >= 2)
        {
            wallHidden = true;
            if (globalBlock != null)
                globalBlock.SetActive(false);
        }
    }
}
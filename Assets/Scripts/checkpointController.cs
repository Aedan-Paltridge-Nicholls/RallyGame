using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.EventSystems;


public class checkpointController : MonoBehaviour
{   
    [SerializeField] int CheckpointCount;
    [SerializeField] TextMeshProUGUI CheckpointCounter;
    [SerializeField] TextMeshProUGUI TimerTxt;
    [SerializeField] TextMeshProUGUI FinalTime;
    [SerializeField] Canvas FinishScreen;


    private float StageTime;
    private int HitCheckpoints;
    private string CheckpointCountText;
    private bool StageStarted;

    // Start is called before the first frame update
    void Start()
    {
        FinishScreen.enabled = false;
        StageStarted = false;
        GameObject.Find("Events").GetComponent<PauseScript>().enabled = true;

        CheckpointCountText = HitCheckpoints.ToString() + " Of " + CheckpointCount.ToString() ;
        CheckpointCounter.text = CheckpointCountText;
    }

    // Update is called once per frame
    void Update()
    {
        if ( StageStarted )
        {
            StageTime += Time.deltaTime;

            int mins = Mathf.FloorToInt(StageTime / 60);
            int secs = Mathf.FloorToInt(StageTime % 60);
            int tenths = Mathf.FloorToInt((StageTime * 10) % 10);

            TimerTxt.text = string.Format("{0:00}:{1:00}.{2}", mins, secs, tenths);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("checkpoint"))
        {
            string log = "checkpoint hit" + HitCheckpoints.ToString(); 
            Debug.Log(log);
            other.enabled = false;
            HitCheckpoints++;
            CheckpointCountText = HitCheckpoints.ToString() + " of " + CheckpointCount.ToString();
            CheckpointCounter.text = CheckpointCountText;

        }
        if (other.gameObject.tag.Equals("Finish"))
        {
            if(HitCheckpoints == CheckpointCount) 
            { 
                Time.timeScale = 0f;
                string log = "Finished";
                Debug.Log(log);
                other.enabled = false;
                StageStarted = false;
                FinalTime.text = TimerTxt.text; 
                AudioListener.volume = 0f;
                GameObject.Find("Events").GetComponent<PauseScript>().enabled = false;
                FinishScreen.enabled = true;
            }

        }
        if (other.gameObject.tag.Equals("Start"))
        {
            string log = "Started";
            Debug.Log(log);
            other.enabled = false;
            StageStarted = true;
        }
    }
}

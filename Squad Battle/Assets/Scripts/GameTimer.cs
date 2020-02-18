using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{

    public enum TimerType
    {
        NoTime,
        TimeBased
    }

    public static GameTimer Instance;
    [Space(10)]
    [SerializeField] public TimerType LevelTimerType;
    [SerializeField] private float LevelTime;
    [SerializeField] public Text TimerTxt;
    [SerializeField] public Image DriftDistanceImg;

    float currentTime = 0;
    public bool TimeUp = false;
    Text TimerValText;



    private void Awake()
    {
        Instance = this;
    }


    private void OnEnable()
    {
        if (TimerTxt != null)
            TimerTxt.gameObject.SetActive(false);

        currentTime = 0;
        TimeUp = false;

        //LevelTime = GameConstant.DriftTime;

        if (LevelTimerType == TimerType.TimeBased)
        {
            TimerValText = TimerTxt.GetComponent<Text>();
            TimerTxt.gameObject.SetActive(true);
        }
    }

    public void OnTimeUp()
    {
        TimeUp = true;
        SceneManager.LoadScene(2);

        //OnLevelFailed();
    }

    public void OnLevelFailed()
    {
        //if (GameManager._instance)
        //    GameManager._instance.Fail();

        FailCalls();
    }


    private void FailCalls()
    {
        // GAME WISE CALLS
        //UIManager._instance.SetDriftBtns(false);
        //RCC_Settings.Instance.behaviorType = RCC_Settings.BehaviorType.SemiArcade;
        //GameConstant.CurrDrift = 0;
        //DriftDistanceImg.fillAmount = 0;
    }

    int min, seconds;
    int remainingTime = 0;



    void Update()
    {
        if (TimeUp)
            return;
        if (LevelTimerType == TimerType.TimeBased)
        {
            //if (GameConstants.isGameStarted && !GameConstants.isGameOver)
            //{
            currentTime += Time.deltaTime;
            remainingTime = Mathf.CeilToInt(LevelTime - currentTime);
            seconds = remainingTime % 60;
            min = remainingTime / 60;
            //GameConstants.remainingTime = remainingTime;
            TimerValText.text = min + " : " + seconds;
            if (currentTime > LevelTime)
                OnTimeUp();
            //}
        }
    }

}

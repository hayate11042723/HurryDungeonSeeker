using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript2 : MonoBehaviour
{
    [SerializeField]
    public static int minute;
    [SerializeField]
    public static float seconds;
    //�@�O��Update�̎��̕b��
    public static float oldSeconds;
    //�@�^�C�}�[�\���p�e�L�X�g
    public static Text timerText;

    void Start()
    {
        timerText = GetComponentInChildren<Text>();
    }

    void Update()
    {
        seconds += Time.deltaTime;
        if (seconds >= 60f)
        {
            minute++;
            seconds = seconds - 60;
        }
        //�@�l���ς�����������e�L�X�gUI���X�V
        if ((int)seconds != (int)oldSeconds)
        {
            timerText.text = minute.ToString("00") + ":" + ((int)seconds).ToString("00");
        }
        oldSeconds = seconds;
    }
}

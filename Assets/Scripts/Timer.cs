using System;
using TMPro;
using UnityEngine;

public class Timer: MonoBehaviour
{
    [SerializeField] private TMP_Text timerText;

    private double _startTime, _curTime;
    private int _duration;
    private bool _timerInProgress = false;

    private Action _timeComplete;
    
    public void Init(int duration, Action timeComplete)
    {
        _curTime = Util.GetCurrentTimestamp();
        _startTime = _curTime;
        _duration = duration;
        _timeComplete = timeComplete;
        
        ResumeTimer();
    }

    private void FixedUpdate()
    {
        if (_timerInProgress)
        {
            _curTime += Time.deltaTime;
            UpdateTimerText();
            if (_startTime + _duration < _curTime) {
                TimerComplete();
            }
        }
    }

    private void UpdateTimerText()
    {
        int timeRem = _duration - (int) (_curTime - _startTime);
        string timeStr = "";
        if (timeRem > 60) {
            int minute = timeRem / 60;
            if (minute < 10) {
                timeStr += "0";
            }

            timeStr += minute + ":";
            timeRem = timeRem % 60;
        } else {
            timeStr += "00:";
        }

        if (timeRem < 10) {
            timeStr += "0";
        }

        timeStr += timeRem;
        timerText.SetText(timeStr);
    }

    public void ResumeTimer()
    {
        _duration -= (int)(_curTime - _startTime);
        _startTime = _curTime;
        _timerInProgress = true;
    }

    public void PauseTimer()
    {
        _timerInProgress = false;
    }

    private void TimerComplete()
    {
        _timeComplete?.Invoke();
    }
}

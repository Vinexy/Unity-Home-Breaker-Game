using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class countdown : MonoBehaviour
{
    [SerializeField] private Image _time;
    [SerializeField] private Text _timeText;
    private float _currentTime;
    [SerializeField] private float _duration = 30;
    private void Start()
    {
        _currentTime = _duration;
        _timeText.text = _currentTime.ToString();
        StartCoroutine(CountdownTime());
    }

    private IEnumerator CountdownTime()
    {
        while (_currentTime >= 0)
        {
            _time.fillAmount = Mathf.InverseLerp(0, _duration, _currentTime);
            _timeText.text = _currentTime.ToString();
            yield return new WaitForSeconds(1f);
            _currentTime--;
            if(_currentTime == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        yield return null;
    }
}

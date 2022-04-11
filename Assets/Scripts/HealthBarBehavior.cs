using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
    private Slider _slider;
    [SerializeField]
    private HealthBehavior _playerHealth;
    // Start is called before the first frame update
    void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.maxValue = _playerHealth.Health;
    }

    // Update is called once per frame
    void Update()
    {
        _slider.value = _playerHealth.Health;
    }
}

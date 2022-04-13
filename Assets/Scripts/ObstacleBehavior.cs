using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _target;

    private void OnTriggerEnter(Collider other)
    {
        //if (other == _target)
        SceneManager.LoadScene("SampleScene");

    }
}

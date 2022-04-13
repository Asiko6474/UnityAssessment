using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private bool _moving = false;
    [SerializeField]
    private float _speed;

    [SerializeField]
    private GameObject _goal;

    private Camera _camera;

    public float Speed
    { 
        get { return _speed; }
        set { _speed = value; }
    }

    // Start is called before the first frame update
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _camera = Camera.main;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == _goal)
            SceneManager.LoadScene("win");

        else
            SceneManager.LoadScene("SampleScene");

    }


    private void OnMouseDown()
    {
        _moving = true;
    }

    private void OnMouseUp()
    {
        _moving = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Cast a ray from teh camera using the mouse position
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;


        if (_moving == true)
        {   
            //If the ray hit an object
            if (Physics.Raycast(ray, out hitInfo))
            {
                Debug.Log(hitInfo.transform.gameObject);
                //...find the direction to mive in and set the velocity
                Vector3 direction = (hitInfo.point - transform.position).normalized;
                direction = new Vector3(direction.x, 0, direction.z);
                _rigidbody.velocity = direction * _speed * Time.fixedDeltaTime;
            }

        }

    }
}

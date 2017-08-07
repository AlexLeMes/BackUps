using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterSwitch : MonoBehaviour
{

    public GameObject playerOne;
    public GameObject playerTwo;

    Transform playerOneT;
    Transform playerTwoT;

    public GameObject _camera;

    Transform _cameraT;
    Transform _cameraTarget;

    public float xOffSet = 25f;
    public float yOffSet = 25f;
    public float zOffSet = 25f;

    private playerController p1Script;
    private playerController p2Script;

    void Awake()
    {
        p1Script = playerOne.GetComponent<playerController>();
        p2Script = playerTwo.GetComponent<playerController>();

        playerOneT = playerOne.GetComponent<Transform>();
        playerTwoT = playerTwo.GetComponent<Transform>();

        _cameraT = _camera.GetComponent<Transform>();
    }


    void Start()
    {
        p1Script.enabled = true;
        p2Script.enabled = false;

        _cameraTarget = playerOneT;
    }

    void Update()
    {
        _cameraT.transform.position = new Vector3(_cameraTarget.position.x + xOffSet, _cameraTarget.position.y + yOffSet, _cameraTarget.position.z + zOffSet);

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            _cameraTarget = playerOneT;
            p2Script.enabled = false;
            enablePlayerOne();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            _cameraTarget = playerTwoT;
            p1Script.enabled = false;
            enablePlayerTwo();
        }
     }


    void enablePlayerOne()
    { 
        p1Script.enabled = true;
    }

    void enablePlayerTwo()
    {
        p2Script.enabled = true;
    }
}
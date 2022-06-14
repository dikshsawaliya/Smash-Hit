using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class CameraCharacter : MonoBehaviour
{
    public float speed = 1;
    public float incrementFactor = 0.02f;
    public float spawnHelper = 4.5f;
    public GameObject ball;
    public float ballForce = 1400;
    //We use this when we implement UI
    public static bool camMoving = false;
    private CharacterController cameraChar;
    //A boolean whose value will be determined by OnTriggerEnter
    private bool collision = false;
    private Camera _cam;

    
    
    public static int ballCount = 15;
    public Text ballText;
    public GameObject ballTextDisplay;
    public GameObject gameOverPanel;
    public GameObject pauseMenu;

    public GameObject player;

    
    void Start()
    {
        ballCount = 15;
        cameraChar = gameObject.GetComponent<CharacterController>();
        _cam = GetComponent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {

        ballText.text = ballCount.ToString();

        Application.targetFrameRate = 60;
        camMoving = true;
        

        
        //This checks if we have collided
        if (!collision && camMoving)
        {
            cameraChar.Move(Vector3.forward * Time.deltaTime * speed);
            //This is so that the camera's movement will speed up
            speed = speed + incrementFactor;
        }
        else if (collision || !camMoving)
        {
            cameraChar.Move(Vector3.zero);
        }

        if (ballCount > 0)
        {
            if (Input.touchCount > 0 && camMoving)
            {
                for (int i = 0; i < 2; i++)
                {
                    float mousePosx = Input.GetTouch(i).position.x;
                    float mousePosy = Input.GetTouch(i).position.y;
                    if (Input.GetTouch(i).phase == TouchPhase.Began)
                    {
                        GameObject ballRigid;
                        Vector3 BallInstantiatePoint =
                            _cam.ScreenToWorldPoint(new Vector3(mousePosx, mousePosy,
                                _cam.nearClipPlane + spawnHelper));
                        ballRigid = Instantiate(ball, BallInstantiatePoint, transform.rotation) as GameObject;
                        ballRigid.GetComponent<Rigidbody>().AddForce(Vector3.forward * ballForce);
                        ballCount--;
                    }
                }
            }
        }
        else
        {
            speed = 0;
            ballTextDisplay.SetActive(false);
            gameOverPanel.SetActive(true);   
            pauseMenu.SetActive(false);
        }
    }
    
    public void StartCam() {
        camMoving = !camMoving;
    }
    
}
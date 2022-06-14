     using UnityEngine;
     using System.Collections;
     using Unity.VisualScripting;
     using UnityEngine.EventSystems;
     using UnityEngine.SceneManagement;
     using UnityEngine.UI;

     public class PointAndShoot : MonoBehaviour
     {

         public float spawnHelper = 4.5f;
        public GameObject ball;
         public float ballForce = 700;
         private Camera _cam;
        public static int ballCount = 15;

         public Text ballText;
         public GameObject ballTextDisplay;

        // private Touch touch;

         public GameObject gameOverPanel;


         void Start()
         {

             ballCount = 15;
             _cam = GetComponent<Camera>();
         }

         // Update is called once per frame
         void Update()
         {
             Application.targetFrameRate = 60;
             ballText.text = ballCount.ToString();


             /*if (Input.touchCount > 0)
             {
                 if (ballCount != 0)
                 {
                     for (int i = 0; i <= 1; i++)
                     {
                         touch = Input.GetTouch(0);
                         float mousePosx = Input.GetTouch(i).position.x;
                         float mousePosy = Input.GetTouch(i).position.y;
                         if (Input.GetTouch(i).phase == TouchPhase.Began)
                         {
                             GameObject ballRigid;
                             Vector3 BallInstantiatePoint = _cam.ScreenToWorldPoint(new Vector3(mousePosx, mousePosy, _cam.nearClipPlane + spawnHelper));
                             ballRigid = Instantiate(ball, BallInstantiatePoint, transform.rotation) as GameObject;
                             ballRigid.GetComponent<Rigidbody>().AddForce(Vector3.forward * ballForce);
                             ballCount--;
                             //StartCoroutine(DestroyBalls());
                         }
                     }
                 }

                 else
                 {
                     ballText.text = "Were out of ammo! ";
                 }*/
                 
             if (Input.GetMouseButtonDown(0))
             {
                 
                 if (ballCount != 0)
                 {
                    
                         float mousePosx = Input.mousePosition.x;
                         float mousePosy = Input.mousePosition.y;
                         GameObject ballRigid;
                             Vector3 BallInstantiatePoint =
                                 _cam.ScreenToWorldPoint(new Vector3(mousePosx, mousePosy,
                                     _cam.nearClipPlane + spawnHelper));
                             ballRigid = Instantiate(ball, BallInstantiatePoint, transform.rotation) as GameObject;
                             ballRigid.GetComponent<Rigidbody>().AddForce(Vector3.forward * ballForce);
                             ballCount--;
                             //StartCoroutine(DestroyBalls());
                     
                     
                 }

                 if (ballCount <1)
                 {             
                    // Time.timeScale = 0;
                     ballTextDisplay.SetActive(false);
                     gameOverPanel.SetActive(true);   
                 }
                 
            
             

                 IEnumerator DestroyBalls()
                 {
                     yield return new WaitForSeconds(4);
                     DestroyImmediate(ball, true);
                 }
             }

            
         }

        
     }
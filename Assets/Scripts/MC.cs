using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AC
{
    public class MC : MonoBehaviour
    {
        public GameObject bigCloud;
        public GameObject middleCloud;
        public GameObject littleCloud;
        public GameObject rainBarrier;
        public GameObject lningBarrier;
        public GameObject rain;
        public GameObject lightning;
        public GameObject c;

        
        //public CameraController c;
        public float time = 5f;
        public static bool paused;
        public bool raining = false;
        public bool lning = false;
        public int count = 0;
       
        // Start is called before the first frame update
        void Start()
        {
            Time.timeScale = 1;
            
        }


        private void Update()
        {
            time -= 0.05f;
            float t = getTime();
            if (t <= 0)
            {
                c.SetActive(false);
                paused = true;
                Time.timeScale = 0;

            }


            if (count == 20)
            {
                littleCloud.SetActive(false);
                middleCloud.SetActive(false);
                bigCloud.SetActive(true);
            }
            if (count == 10)
            {
                littleCloud.SetActive(false);
                middleCloud.SetActive(true);
                bigCloud.SetActive(false);
            }
            if (count == 0)
            {
                littleCloud.SetActive(true);
                middleCloud.SetActive(false);
                bigCloud.SetActive(false);
            }

            if (Input.GetMouseButton(0))
            {
                rainBarrier.SetActive(true);
                rain.SetActive(true);
                raining = true;
                lning = false;
                
            } else if (Input.GetMouseButton(1)) {
                if (count > 0)
                {
                    rainBarrier.SetActive(false);
                    rain.SetActive(false);
                    lningBarrier.SetActive(true);
                    lightning.SetActive(true);
                    raining = false;
                    lning = true;
                    count--;
                } 
            } else {
                rain.SetActive(false);  
                rainBarrier.SetActive(false);
                lningBarrier.SetActive(false);
                lightning.SetActive(false); 
                raining = false;
                lning= false;
            }   
        
            






            if (!paused)
            {
                Vector3 FollowMouse = Input.mousePosition;
                FollowMouse.z = 10f;
                this.transform.position = Camera.main.ScreenToWorldPoint(FollowMouse);
            }

        }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Cloud")
            {
                time += 5;
                count++;
            }
        }

        private float getTime()
        {
            return time;
        }

        public bool getRaining()
        {
            return raining;
        }

        public bool getLning()
        {
            return lning;
        }

        public bool setLning()
        {
            return lning = false;
        }

        public bool isPaused()
        {
            return paused;
        }


    }
}

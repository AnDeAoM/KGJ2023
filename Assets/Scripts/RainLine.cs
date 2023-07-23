using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AC
{
    public class RainLine : MonoBehaviour
    {
       // public GameObject MainC;
        //public GameObject lightning;
        
        private void Update ()
        {
          //  bool isLning = MainC.GetComponent<MC>().getLning();
          //  if(isLning) 
           // { 
           //     lightning.SetActive(true);
           //     MainC.GetComponent<MC>().setLning();
            //} else
           // {
            //    lightning.SetActive(false);
           // }

            Vector3 FollowMouse = Input.mousePosition;
            FollowMouse.z = 10f;
            this.transform.position = Camera.main.ScreenToWorldPoint(FollowMouse);

           
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour {
    float speed = 10.0f;
    public GameObject player;
    void Update()
    {

        float posCamx = transform.position.x, posCamy = transform.position.y, 
            posPlayerx = player.transform.position.x, posPlayery=player.transform.position.y;
        int multX = 0, multY = 0;
        if ((Input.mousePosition.x >= (Screen.width * 0.95))) multX = 1;
        if ((Input.mousePosition.x <= (Screen.width * 0.05))) multX = -1;

        if ((Input.mousePosition.y >= (Screen.height * 0.95))) multY = 1;
        if ((Input.mousePosition.y <= (Screen.height * 0.05))) multY = -1;
        float moveX = multX * Time.deltaTime * speed, moveXt=0;
        float moveY = multY * Time.deltaTime * speed, moveYt=0;
        if ( (Mathf.Abs(posPlayerx - (posCamx + moveX)) < Mathf.Abs(posCamx - posPlayerx) ) || (Mathf.Abs(posPlayerx-(posCamx+moveX))<8 ))
            moveXt = moveX;
        if ((Mathf.Abs(posPlayery - (posCamy + moveY)) < Mathf.Abs(posCamy - posPlayery)) || (Mathf.Abs(posPlayery - (posCamy + moveY)) < 4))
            moveYt = moveY;
        transform.position += new Vector3(moveXt, moveYt, 0.0f);
        //transform.position += 

    }

}

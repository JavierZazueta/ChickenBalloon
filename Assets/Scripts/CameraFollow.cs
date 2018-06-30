using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public PlayerMove currentBalloon;//camera's target
    //public Balloon[] balloons;

    private Vector3 pos;
    private float xOffset = 3.2f;
    private float yOffset = 7;
    private Vector3 newPos;
    private Vector3 accel;

    void Start()
    {
        //calibrateAccelerometer();
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Yo");
        }
    }

    void LateUpdate()
    {
        pos = currentBalloon.transform.position;
        transform.position = new Vector3(pos.x, pos.y, -10);

        accel = Input.acceleration;

        newPos = new Vector3(currentBalloon.transform.position.x - (accel.x * xOffset),
                             currentBalloon.transform.position.y - (accel.y * yOffset),
                             transform.position.z);
        transform.position = newPos;
    }

    //http://answers.unity3d.com/questions/927515/accelerometer-calibration-2.html

}

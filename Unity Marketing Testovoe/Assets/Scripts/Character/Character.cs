using UnityEngine;

public class Character : MonoBehaviour
{   [SerializeField]
    private float _speedForward;
    [SerializeField]
    private float _speedRightLeft;

    public void Movement()
    {
        var moveX = Input.GetAxis("Mouse X");
        transform.position  = new Vector3 (transform.position.x + moveX * _speedRightLeft, transform.position.y, transform.position.z + _speedForward);      
    }
}

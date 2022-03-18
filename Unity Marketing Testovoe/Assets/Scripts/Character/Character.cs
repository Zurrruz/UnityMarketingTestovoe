using UnityEngine;

public class Character : MonoBehaviour
{
    [SerializeField]
    private float _speed;

    public void Movement()
    {
        var moveX = Input.GetAxis("Mouse X");
        transform.position  = new Vector3 (transform.position.x + moveX * 0.5f, transform.position.y, transform.position.z + _speed);      
    }
}

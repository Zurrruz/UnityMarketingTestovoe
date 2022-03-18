using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField]
    Character _character;
   
    void Update()
    {
        if(Input.GetMouseButton(0))
        _character.Movement();
    }
}

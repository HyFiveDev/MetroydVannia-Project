using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    private InputControl inputAction;
    private InputAction fireOne;
    private InputAction fireTwo;
    
    private void Awake()
    {
        inputAction = new InputControl();
       

    }

    // Update is called once per frame
    void Update()
    {
         
    }
}

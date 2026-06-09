using System;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.InputSystem;


public class MovingPlayer : MonoBehaviour
{
    #region variaveis
    //Declarando variáveis.
    private InputControl inputAction;

    //Variavel para input de movimentação. Recebe o vetor
    public float moveX => inputAction.Player.Move.ReadValue<Vector2>().x;
   
    private bool Jump => inputAction.Player.Jump.WasPressedThisFrame();
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] GroundChecker groundChecker;
    //variaveis para pulo
    private float jumpForce = 5f;
    private Rigidbody2D rb;
    #endregion
    private void Awake()
    {
        //Inicializar o inputSystem
        inputAction = new InputControl();
        rb = GetComponent<Rigidbody2D>();
    

        //habilitar
        inputAction.Enable();
    }

    private void FixedUpdate()
    {
        Vector2 movimentVector = new Vector2(moveX, 0);
        rb.linearVelocityX = moveX * moveSpeed;
        

        
    }

    // Update is called once per frame
    void Update()
    {
        Jumping();
    }

    private void Jumping()
    {
        if (groundChecker.IsGrounded() && Jump) rb.linearVelocityY = jumpForce;
    }


}

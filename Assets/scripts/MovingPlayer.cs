using System;
using System.Runtime.CompilerServices;
using UnityEngine;


public class MovingPlayer : MonoBehaviour
{
    #region variaveis
    //Declarando variáveis.
    private InputControl inputAction;

    //Variavel para input de movimentação. Recebe o vetor
    public float moveX => inputAction.Player.Move.ReadValue<Vector2>().x;
    private bool Jump => inputAction.Player.Jump.WasPressedThisFrame();
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] Warrioranim warriorAnim;

    //variaveis para pulo
    public bool isGrounded = true;
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
    // Update is called once per frame
    void Update()
    {
        Vector2 movimentVector = new Vector2(moveX,0);
        transform.Translate(movimentVector * moveSpeed * Time.deltaTime);
        warriorAnim.BoolAnim("Running", moveX != 0);

        if (isGrounded && Jump) rb.linearVelocityY = jumpForce;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor")) isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("floor")) isGrounded = false;
    }
}

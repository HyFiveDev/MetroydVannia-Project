using UnityEditor.Tilemaps;
using UnityEngine;

public class Warrioranim : MonoBehaviour
{
    [SerializeField] MovingPlayer movingPlayer;

    Animator playerAnim;
    private bool isRunning;
    private SpriteRenderer sprite;
    void Start()
    {
        playerAnim = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        if (movingPlayer.horizontalInput != 0) isRunning = true;
        else if (movingPlayer.horizontalInput == 0) playerAnim.SetTrigger("Dashing");
        else isRunning = false;

        

        if (movingPlayer.horizontalInput < 0 && sprite.flipX == false) sprite.flipX = true;
        else if (movingPlayer.horizontalInput > 0 && sprite.flipX == true) sprite.flipX = false;

            playerAnim.SetBool("Running", isRunning);
 
            playerAnim.SetBool("Attacking", Input.GetKeyDown(KeyCode.Mouse0));
            playerAnim.SetBool("EspecialAttack", Input.GetKeyDown(KeyCode.Mouse1));


    }
}

using UnityEngine;

public class Warrioranim : MonoBehaviour
{
    Animator playerAnim;
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        playerAnim.SetBool("Attacking", Input.GetKeyDown(KeyCode.E));
    }
}

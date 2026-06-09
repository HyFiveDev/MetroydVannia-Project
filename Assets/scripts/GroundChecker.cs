using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    [SerializeField] private Transform checkerPosition;
    [SerializeField] private Vector2 checkerSize;
    [SerializeField] private LayerMask groundLayer;
    public bool IsGrounded()
    {
        //overlap box é eu vou por uma fração de segundo criar o tipo de um collider do tipo caixa (quadrado)
        //e verificar se esse colider está collidindo com algo ou n.
        return Physics2D.OverlapBox(checkerPosition.position, checkerSize, 0f, groundLayer);
    }

    private void OnDrawGizmosSelected()
    {
        //gizmos serve para debugar. Ele cria uma cor no collider
        if (checkerPosition == null) return;
        if (IsGrounded()) Gizmos.color = Color.red;
        else Gizmos.color = Color.green;
        Gizmos.DrawWireCube(checkerPosition.position, checkerSize);
    }
}

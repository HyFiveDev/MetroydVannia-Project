using UnityEngine;

public class MovingPlayer : MonoBehaviour
{
    public float horizontalInput;


    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        Vector2 movimento = new Vector2(horizontalInput, 0);
        transform.Translate(movimento);

}
}

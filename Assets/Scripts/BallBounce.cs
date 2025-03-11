using UnityEngine;

public class BallBounce : MonoBehaviour
{
    [SerializeField] private GameObject _leftWall;
    [SerializeField] private GameObject _rightWall;
    private float _speed = 7.5f;


    void Update()
    {
        // The ball starts moving to the right using the _speed variable.
        transform.position += Vector3.right * _speed * Time.deltaTime;

        // Defining the vectors as the difference between the ball's position and the wall's position.
        Vector3 _toRightWall = _rightWall.transform.position - transform.position;
        Vector3 _toLeftWall = _leftWall.transform.position - transform.position;

        // If the dot product between the wall and the ball's position is less than 0, the ball's speed is reversed.
        if (Vector3.Dot(Vector3.right, _toRightWall) < 0)
        {
            // Reversing the speed changes the direction of the ball.
            _speed = -_speed;
        }

        if (Vector3.Dot(Vector3.left, _toLeftWall) < 0)
        {
            _speed = -_speed;
        }
    }
}

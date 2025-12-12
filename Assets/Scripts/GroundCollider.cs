using UnityEngine;

public class GroundCollider : MonoBehaviour
{
    private int _overlaps;
    public bool isOverlapping
    {
        get
        {
            return _overlaps > 0;
        }
    }
    void OnTriggerEnter2D()
    {
        _overlaps++;
    }

    void OnTriggerExit2D()
    {
        _overlaps--;
    }
    private void Start()
    {
        OnTriggerEnter2D();
        OnTriggerExit2D();
    }
}

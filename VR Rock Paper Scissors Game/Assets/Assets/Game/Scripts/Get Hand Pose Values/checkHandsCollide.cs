using UnityEngine;
using UnityEngine.Events;

public class checkHandsCollide : MonoBehaviour
{
    public UnityEvent onCollide;
    public UnityEvent offCollide;

    private void OnTriggerEnter(Collider other)
    {
        onCollide.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        offCollide.Invoke();
    }
}

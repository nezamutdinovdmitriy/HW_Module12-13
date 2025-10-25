using UnityEngine;

public class Player : MonoBehaviour
{
    public int СoinCount { get; private set; }

    public void AddCoin() => СoinCount++;
}

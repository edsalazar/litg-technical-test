using UnityEngine;

[CreateAssetMenu(fileName = "New Gun3", menuName = "Gun Scriptable Objects/Gun3")]
public class Gun3SO : GunSO
{
    [Range(0.5f, 3f)]
    public float timeToStop;
}

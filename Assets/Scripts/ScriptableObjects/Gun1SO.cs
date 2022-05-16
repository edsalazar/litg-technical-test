
using UnityEngine;

[CreateAssetMenu(fileName = "New Gun1", menuName = "Gun Scriptable Objects/Gun1")]
public class Gun1SO : GunSO
{
    [Range(0f, 90f)]
    public float angle;
}

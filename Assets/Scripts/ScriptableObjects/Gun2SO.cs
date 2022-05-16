using UnityEngine;

[CreateAssetMenu(fileName = "New Gun2", menuName = "Gun Scriptable Objects/Gun2")]
public class Gun2SO : GunSO
{
    [Range(0.5f, 2f)]
    public float magneticArea;

}

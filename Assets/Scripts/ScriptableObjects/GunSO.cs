using UnityEngine;

[CreateAssetMenu(fileName = "New Gun", menuName = "Gun Scriptable Objects/Gun")]
public class GunSO : ScriptableObject
{
    [Range(300f, 1000f)]
    public float force;
}

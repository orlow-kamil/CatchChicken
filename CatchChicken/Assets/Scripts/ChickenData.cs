using UnityEngine;

[CreateAssetMenu(fileName = "ChickenData", menuName = "ScriptableObjects/ChickenData")]
public class ChickenData : ScriptableObject
{
    public static readonly float MaxStunTime = 3.0f;

    [SerializeField] private float speed;
    [SerializeField] private float stunTime;
    [SerializeField][Range(0,1)] private float catchable;

    public float Speed 
    {
        get => speed; 
        set
        {
            speed = (value >= 0)
                ? value
                : 0f;
        }
    }
    public float StunTime 
    {
        get => stunTime; 
        set
        {
            stunTime = (value < 0)
                ? 0f
                : (value > MaxStunTime)
                    ? MaxStunTime
                    : value;
        }
    }
    public float Catchable 
    {
        get => catchable; 
        set
        {
            catchable = (value < 0)
                ? 0f
                : (value > 1)
                    ? 1f
                    : value;
        }
    }
}


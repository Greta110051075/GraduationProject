using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AffectionController : MonoBehaviour
{
    public IntegerVariable maleAffection;
    public IntegerVariable femaleAffection;
    public IntegerVariable money;

    public void IncreaseAffection(int amount)
    {
        maleAffection.Value += amount;
        femaleAffection.Value += amount;
        money.Value += amount;
    }
}

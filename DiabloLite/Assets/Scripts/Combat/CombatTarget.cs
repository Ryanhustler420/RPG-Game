using System;
using System.Collections;
using UnityEngine;

namespace RPG.Combat
{
    public class CombatTarget : MonoBehaviour
    {

        private float health = 100f;

        public Boolean isAlive()
        {
            return health > 0;
        }

        public void damage(float damageValue)
        {
            if (isAlive())
                health -= damageValue;
            else Destroy(gameObject);
        }
    }
}

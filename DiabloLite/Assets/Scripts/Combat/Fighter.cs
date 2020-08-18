using System;
using System.Collections;
using UnityEngine;
using UnityEngine.AI;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        CombatTarget target;

        float damagePower = 20;
        float offsetDistance = 1;

        public void Attack(CombatTarget combatTarget)
        {
            target = combatTarget;
        }

        void Update()
        {
            if(hasTarget())
            {
                float distance = Vector3.Distance(this.transform.position, target.transform.position);
                if(distance <= offsetDistance)
                {
                    // stop player();
                    // start attacking();
                }
            }
            
            //StartCoroutine(poke());
        }

        public IEnumerator poke()
        {
            if (hasTarget()) target.damage(damagePower);
            yield return new WaitForSeconds(2);
        }

        public Boolean hasTarget()
        {
            return target != null;
        }

    }
}

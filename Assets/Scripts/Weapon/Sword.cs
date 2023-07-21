using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Weapon
{
    public class Sword : AbstractWeapon
    {
        public override void Attack()
        {
            Debug.Log(weaponName + "Đâm , chém,combo..... " + damage);
        }
    }
}

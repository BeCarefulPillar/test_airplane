using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunkang {
    class sunFlowerBullet : bulletBase {
        public sunFlowerBullet(float speed, float cooldown){
            this.speed = speed;
            this.cooldown = cooldown;
        }
    }
}

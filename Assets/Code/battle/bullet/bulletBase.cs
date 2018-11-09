using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SunKang {
    class bulletBase {
        public bulletBase(float speed, float cooldown) {
            this.speed = speed;
            this.cooldown = cooldown;
        }
        protected float speed {set;get; }
        protected float cooldown {set;get; }
    }
}

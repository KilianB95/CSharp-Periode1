using System;
using System.Collections.Generic;
using System.Text;

namespace Smash
{
    public interface ICharacter
    {
        void SetHorizontalDirection(float dx);
        void PerformAttack();
        void StartJump();
    }
}

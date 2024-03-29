﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Backlogs.States
{
    public class TestedState(Item item) : ItemState(item)
    {
        public override void SetState() => item.ChangeState(new TestedState(item));

        public override void NextState() => throw new NotImplementedException();

        public override void PreviousState() => item.ChangeState(new TestingState(item));
    }
}

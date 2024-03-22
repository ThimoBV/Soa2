﻿using Domain.Pipelines.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Pipelines.Actions.TestAction
{
    public class TestNUnitAction : PipelineActions
    {
        public override void AcceptPipeline(IPipelineVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}

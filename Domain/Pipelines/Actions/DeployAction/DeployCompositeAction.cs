﻿using Domain.Pipelines.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Pipelines.Actions.DeployAction
{
    public class DeployCompositeAction : PipelineCompositeActions
    {
        public override void AcceptPipeline(IPipelineVisitor visitor)
        {
            visitor.Visit(this);
            base.AcceptPipeline(visitor);
        }
    }
}

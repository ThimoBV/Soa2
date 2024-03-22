﻿using Domain.Pipelines.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Pipelines.Actions.AnalyzeAction
{
    public class AnalyzeCompositeAction : PipelineCompositeActions
    {
        public override void AcceptPipeline(IPipelineVisitor visitor)
        {
            visitor.Visit(this);
            base.AcceptPipeline(visitor);
        }
    }
}

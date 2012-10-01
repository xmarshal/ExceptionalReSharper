﻿using CodeGears.ReSharper.Exceptional.Model;
using JetBrains.ReSharper.Daemon.CSharp.Stages;
using JetBrains.ReSharper.Psi.CSharp.Tree;
using JetBrains.ReSharper.Psi.Tree;

namespace CodeGears.ReSharper.Exceptional
{
    internal class NullProcessContext : IProcessContext
    {
        public void StartProcess(IAnalyzeUnit analyzeUnit)
        {
        }

        public void EndProcess(CSharpDaemonStageProcessBase process)
        {
        }

        public void EnterTryBlock(ITryStatement tryStatement)
        {
        }

        public void LeaveTryBlock()
        {
        }

        public void EnterCatchClause(ICatchClause catchClauseNode)
        {
        }

        public void LeaveCatchClause()
        {
        }

        public void Process(IThrowStatement throwStatement)
        {
        }

        public void Process(ICatchVariableDeclaration catchVariableDeclaration)
        {
        }

        public void Process(IReferenceExpression invocationExpression)
        {
        }

        public void Process(IDocCommentBlockNode docCommentBlockNode)
        {
        }

        public void EnterAccessor(IAccessorDeclaration accessorDeclarationNode)
        {
        }

        public void LeaveAccessor()
        {
        }
    }
}
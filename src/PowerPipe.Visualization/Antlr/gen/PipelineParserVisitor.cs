﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/maksym.vorchakov/Work/Documents/Projects/Personal/PowerPipe/src/PowerPipe.Visualization/Antlr/PipelineParser.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419
#pragma warning disable CS3021

namespace PowerPipe.Visualization.Antlr {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="PipelineParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IPipelineParserVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="PipelineParser.start"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStart([NotNull] PipelineParser.StartContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PipelineParser.step"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStep([NotNull] PipelineParser.StepContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PipelineParser.addStep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddStep([NotNull] PipelineParser.AddStepContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PipelineParser.addIfStep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddIfStep([NotNull] PipelineParser.AddIfStepContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PipelineParser.addIfElseStep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAddIfElseStep([NotNull] PipelineParser.AddIfElseStepContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PipelineParser.ifStep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStep([NotNull] PipelineParser.IfStepContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="PipelineParser.parallelStep"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParallelStep([NotNull] PipelineParser.ParallelStepContext context);
}
} // namespace PowerPipe.Visualization.Antlr

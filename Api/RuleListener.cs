using System;
namespace EasyRulesCsharp.Api {
	/// <summary>
	/// A listener for rules execution events.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public interface RuleListener {
		/// <summary>
		/// Triggered before the evaluation of a rule.
		/// </summary>
		/// <param name="rule">being evaluated</param>
		/// <param name="facts">known before evaluating the rule</param>
		/// <returns>true if the rule should be evaluated, false otherwise</returns>
		bool BeforeEvaluate(ref Rule rule, ref Facts facts);
		/// <summary>
		/// Triggered after the evaluation of a rule.
		/// </summary>
		/// <param name="rule">that has been evaluated</param>
		/// <param name="facts">known after evaluating the rule</param>
		/// <param name="evaluationResult">true if the rule evaluated to true, false otherwise</param>
		void AfterEvaluate(ref Rule rule, ref Facts facts, ref bool evaluationResult);
		/// <summary>
		/// Triggered before the execution of a rule.
		/// </summary>
		/// <param name="rule">the current rule</param>
		/// <param name="facts">known facts before executing the rule</param>
		void BeforeExecute(ref Rule rule, ref Facts facts);
		/// <summary>
		/// Triggered after a rule has been executed successfully.
		/// </summary>
		/// <param name="rule">the current rule</param>
		/// <param name="facts">known facts after executing the rule</param>
		void OnSuccess(ref Rule rule, ref Facts facts);
		/// <summary>
		/// Triggered after a rule has failed.
		/// </summary>
		/// <param name="rule">the current rule</param>
		/// <param name="facts">known facts after executing the rule</param>
		/// <param name="exception">the exception thrown when attempting to execute the rule</param>
		void OnFailure(ref Rule rule, ref Facts facts, ref Exception exception);

	}

}

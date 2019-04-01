using System;
namespace org.jeasy.rules.api {
	/// <summary>
	/// A listener for rules engine execution events.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public interface RulesEngineListener {
		/// <summary>
		/// Triggered before evaluating the rule set.
		/// <strong>When this listener is used with a {@link InferenceRulesEngine}, this method will be triggered before the evaluation of each candidate rule set in each iteration.</strong>
		/// </summary>
		/// <param name="rules">to fire</param>
		/// <param name="facts">present before firing rules</param>
		void BeforeEvaluate(ref Rules rules, ref Facts facts);
		/// <summary>
		/// Triggered after executing the rule set
		/// <strong>When this listener is used with a {@link InferenceRulesEngine}, this method will be triggered after the execution of each candidate rule set in each iteration.</strong>
		/// </summary>
		/// <param name="rules">fired</param>
		/// <param name="facts">present after firing rules</param>
		void AfterExecute(ref Rules rules, ref Facts facts);

	}

}

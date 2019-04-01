using System;
namespace org.jeasy.rules.core {
	class DefaultRuleListener : org.jeasy.rules.api.RuleListener  {
		private const org.slf4j.Logger LOGGER = LoggerFactory.getLogger(DefaultRuleListener.class);

		public bool BeforeEvaluate(ref org.jeasy.rules.api.Rule rule, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public void AfterEvaluate(ref org.jeasy.rules.api.Rule rule, ref org.jeasy.rules.api.Facts facts, ref bool evaluationResult) {
			throw new System.Exception("Not implemented");
		}
		public void BeforeExecute(ref org.jeasy.rules.api.Rule rule, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public void OnSuccess(ref org.jeasy.rules.api.Rule rule, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public void OnFailure(ref org.jeasy.rules.api.Rule rule, ref org.jeasy.rules.api.Facts facts, ref Exception exception) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Triggered after a rule has failed.
		/// </summary>
		/// <param name="rule">the current rule</param>
		/// <param name="facts">known facts after executing the rule</param>
		/// <param name="exception">the exception thrown when attempting to execute the rule</param>
		public void OnFailure(ref Rule rule, ref Facts facts, ref Exception exception) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Triggered after a rule has been executed successfully.
		/// </summary>
		/// <param name="rule">the current rule</param>
		/// <param name="facts">known facts after executing the rule</param>
		public void OnSuccess(ref Rule rule, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Triggered before the execution of a rule.
		/// </summary>
		/// <param name="rule">the current rule</param>
		/// <param name="facts">known facts before executing the rule</param>
		public void BeforeExecute(ref Rule rule, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Triggered after the evaluation of a rule.
		/// </summary>
		/// <param name="rule">that has been evaluated</param>
		/// <param name="facts">known after evaluating the rule</param>
		/// <param name="evaluationResult">true if the rule evaluated to true, false otherwise</param>
		public void AfterEvaluate(ref Rule rule, ref Facts facts, ref bool evaluationResult) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Triggered before the evaluation of a rule.
		/// </summary>
		/// <param name="rule">being evaluated</param>
		/// <param name="facts">known before evaluating the rule</param>
		/// <returns>true if the rule should be evaluated, false otherwise</returns>
		public bool BeforeEvaluate(ref Rule rule, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}

	}

}

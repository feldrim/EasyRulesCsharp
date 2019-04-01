using EasyRulesCsharp.EasyRulesCsharp.Api;
namespace EasyRulesCsharp.EasyRulesCsharp.Core {
	class DefaultRulesEngineListener : RulesEngineListener  {
		private const org.slf4j.Logger LOGGER = LoggerFactory.getLogger(DefaultRulesEngineListener.class);
		private RulesEngineParameters parameters;

		DefaultRulesEngineListener(ref RulesEngineParameters parameters) {
			throw new System.Exception("Not implemented");
		}
		public void BeforeEvaluate(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public void AfterExecute(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void LogEngineParameters() {
			throw new System.Exception("Not implemented");
		}
		private void Log(ref Rules rules) {
			throw new System.Exception("Not implemented");
		}
		private void Log(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Triggered after executing the rule set
		/// <strong>When this listener is used with a {@link InferenceRulesEngine}, this method will be triggered after the execution of each candidate rule set in each iteration.</strong>
		/// </summary>
		/// <param name="rules">fired</param>
		/// <param name="facts">present after firing rules</param>
		public void AfterExecute(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Triggered before evaluating the rule set.
		/// <strong>When this listener is used with a {@link InferenceRulesEngine}, this method will be triggered before the evaluation of each candidate rule set in each iteration.</strong>
		/// </summary>
		/// <param name="rules">to fire</param>
		/// <param name="facts">present before firing rules</param>
		public void BeforeEvaluate(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}


	}

}

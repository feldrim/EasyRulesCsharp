using System;
namespace org.jeasy.rules.core {
	/// <summary>
	/// Default {@link RulesEngine} implementation.
	/// 
	/// This implementation handles a set of rules with unique name.
	/// 
	/// Rules are fired according to their natural order which is priority by default.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public sealed class DefaultRulesEngine : AbstractRuleEngine  {
		private const org.slf4j.Logger LOGGER = LoggerFactory.getLogger(DefaultRulesEngine.class);

		/// <summary>
		/// Create a new {@link DefaultRulesEngine} with default parameters.
		/// </summary>
		public DefaultRulesEngine() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link DefaultRulesEngine}.
		/// </summary>
		/// <param name="parameters">of the engine</param>
		public DefaultRulesEngine(ref RulesEngineParameters parameters) {
			throw new System.Exception("Not implemented");
		}
		public override void Fire(ref org.jeasy.rules.api.Rules rules, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		void DoFire(ref org.jeasy.rules.api.Rules rules, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public override java.util.Map<org.jeasy.rules.api.Rule, Boolean> Check(ref org.jeasy.rules.api.Rules rules, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private java.util.Map<org.jeasy.rules.api.Rule, Boolean> DoCheck(ref org.jeasy.rules.api.Rules rules, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersOnFailure(ref org.jeasy.rules.api.Rule rule, ref Exception exception, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersOnSuccess(ref org.jeasy.rules.api.Rule rule, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersBeforeExecute(ref org.jeasy.rules.api.Rule rule, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private bool TriggerListenersBeforeEvaluate(ref org.jeasy.rules.api.Rule rule, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersAfterEvaluate(ref org.jeasy.rules.api.Rule rule, ref org.jeasy.rules.api.Facts facts, ref bool evaluationResult) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersBeforeRules(ref org.jeasy.rules.api.Rules rule, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersAfterRules(ref org.jeasy.rules.api.Rules rule, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private bool ShouldBeEvaluated(ref org.jeasy.rules.api.Rule rule, ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Fire all registered rules on given facts.
		/// </summary>
		public override void Fire(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Check rules without firing them.
		/// </summary>
		/// <returns>a map with the result of evaluation of each rule</returns>
		public override java.util.Map<org.jeasy.rules.api.Rule, Boolean> Check(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}


	}

}

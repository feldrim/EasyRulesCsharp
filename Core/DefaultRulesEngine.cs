using System;
using EasyRulesCsharp.Api;
namespace EasyRulesCsharp.Core {
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
		public override void Fire(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		void DoFire(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public override java.util.Map<Rule, Boolean> Check(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private java.util.Map<Rule, Boolean> DoCheck(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersOnFailure(ref Rule rule, ref Exception exception, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersOnSuccess(ref Rule rule, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersBeforeExecute(ref Rule rule, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private bool TriggerListenersBeforeEvaluate(ref Rule rule, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersAfterEvaluate(ref Rule rule, ref Facts facts, ref bool evaluationResult) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersBeforeRules(ref Rules rule, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private void TriggerListenersAfterRules(ref Rules rule, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private bool ShouldBeEvaluated(ref Rule rule, ref Facts facts) {
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
		public override java.util.Map<Rule, Boolean> Check(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}


	}

}

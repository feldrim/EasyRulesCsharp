using System;
using EasyRulesCsharp.Api;
namespace EasyRulesCsharp.Core {
	/// <summary>
	/// Inference {@link RulesEngine} implementation.
	/// 
	/// Rules are selected based on given facts and fired according to their natural order which is priority by default.
	/// 
	/// The engine continuously selects and fires rules until no more rules are applicable.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public sealed class InferenceRulesEngine : AbstractRuleEngine  {
		private const org.slf4j.Logger LOGGER = LoggerFactory.getLogger(InferenceRulesEngine.class);
		private DefaultRulesEngine delegate_;

		/// <summary>
		/// Create a new inference rules engine with default parameters.
		/// </summary>
		public InferenceRulesEngine() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new inference rules engine.
		/// </summary>
		/// <param name="parameters">of the engine</param>
		public InferenceRulesEngine(ref RulesEngineParameters parameters) {
			throw new System.Exception("Not implemented");
		}
		public override void Fire(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private Set<Rule> SelectCandidates(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public override Map<Rule, Boolean> Check(ref Rules rules, ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Register a rule listener.
		/// </summary>
		/// <param name="ruleListener">to register</param>
		public override void RegisterRuleListener(ref RuleListener ruleListener) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Register a list of rule listener.
		/// </summary>
		/// <param name="ruleListeners">to register</param>
		public void RegisterRuleListeners(ref List<RuleListener> ruleListeners) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Register a rules engine listener.
		/// </summary>
		/// <param name="rulesEngineListener">to register</param>
		public override void RegisterRulesEngineListener(ref RulesEngineListener rulesEngineListener) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Register a list of rules engine listener.
		/// </summary>
		/// <param name="rulesEngineListeners">to register</param>
		public void RegisterRulesEngineListeners(ref List<RulesEngineListener> rulesEngineListeners) {
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

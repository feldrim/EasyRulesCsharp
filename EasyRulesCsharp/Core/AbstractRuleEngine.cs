using System;
namespace org.jeasy.rules.core {
	/// <summary>
	/// Base class for {@link RulesEngine} implementations.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	abstract class AbstractRuleEngine : org.jeasy.rules.api.RulesEngine  {
		public RulesEngineParameters Parameters { get; }
		public java.util.List[]<org.jeasy.rules.api.RuleListener> RuleListeners { get; }
		public java.util.List[]<org.jeasy.rules.api.RulesEngineListener> RulesEngineListeners { get; }

		AbstractRuleEngine() {
			throw new System.Exception("Not implemented");
		}
		AbstractRuleEngine(ref RulesEngineParameters parameters) {
			throw new System.Exception("Not implemented");
		}
		public void RegisterRuleListener(ref org.jeasy.rules.api.RuleListener ruleListener) {
			throw new System.Exception("Not implemented");
		}
		public void RegisterRuleListeners(ref java.util.List<org.jeasy.rules.api.RuleListener> ruleListeners) {
			throw new System.Exception("Not implemented");
		}
		public void RegisterRulesEngineListener(ref org.jeasy.rules.api.RulesEngineListener rulesEngineListener) {
			throw new System.Exception("Not implemented");
		}
		public void RegisterRulesEngineListeners(ref java.util.List<org.jeasy.rules.api.RulesEngineListener> rulesEngineListeners) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Check rules without firing them.
		/// </summary>
		/// <returns>a map with the result of evaluation of each rule</returns>
		public abstract java.util.Map<org.jeasy.rules.api.Rule, Boolean> Check(ref Rules rules, ref Facts facts);
		/// <summary>
		/// Fire all registered rules on given facts.
		/// </summary>
		public abstract void Fire(ref Rules rules, ref Facts facts);

	}

}

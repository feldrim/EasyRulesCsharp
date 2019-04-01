using System;
namespace org.jeasy.rules.core {
	/// <summary>
	/// Parameters of a rules engine.
	/// 
	/// <ul>
	/// <li>When parameters are used with a {@link DefaultRulesEngine}, they are applied on <strong>all registered rules</strong>.</li>
	/// <li>When parameters are used with a {@link InferenceRulesEngine}, they are applied on <strong>candidate rules in each iteration</strong>.</li>
	/// </ul>
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class RulesEngineParameters {
		/// <summary>
		/// Default rule priority threshold.
		/// </summary>
		public const int DEFAULT_RULE_PRIORITY_THRESHOLD = Integer.MAX_VALUE;
		public bool SkipOnFirstAppliedRule { get; set; }
		public bool SkipOnFirstNonTriggeredRule { get; set; }
		public bool SkipOnFirstFailedRule { get; set; }
		public int PriorityThreshold { get; set; }

		/// <summary>
		/// Create a new {@link RulesEngineParameters} with default values.
		/// </summary>
		public RulesEngineParameters() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link RulesEngineParameters}.
		/// </summary>
		/// <param name="skipOnFirstAppliedRule">parameter to skip next applicable rules on first applied rule.</param>
		/// <param name="skipOnFirstFailedRule">parameter to skip next applicable rules on first failed rule.</param>
		/// <param name="skipOnFirstNonTriggeredRule">parameter to skip next applicable rules on first non triggered rule.</param>
		/// <param name="priorityThreshold">threshold after which rules should be skipped.</param>
		public RulesEngineParameters(ref bool skipOnFirstAppliedRule, ref bool skipOnFirstFailedRule, ref bool skipOnFirstNonTriggeredRule, ref int priorityThreshold) {
			throw new System.Exception("Not implemented");
		}
		public RulesEngineParameters PriorityThreshold(ref int priorityThreshold) {
			throw new System.Exception("Not implemented");
		}
		public RulesEngineParameters SkipOnFirstAppliedRule(ref bool skipOnFirstAppliedRule) {
			throw new System.Exception("Not implemented");
		}
		public RulesEngineParameters SkipOnFirstNonTriggeredRule(ref bool skipOnFirstNonTriggeredRule) {
			throw new System.Exception("Not implemented");
		}
		public RulesEngineParameters SkipOnFirstFailedRule(ref bool skipOnFirstFailedRule) {
			throw new System.Exception("Not implemented");
		}
		public String ToString() {
			throw new System.Exception("Not implemented");
		}


	}

}

using System;
namespace org.jeasy.rules.core {
	/// <summary>
	/// Builder to create {@link Rule} instances.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class RuleBuilder {
		private String name = org.jeasy.rules.api.Rule.DEFAULT_NAME;
		private String description = org.jeasy.rules.api.Rule.DEFAULT_DESCRIPTION;
		private int priority = org.jeasy.rules.api.Rule.DEFAULT_PRIORITY;
		private org.jeasy.rules.api.Condition condition = org.jeasy.rules.api.Condition.FALSE;
		private org.jeasy.rules.api.Action[] actions = new ArrayList<>();

		/// <summary>
		/// Set rule name.
		/// </summary>
		/// <param name="name">of the rule</param>
		/// <returns>the builder instance</returns>
		public RuleBuilder Name(ref String name) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Set rule description.
		/// </summary>
		/// <param name="description">of the rule</param>
		/// <returns>the builder instance</returns>
		public RuleBuilder Description(ref String description) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Set rule priority.
		/// </summary>
		/// <param name="priority">of the rule</param>
		/// <returns>the builder instance</returns>
		public RuleBuilder Priority(ref int priority) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Set rule condition.
		/// </summary>
		/// <param name="condition">of the rule</param>
		/// <returns>the builder instance</returns>
		public RuleBuilder When(ref org.jeasy.rules.api.Condition condition) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Add an action to the rule.
		/// </summary>
		/// <param name="action">to add</param>
		/// <returns>the builder instance</returns>
		public RuleBuilder Then(ref org.jeasy.rules.api.Action action) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link Rule}.
		/// </summary>
		/// <returns>a new rule instance</returns>
		public org.jeasy.rules.api.Rule Build() {
			throw new System.Exception("Not implemented");
		}


	}

}

using System;
using EasyRulesCsharp.EasyRulesCsharp.Api;
using Action = EasyRulesCsharp.EasyRulesCsharp.Api.Action;
namespace EasyRulesCsharp.EasyRulesCsharp.Core {
	/// <summary>
	/// Builder to create {@link Rule} instances.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class RuleBuilder {
		private String name = Rule.DEFAULT_NAME;
		private String description = Rule.DEFAULT_DESCRIPTION;
		private int priority = Rule.DEFAULT_PRIORITY;
		private Condition condition = Condition.FALSE;
		private Action[] actions = new ArrayList<>();

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
		public RuleBuilder When(ref Condition condition) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Add an action to the rule.
		/// </summary>
		/// <param name="action">to add</param>
		/// <returns>the builder instance</returns>
		public RuleBuilder Then(ref Action action) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link Rule}.
		/// </summary>
		/// <returns>a new rule instance</returns>
		public Rule Build() {
			throw new System.Exception("Not implemented");
		}


	}

}

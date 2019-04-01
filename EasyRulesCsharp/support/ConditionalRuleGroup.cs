using System;
namespace org.jeasy.rules.support {
	/// <summary>
	/// A conditional rule group is a composite rule where the rule with the highest priority acts as a condition:
	/// if the rule with the highest priority evaluates to true, then we try to evaluate the rest of the rules
	/// and execute the ones that evaluate to true.
	/// 
	/// @author Dag Framstad (dagframstad@gmail.com)
	/// </summary>
	public class ConditionalRuleGroup : CompositeRule  {
		private org.jeasy.rules.api.Rule[] successfulEvaluations;
		private org.jeasy.rules.api.Rule conditionalRule;

		/// <summary>
		/// Create a conditional rule group.
		/// </summary>
		public ConditionalRuleGroup() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a conditional rule group.
		/// </summary>
		/// <param name="name">of the conditional rule</param>
		public ConditionalRuleGroup(ref String name) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a conditional rule group.
		/// </summary>
		/// <param name="name">of the conditional rule</param>
		/// <param name="description">of the conditional rule</param>
		public ConditionalRuleGroup(ref String name, ref String description) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a conditional rule group.
		/// </summary>
		/// <param name="name">of the conditional rule</param>
		/// <param name="description">of the conditional rule</param>
		/// <param name="priority">of the composite rule</param>
		public ConditionalRuleGroup(ref String name, ref String description, ref int priority) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// A path rule will trigger all it's rules if the path rule's condition is true.
		/// </summary>
		/// <param name="facts">The facts.</param>
		/// <returns>true if the path rules condition is true.</returns>
		public override bool Evaluate(ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// When a conditional rule group is applied, all rules that evaluated to true are performed
		/// in their natural order, but with the conditional rule (the one with the highest priority) first.
		/// </summary>
		/// <param name="facts">The facts.</param>
		/// <returns>@throws Exception thrown if an exception occurs during actions performing</returns>
		public override void Execute(ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		private org.jeasy.rules.api.Rule GetRuleWithHighestPriority() {
			throw new System.Exception("Not implemented");
		}
		private java.util.List<org.jeasy.rules.api.Rule> SortRules() {
			throw new System.Exception("Not implemented");
		}



	}

}

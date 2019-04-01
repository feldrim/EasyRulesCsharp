using System;
namespace org.jeasy.rules.support {
	/// <summary>
	/// Base class representing a composite rule composed of a set of rules.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public abstract class CompositeRule : org.jeasy.rules.core.BasicRule  {
		private java.util.Map<Object, org.jeasy.rules.api.Rule> proxyRules;
		/// <summary>
		/// The set of composing rules.
		/// </summary>
		protected org.jeasy.rules.api.Rule[] rules;

		/// <summary>
		/// Create a new {@link CompositeRule}.
		/// </summary>
		public CompositeRule() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link CompositeRule}.
		/// </summary>
		/// <param name="name">rule name</param>
		public CompositeRule(ref String name) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link CompositeRule}.
		/// </summary>
		/// <param name="name">rule name</param>
		/// <param name="description">rule description</param>
		public CompositeRule(ref String name, ref String description) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a new {@link CompositeRule}.
		/// </summary>
		/// <param name="name">rule name</param>
		/// <param name="description">rule description</param>
		/// <param name="priority">rule priority</param>
		public CompositeRule(ref String name, ref String description, ref int priority) {
			throw new System.Exception("Not implemented");
		}
		public abstract bool Evaluate(ref org.jeasy.rules.api.Facts facts);
		public abstract void Execute(ref org.jeasy.rules.api.Facts facts);
		/// <summary>
		/// Add a rule to the composite rule.
		/// </summary>
		/// <param name="rule">the rule to add</param>
		public void AddRule(ref Object rule) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Remove a rule from the composite rule.
		/// </summary>
		/// <param name="rule">the rule to remove</param>
		public void RemoveRule(ref Object rule) {
			throw new System.Exception("Not implemented");
		}


	}

}

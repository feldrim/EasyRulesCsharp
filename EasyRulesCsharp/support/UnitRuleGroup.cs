using System;
namespace org.jeasy.rules.support {
	/// <summary>
	/// A unit rule group is a composite rule that acts as a unit: Either all rules are applied or nothing is applied.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class UnitRuleGroup : CompositeRule  {
		/// <summary>
		/// Create a unit rule group.
		/// </summary>
		public UnitRuleGroup() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a unit rule group.
		/// </summary>
		/// <param name="name">of the composite rule</param>
		public UnitRuleGroup(ref String name) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a unit rule group.
		/// </summary>
		/// <param name="name">of the composite rule</param>
		/// <param name="description">of the composite rule</param>
		public UnitRuleGroup(ref String name, ref String description) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a unit rule group.
		/// </summary>
		/// <param name="name">of the composite rule</param>
		/// <param name="description">of the composite rule</param>
		/// <param name="priority">of the composite rule</param>
		public UnitRuleGroup(ref String name, ref String description, ref int priority) {
			throw new System.Exception("Not implemented");
		}
		public override bool Evaluate(ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public override void Execute(ref org.jeasy.rules.api.Facts facts) {
			throw new System.Exception("Not implemented");
		}


	}

}

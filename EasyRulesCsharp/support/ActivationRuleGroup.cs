using System;
using EasyRulesCsharp.EasyRulesCsharp.Api;
namespace EasyRulesCsharp.EasyRulesCsharp.Support {
	/// <summary>
	/// An activation rule group is a composite rule that fires the first applicable rule and ignores other rules in
	/// the group (XOR logic). Rules are first sorted by their natural order (priority by default) within the group.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class ActivationRuleGroup : CompositeRule  {
		private Rule selectedRule;

		/// <summary>
		/// Create an activation rule group.
		/// </summary>
		public ActivationRuleGroup() {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create an activation rule group.
		/// </summary>
		/// <param name="name">of the activation rule group</param>
		public ActivationRuleGroup(ref String name) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create a conditional rule group.
		/// </summary>
		/// <param name="name">of the activation rule group</param>
		/// <param name="description">of the activation rule group</param>
		public ActivationRuleGroup(ref String name, ref String description) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Create an activation rule group.
		/// </summary>
		/// <param name="name">of the activation rule group</param>
		/// <param name="description">of the activation rule group</param>
		/// <param name="priority">of the activation rule group</param>
		public ActivationRuleGroup(ref String name, ref String description, ref int priority) {
			throw new System.Exception("Not implemented");
		}
		public override bool Evaluate(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}
		public override void Execute(ref Facts facts) {
			throw new System.Exception("Not implemented");
		}


	}

}

using System;
namespace EasyRulesCsharp.Api {
	/// <summary>
	/// Abstraction for a rule that can be fired by the rules engine.
	/// 
	/// Rules are registered in a rule set of type <code>Rules</code> in which they must have a <strong>unique</strong> name.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public interface Rule {
		/// <summary>
		/// Getter for rule name.
		/// @return the rule name
		/// </summary>
		String Name { get; }
		/// <summary>
		/// Getter for rule description.
		/// @return rule description
		/// </summary>
		String Description { get; }
		/// <summary>
		/// Getter for rule priority.
		/// @return rule priority
		/// </summary>
		int Priority { get; }

		/// <summary>
		/// Rule conditions abstraction : this method encapsulates the rule's conditions.
		/// <strong>Implementations should handle any runtime exception and return true/false accordingly</strong>
		/// </summary>
		/// <returns>true if the rule should be applied given the provided facts, false otherwise</returns>
		bool Evaluate(ref Facts facts);
		/// <summary>
		/// Rule actions abstraction : this method encapsulates the rule's actions.
		/// </summary>
		/// <returns>@throws Exception thrown if an exception occurs during actions performing</returns>
		void Execute(ref Facts facts);

	}

}

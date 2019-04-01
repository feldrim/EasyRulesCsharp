using System;
namespace org.jeasy.rules.api {
	/// <summary>
	/// This interface represents a rule's action.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public interface Action {
		/// <summary>
		/// Execute the action when the rule evaluates to true.
		/// </summary>
		/// <param name="facts">known at the time of execution of the action</param>
		/// <returns>@throws Exception when unable to execute the action</returns>
		void Execute(ref Facts facts);

	}

}

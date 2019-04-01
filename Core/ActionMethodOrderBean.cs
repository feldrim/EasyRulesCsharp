using System;
namespace EasyRulesCsharp.Core {
	/// <summary>
	/// Utility class that associates an action method and its execution order.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	class ActionMethodOrderBean {
		public java.lang.reflect.Method Method { get; }
		public int Order { get; }

		ActionMethodOrderBean(ref java.lang.reflect.Method method, ref int order) {
			throw new System.Exception("Not implemented");
		}
		public int CompareTo(ref ActionMethodOrderBean actionMethodOrderBean) {
			throw new System.Exception("Not implemented");
		}
		public bool Equals(ref Object o) {
			throw new System.Exception("Not implemented");
		}
		public int HashCode() {
			throw new System.Exception("Not implemented");
		}

	}

}

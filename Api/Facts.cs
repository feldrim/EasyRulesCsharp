using System;
namespace EasyRulesCsharp.Api {
	/// <summary>
	/// Represents a set of named facts. Facts have unique name within a <code>Facts</code> object.
	/// 
	/// @author Mahmoud Ben Hassine (mahmoud.benhassine@icloud.com)
	/// </summary>
	public class Facts {
		private Map<String, Object> facts = new HashMap<>();

		/// <summary>
		/// Put a fact in the working memory.
		/// This will replace any fact having the same name.
		/// </summary>
		/// <param name="name">fact name</param>
		/// <param name="fact">object to put in the working memory</param>
		/// <returns>the previous value associated with <tt>name</tt>, or <tt>null</tt> if there was no mapping for <tt>name</tt>.
		/// (A <tt>null</tt> return can also indicate that the map
		/// previously associated <tt>null</tt> with <tt>name</tt>.)</returns>
		public Object Put(ref String name, ref Object fact) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Remove fact.
		/// </summary>
		/// <param name="name">of fact to remove</param>
		/// <returns>the previous value associated with <tt>name</tt>, or <tt>null</tt> if there was no mapping for <tt>name</tt>.
		/// (A <tt>null</tt> return can also indicate that the map
		/// previously associated <tt>null</tt> with <tt>name</tt>.)</returns>
		public Object Remove(ref String name) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Get a fact by name.
		/// </summary>
		/// <param name="name">of the fact</param>
		/// <returns>the fact having the given name, or null if there is no fact with the given name</returns>
		public T Get<T>(ref String name) {
			throw new System.Exception("Not implemented");
		}
		/// <summary>
		/// Return facts as a map.
		/// </summary>
		/// <returns>the current facts as a {@link HashMap}</returns>
		public Map<String, Object> AsMap() {
			throw new System.Exception("Not implemented");
		}
		public Iterator<Map.Entry<String, Object>> Iterator() {
			throw new System.Exception("Not implemented");
		}
		public String ToString() {
			throw new System.Exception("Not implemented");
		}


	}

}

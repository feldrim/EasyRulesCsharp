using System;
namespace org.jeasy.rules.tutorials.shop {
	public class Person {
		public String Name { get; }
		public int Age { get; }
		public bool Adult { get; set; }

		public Person(ref String name, ref int age) {
			throw new System.Exception("Not implemented");
		}
		public String ToString() {
			throw new System.Exception("Not implemented");
		}

	}

}

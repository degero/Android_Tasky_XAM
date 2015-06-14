using System;

namespace Tasky.Core {
	/// <summary>
	/// Task business object
    /// with some extra comments	
	/// </summary>
	public class Task {
		public Task ()
		{
		}

        public int ID { get; set; }
		public string Name { get; set; }
		public string Notes { get; set; }
		public bool Done { get; set; }	// TODO: add this field to the user-interface
	}
}
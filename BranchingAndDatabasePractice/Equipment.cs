using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingAndDatabasePractice
{
    /// <summary>
    /// Represents a single piece of computer equipment 
    /// </summary>
    class Equipment
    {
        /// <summary>
        /// The primary key of the equipment
        /// </summary>
        public int EquipmentId { get; set; }
        
        /// <summary>
        /// The name of the equipment
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The retail price of equipment
        /// </summary>
        public double Price { get; set; }
    }
}

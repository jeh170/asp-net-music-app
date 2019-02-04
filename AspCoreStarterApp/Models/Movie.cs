using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AspCoreStarterApp.Models
{
    /// <summary>
    /// Model for an Album
    /// </summary>
    public class Album
    {
        /// <summary>
        /// The id for the album
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// The title of the album
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The release date of the album
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        /// <summary>
        /// The genre of the album
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// The artist of the album
        /// </summary>
        public string Artist { get; set; }

        /// <summary>
        /// The price of the album
        /// </summary>
        public decimal Price { get; set; }
    }
}

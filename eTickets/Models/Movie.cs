using eTickets.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public String ImageURL { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; }

        //Relationship
        public List<Actor_Movie> Actors_Movies { get; set; }
        
        //cinema
        public int CinemaId { get; set; }
        [ForeignKey("CinemaID")]
        public Cinema Cinema { get; set; }

        //producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerID")]
        public Producer Producer { get; set; }
    }
}

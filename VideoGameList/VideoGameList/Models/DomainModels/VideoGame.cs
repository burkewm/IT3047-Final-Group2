using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VideoGameList.Models
{
    public class VideoGame
    {
        public int VideoGameId { get; set; }
        [Required(ErrorMessage="Please enter a game title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please enter an ESRB rating.")]
        public string ESRBId { get; set; }
        public ESRB ESRB { get; set; }
        [Required(ErrorMessage = "Please select the genre.")]
        public string Genre { get; set; }
        [Required(ErrorMessage = "Please enter the release date.")]
        public DateTime? ReleaseDate { get; set; }
        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
        public int Rating { get; set; }
        public string Slug =>
            Title?.Replace(' ', '-').ToLower() + '-' + ReleaseDate?.ToString();
    }
}

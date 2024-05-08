using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace BislariumCW.Models
{
    public class BlogReaction
    {
        [Key]
        public int BlogReactId { get; set; }

        public int UpVote{ get; set; }

        public int DownVote { get; set; }

        public double Popularity { get; set; }

        //FK is blog and user


        //For Blog
        public int BlogId { get; set; } //FK

        public Blog Blog { get; set; } //referencing to Blog 



    }
}

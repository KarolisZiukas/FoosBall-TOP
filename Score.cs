namespace RedBallTracker
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Score
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int blueTeam { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int redTeam { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime date { get; set; }

        [StringLength(30)]
        public string matchResult { get; set; }
    }
}

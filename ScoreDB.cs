namespace RedBallTracker
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ScoreDB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BlueTeam { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RedTeam { get; set; }

        [Key]
        [Column(Order = 2, TypeName = "date")]
        public DateTime Date { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(200)]
        public string MatchResult { get; set; }
    }
}

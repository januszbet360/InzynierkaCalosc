
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace DataModel
{

using System;
    using System.Collections.Generic;
    
public partial class FullStatistic
{

    public int Id { get; set; }

    public int TeamId { get; set; }

    public string Season { get; set; }

    public int MatchesPlayed { get; set; }

    public int Points { get; set; }

    public int MatchesWon { get; set; }

    public int MatchesDrawn { get; set; }

    public int MatchesLost { get; set; }

    public int GoalsScored { get; set; }

    public int GoalsLost { get; set; }



    public virtual Team Team { get; set; }

}

}

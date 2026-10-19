using GolBet.Entities.Common;
using GolBet.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GolBet.Entities; 

public class Bet : AuditableEntity
{
    [Column(TypeName = "decimal(12,2)")]
    public decimal Amount { get; set; }

    [Column(TypeName = "decimal(5,2)")]
    public decimal OddsAtPlacement { get; set; }

    public BetPick Pick { get; set; }

    public BetStatus Status { get; set; } = BetStatus.Pending;

    public int MatchId { get; set; }

    public Match Match { get; set; } = null!;

    public string UserId { get; set; } = null!;   
    public AppUser User { get; set; } = null!;    
}

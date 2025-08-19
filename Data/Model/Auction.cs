namespace Data.Model
{
    public class Auction
    {
        public required string Id { get; set; }
        public required ulong OwnedBy { get; set; }
        public required DateTime StartDate { get; set; }
        public required DateTime EndDate { get; set; }
        public required decimal? CurrentBid { get; set; }
        public required ulong? CurrentBidder { get; set; }
    }

    public enum AuctionState
    {
        Started,
        Finished,
        Cancelled // If it finishes without bids.
    }
}

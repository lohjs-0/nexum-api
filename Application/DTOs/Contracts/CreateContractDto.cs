namespace Nexum.Api.Dtos
{
    public class CreateContractDto
    {
        public string ClientName { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Value { get; set; }
    }
}

using Newtonsoft.Json;

namespace Banks
{
    internal class Config
    {
        [JsonProperty("minimumRenownRequiredToTakeOutLoan")]
        public int MinimumRenownRequiredToTakeOutLoan { get; set; }

        [JsonProperty("availableLoanAmountPerRenown")]
        public int AvailableLoanAmountPerRenown { get; set; }

        [JsonProperty("availableLoanAmountDivisor")]
        public int AvailableLoanAmountDivisor { get; set; }

        [JsonProperty("renownCostPerLoanAmountDivisor")]
        public int RenownCostPerLoanAmountDivisor { get; set; }

        [JsonProperty("daysToRepayLoan")]
        public int DaysToRepayLoan { get; set; }

        [JsonProperty("renownLossForUnpaidLoan")]
        public int RenownLossForUnpaidLoan { get; set; }

        [JsonProperty("crimeRatingIncreaseForUnpaidLoan")]
        public float CrimeRatingIncreaseForUnpaidLoan { get; set; }

        [JsonProperty("recurringCrimeRatingIncreaseForUnpaidLoan")]
        public float RecurringCrimeRatingIncreaseForUnpaidLoan { get; set; }

        [JsonProperty("loanLateFeeInterestRatePerSettlementProsperityFactor")]
        public float LoanLateFeeInterestRatePerSettlementProsperityFactor { get; set; }

        [JsonProperty("interestRatePerSettlementProsperityFactor")]
        public float InterestRatePerSettlementProsperityFactor { get; set; }

        [JsonProperty("interestAccrualRateInDays")]
        public int InterestAccrualRateInDays { get; set; }

        [JsonProperty("bankAccountOpeningCostBase")]
        public int BankAccountOpeningCostBase { get; set; }

        [JsonProperty("bankAccountOpeningCostSettlementProsperityDivisor")]
        public int BankAccountOpeningCostSettlementProsperityDivisor { get; set; }

        [JsonProperty("maxCriminalRatingForUnpaidLoan")]
        public int MaxCriminalRatingForUnpaidLoan { get; set; }

        [JsonProperty("maxBankBalance")]
        public int MaxBankBalance { get; set; }
    }
}

namespace SOLID.ISP.After
{
    interface ICalcPension
    { 
        decimal CalculatePension();
        
    } 
    interface ICalcHealthInsurance
    {  
        decimal CalculateHealthInsurance();
    }
    interface IClacRentalSubsidy
    {
        decimal CalculateRentalSubsidy();
    }
    interface ICalcBonuses
    {
        decimal CalculateBonuses();

    }
    interface ICalcTransportationReimbursement
    {
        decimal CalculateTransportationReimbursement();
    }


}

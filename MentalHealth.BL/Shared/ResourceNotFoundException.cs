namespace MentalHealth.BL.Shared
{
    public class ResourceNotFoundException : BusinessLogicException
    {
        public override ErrorType Type => ErrorType.NotFound;
    }
}
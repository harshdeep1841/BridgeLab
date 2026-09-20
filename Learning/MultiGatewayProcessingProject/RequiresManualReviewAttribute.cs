namespace PaymentProcessing;

[AttributeUsage(AttributeTargets.Method)]
public class RequiresManualReviewAttribute : Attribute
{
}
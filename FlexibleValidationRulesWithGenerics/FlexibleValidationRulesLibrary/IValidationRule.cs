namespace FlexibleValidationRulesLibrary
{
    public interface IValidationRule<T>
    {
        ValidityResponse IsValid(T inputData);
    }
}

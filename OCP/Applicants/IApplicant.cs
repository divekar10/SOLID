namespace OCP
{
    public interface IApplicant
    {
        string Fname { get; set; }
        string Lname { get; set; }

        IAccount AccountProcessor { get; set; }
    }
}
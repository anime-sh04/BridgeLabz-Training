public class LabTestController
{
    [PublicAPI("Get all available lab tests")]
    public void GetAllTests()
    {
    }

    [RequiresAuth("DOCTOR")]
    public void AddLabTest()
    {
    }

    [RequiresAuth("ADMIN")]
    public void DeleteLabTest()
    {
    }

    public void UpdateLabTest()
    {
    }
}

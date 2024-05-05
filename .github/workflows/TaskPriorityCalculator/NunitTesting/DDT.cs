using static NunitTesting.ProjectManagementSystem;
namespace NunitTesting
{
    public class DDT
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(ExecutionTime.LessThan2Weeks, TaskPriority.Critical, RequiredResources.SpecializedEquipment, ProjectState.Initial, TaskPriority.High)]
        [TestCase(ExecutionTime.LessThan2Weeks, TaskPriority.High, RequiredResources.ProjectManagerSupport, ProjectState.Initial, TaskPriority.High)]
        [TestCase(ExecutionTime.LessThan2Weeks, TaskPriority.Critical, RequiredResources.SpecializedEquipment, ProjectState.Initial, TaskPriority.High)]
        [TestCase(ExecutionTime.LessThan2Weeks, TaskPriority.Critical, RequiredResources.ProjectManagerSupport, ProjectState.InProgress, TaskPriority.High)]
        [TestCase(ExecutionTime.Between2And4Weeks, TaskPriority.Critical, RequiredResources.SpecializedEquipment, ProjectState.Initial, TaskPriority.High)]
        [TestCase(ExecutionTime.Between2And4Weeks, TaskPriority.Critical, RequiredResources.ProjectManagerSupport, ProjectState.InProgress, TaskPriority.Medium)]
        [TestCase(ExecutionTime.Between2And4Weeks, TaskPriority.Critical, RequiredResources.ExternalExperts, ProjectState.Finalizing, TaskPriority.Low)]
        public void TestTaskPriority(ExecutionTime executionTime, TaskPriority taskPriority, RequiredResources requiredResources, ProjectState projectState, TaskPriority expectedPriority)
        {
            // Act
            var priority = ProjectManagementSystem.DetermineTaskPriority(executionTime, taskPriority, requiredResources, projectState);

            // Assert
            Assert.AreEqual(expectedPriority, priority);
        }
    }
}
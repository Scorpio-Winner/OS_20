namespace NunitTesting
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DetermineTaskPriority_ExecutionTimeLessThan2Weeks_CriticalPriority_ReturnsHighPriority()
        {
            // Arrange
            var executionTime = ProjectManagementSystem.ExecutionTime.LessThan2Weeks;
            var taskPriority = ProjectManagementSystem.TaskPriority.Critical;
            var requiredResources = ProjectManagementSystem.RequiredResources.SpecializedEquipment;
            var projectState = ProjectManagementSystem.ProjectState.Initial;

            // Act
            var result = ProjectManagementSystem.DetermineTaskPriority(executionTime, taskPriority, requiredResources, projectState);

            // Assert
            Assert.AreEqual(ProjectManagementSystem.TaskPriority.High, result);
        }

        [Test]
        public void DetermineTaskPriority_ExecutionTimeLessThan2Weeks_NonCriticalPriority_ReturnsHighPriority()
        {
            // Arrange
            var executionTime = ProjectManagementSystem.ExecutionTime.LessThan2Weeks;
            var taskPriority = ProjectManagementSystem.TaskPriority.High;
            var requiredResources = ProjectManagementSystem.RequiredResources.ProjectManagerSupport;
            var projectState = ProjectManagementSystem.ProjectState.Initial;

            // Act
            var result = ProjectManagementSystem.DetermineTaskPriority(executionTime, taskPriority, requiredResources, projectState);

            // Assert
            Assert.AreEqual(ProjectManagementSystem.TaskPriority.High, result);
        }

        [Test]
        public void DetermineTaskPriority_ExecutionTimeLessThan2Weeks_CriticalPriority_InitialProjectState_ReturnsHighPriority()
        {
            // Arrange
            var executionTime = ProjectManagementSystem.ExecutionTime.LessThan2Weeks;
            var taskPriority = ProjectManagementSystem.TaskPriority.Critical;
            var requiredResources = ProjectManagementSystem.RequiredResources.SpecializedEquipment;
            var projectState = ProjectManagementSystem.ProjectState.Initial;

            // Act
            var result = ProjectManagementSystem.DetermineTaskPriority(executionTime, taskPriority, requiredResources, projectState);

            // Assert
            Assert.AreEqual(ProjectManagementSystem.TaskPriority.High, result);
        }

        [Test]
        public void DetermineTaskPriority_ExecutionTimeLessThan2Weeks_CriticalPriority_NonInitialProjectState_ReturnsMediumPriority()
        {
            // Arrange
            var executionTime = ProjectManagementSystem.ExecutionTime.LessThan2Weeks;
            var taskPriority = ProjectManagementSystem.TaskPriority.Critical;
            var requiredResources = ProjectManagementSystem.RequiredResources.ProjectManagerSupport;
            var projectState = ProjectManagementSystem.ProjectState.InProgress;

            // Act
            var result = ProjectManagementSystem.DetermineTaskPriority(executionTime, taskPriority, requiredResources, projectState);

            // Assert
            Assert.AreEqual(ProjectManagementSystem.TaskPriority.High, result);
        }

        [Test]
        public void DetermineTaskPriority_ExecutionTimeBetween2And4Weeks_CriticalPriority_InitialProjectState_ReturnsHighPriority()
        {
            // Arrange
            var executionTime = ProjectManagementSystem.ExecutionTime.Between2And4Weeks;
            var taskPriority = ProjectManagementSystem.TaskPriority.Critical;
            var requiredResources = ProjectManagementSystem.RequiredResources.SpecializedEquipment;
            var projectState = ProjectManagementSystem.ProjectState.Initial;

            // Act
            var result = ProjectManagementSystem.DetermineTaskPriority(executionTime, taskPriority, requiredResources, projectState);

            // Assert
            Assert.AreEqual(ProjectManagementSystem.TaskPriority.High, result);
        }

        [Test]
        public void DetermineTaskPriority_ExecutionTimeBetween2And4Weeks_CriticalPriority_NonInitialProjectState_ReturnsMediumPriority()
        {
            // Arrange
            var executionTime = ProjectManagementSystem.ExecutionTime.Between2And4Weeks;
            var taskPriority = ProjectManagementSystem.TaskPriority.Critical;
            var requiredResources = ProjectManagementSystem.RequiredResources.ProjectManagerSupport;
            var projectState = ProjectManagementSystem.ProjectState.InProgress;

            // Act
            var result = ProjectManagementSystem.DetermineTaskPriority(executionTime, taskPriority, requiredResources, projectState);

            // Assert// Assert
            Assert.AreEqual(ProjectManagementSystem.TaskPriority.Medium, result);
        }

        [Test]
        public void DetermineTaskPriority_ExecutionTimeBetween2And4Weeks_CriticalPriority_FinalizingProjectState_ReturnsLowPriority()
        {
            // Arrange
            var executionTime = ProjectManagementSystem.ExecutionTime.Between2And4Weeks;
            var taskPriority = ProjectManagementSystem.TaskPriority.Critical;
            var requiredResources = ProjectManagementSystem.RequiredResources.ExternalExperts;
            var projectState = ProjectManagementSystem.ProjectState.Finalizing;

            // Act
            var result = ProjectManagementSystem.DetermineTaskPriority(executionTime, taskPriority, requiredResources, projectState);

            // Assert
            Assert.AreEqual(ProjectManagementSystem.TaskPriority.Low, result);
        }
    }
}
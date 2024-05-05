using System;

namespace TaskPriorityCalculator
{
    public class ProjectManagementSystem
    {
        public enum ExecutionTime
        {
            LessThan2Weeks,
            Between2And4Weeks,
            MoreThan4Weeks
        }

        public enum TaskPriority
        {
            Critical,
            High,
            Medium,
            Low
        }

        public enum RequiredResources
        {
            SpecializedEquipment,
            ProjectManagerSupport,
            ExternalExperts
        }

        public enum ProjectState
        {
            Initial,
            InProgress,
            Finalizing
        }

        public static TaskPriority DetermineTaskPriority(
            ExecutionTime executionTime,
            TaskPriority taskPriority,
            RequiredResources requiredResources,
            ProjectState projectState)
        {
            if (executionTime == ExecutionTime.LessThan2Weeks && taskPriority == TaskPriority.Critical)
            {
                return TaskPriority.High;
            }

            if (requiredResources == RequiredResources.SpecializedEquipment && projectState == ProjectState.Initial)
            {
                return TaskPriority.High;
            }

            if (requiredResources == RequiredResources.ExternalExperts && projectState == ProjectState.Finalizing)
            {
                return TaskPriority.Low;
            }

            return TaskPriority.Medium;
        }

        // Пример использования функции DetermineTaskPriority для проведения автоматизированного тестирования
        public static void Main()
        {
            // Тест-кейсы для автоматизированного тестирования
            ExecutionTime[] executionTimes = {
            ExecutionTime.LessThan2Weeks,
            ExecutionTime.Between2And4Weeks,
            ExecutionTime.MoreThan4Weeks
        };

            TaskPriority[] taskPriorities = {
            TaskPriority.Critical,
            TaskPriority.High,
            TaskPriority.Medium,
            TaskPriority.Low
        };

            RequiredResources[] requiredResources = {
            RequiredResources.SpecializedEquipment,
            RequiredResources.ProjectManagerSupport,
            RequiredResources.ExternalExperts
        };

            ProjectState[] projectStates = {
            ProjectState.Initial,
            ProjectState.InProgress,
            ProjectState.Finalizing
        };

            foreach (var executionTime in executionTimes)
            {
                foreach (var taskPriority in taskPriorities)
                {
                    foreach (var resource in requiredResources)
                    {
                        foreach (var projectState in projectStates)
                        {
                            var priority = DetermineTaskPriority(executionTime, taskPriority, resource, projectState);
                            Console.WriteLine($"Execution Time: {executionTime}, Task Priority: {taskPriority}, Required Resource: {resource}, Project State: {projectState}, Priority: {priority}");
                        }
                    }
                }
            }
        }
    }
}
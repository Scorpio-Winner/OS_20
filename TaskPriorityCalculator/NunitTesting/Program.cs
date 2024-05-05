using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting
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

            if (executionTime == ExecutionTime.LessThan2Weeks && taskPriority != TaskPriority.Critical)
            {
                return TaskPriority.High;
            }

            if (executionTime == ExecutionTime.Between2And4Weeks && taskPriority == TaskPriority.Critical && requiredResources == RequiredResources.SpecializedEquipment && projectState == ProjectState.Initial)
            {
                return TaskPriority.High;
            }

            if (executionTime == ExecutionTime.Between2And4Weeks && taskPriority == TaskPriority.Critical && requiredResources == RequiredResources.ProjectManagerSupport && projectState != ProjectState.Finalizing)
            {
                return TaskPriority.Medium;
            }

            if (executionTime == ExecutionTime.Between2And4Weeks && taskPriority == TaskPriority.Critical && requiredResources == RequiredResources.ExternalExperts && projectState == ProjectState.Finalizing)
            {
                return TaskPriority.Low;
            }

            if (executionTime == ExecutionTime.Between2And4Weeks && taskPriority != TaskPriority.Critical && requiredResources == RequiredResources.SpecializedEquipment && projectState == ProjectState.Initial)
            {
                return TaskPriority.High;
            }

            if (executionTime == ExecutionTime.Between2And4Weeks && taskPriority != TaskPriority.Critical && requiredResources == RequiredResources.ProjectManagerSupport && projectState != ProjectState.Finalizing)
            {
                return TaskPriority.Medium;
            }

            if (executionTime == ExecutionTime.Between2And4Weeks && taskPriority != TaskPriority.Critical && requiredResources == RequiredResources.ExternalExperts && projectState == ProjectState.Finalizing)
            {
                return TaskPriority.Low;
            }

            if (executionTime == ExecutionTime.MoreThan4Weeks && taskPriority == TaskPriority.Critical && requiredResources == RequiredResources.SpecializedEquipment && projectState == ProjectState.Initial)
            {
                return TaskPriority.High;
            }

            if (executionTime == ExecutionTime.MoreThan4Weeks && taskPriority == TaskPriority.Critical && requiredResources == RequiredResources.ProjectManagerSupport && projectState != ProjectState.Finalizing)
            {
                return TaskPriority.Medium;
            }

            if (executionTime == ExecutionTime.MoreThan4Weeks && taskPriority == TaskPriority.Critical && requiredResources == RequiredResources.ExternalExperts && projectState == ProjectState.Finalizing)
            {
                return TaskPriority.Low;
            }

            return TaskPriority.Medium;
        }
    }  
}

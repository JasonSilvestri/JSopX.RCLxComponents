using System.ComponentModel;

namespace Jsopx.ClassLibrary
{

    /// <summary>
    /// Custom jSilvestri.com BETA v 2024 JSopX™ Web API Demo Enums class used to handle all Enums, across all projects included in the jSilvestri.com BETA v 2024 JSopX™
    /// Collection projects.
    /// </summary>
    public static class JsopxEnums
    {

        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Web API Demo Enum used to handle all jSilvestri.com 2024
        /// <c>User Role</c> requirements.
        /// </summary>
        public enum UserRoles
        {
            Admin,
            User,
            Guest
        }

        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum used to handle all jSilvestri.com 2024
        /// <c>Workflow States</c> requirements.
        /// </summary>
        public enum WorkflowStates
        {
            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Started</c>. This workflow state occurs when a process or action has been started.
            /// </summary>
            [Description("Started")]
            Started = 1,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Skipped</c>. This workflow state occurs when a process or action has been skipped, either because the end result already exists or the action or process does not need to occur.
            /// </summary>
            [Description("Skipped")]
            Skipped = 2,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Pending</c>. This workflow state occurs when a process or action has been started, and is now awaiting a process, action or person to act on it.
            /// </summary>
            [Description("Pending")]
            Pending = 3,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Expired</c>. This workflow state occurs when a process or action has been started in which a person, process or action acted on it, but then expired before further action was done.
            /// </summary>
            [Description("Expired")]
            Expired = 4,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Rejected</c>. This workflow state occurs when a process or action has been started, a process, action or person acted on it, and then was approved by a superior of the process or action.
            /// </summary>
            [Description("Rejected")]
            Rejected = 5,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Failed</c>. This workflow state occurs when a process or action has failed to complete and often times fatal.
            /// </summary>
            [Description("Failed")]
            Failed = 6,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Approved</c>. This workflow state occurs when a process or action has been started, a process, action or person acted on it, and then was approved by a superior of the process or action.
            /// </summary>
            [Description("Approved")]
            Approved = 7,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Completed</c>. This workflow state occurs when a process or action has been started, a process, action or person acted on it, and then was completed by a superior of the process or action.
            /// </summary>
            [Description("Completed")]
            Completed = 8,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Sent</c>. This workflow state occurs when a process or action has been sent - such as an email or notification - and is awaiting to be received by the next action, proces or person in the workflow.
            /// </summary>
            [Description("Sent")]
            Sent = 9,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Received</c>. This workflow state occurs when a process or action has been sent - such as an email or notification - and is no longer awaiting to be received (because it has been received.
            /// </summary>
            [Description("Received")]
            Received = 10,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Under Review</c>. This workflow state occurs when a process or action has been started, has been moved out of a pending state, and is now awaiting a person, process or action to finish acting on it.
            /// </summary>
            [Description("Under Review")]
            UnderReview = 11,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Soft Delete</c>. This workflow state occurs when a person, process or action has marked the record in hand for deletion and should be stored for historical purposes.
            /// </summary>
            [Description("Soft Delete")]
            SoftDelete = 12,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Hard Delete</c>. This workflow state occurs when a person, process or action has marked the record in hand for deletion and can be IsDeleted permanently.
            /// </summary>
            [Description("Hard Delete")]
            HardDelete = 13,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Unknown</c>. This workflow state occurs when a process or action has been initiated (but not necessarily started), and has no real outcome or result that we can take action on. Did it Start? Did it End? Completed? Who knows? That is why it is considered Unknown.
            /// </summary>
            [Description("Unknown")]
            Unknown = 14,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Null or Empty</c>. This workflow state occurs when a process, action or search on data brings back a null, empty or doesn't exist result.
            /// </summary>
            [Description("Null or Empty")]
            NullorEmpty = 15,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State</c>, the state being <c>Active</c>. This workflow state occurs when a process, action or search on data brings back a null, empty or doesn't exist result.
            /// </summary>
            [Description("Active")]
            Active = 23
        }

        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum descriptions of each Workflow State.
        /// </summary>
        public enum WorkflowStateDescriptions
        {
            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Started</c>. 
            /// This workflow state occurs when a process or action has been started.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been started.")]
            Started = 1,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Skipped</c>. 
            /// This workflow state occurs when a process or action has been skipped, either because the end 
            /// result already exists or the action or process does not need to occur.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been skipped, either because the end result already exists or the action or process does not need to occur.")]
            Skipped = 2,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Pending</c>. 
            /// This workflow state occurs when a process or action has been started, and is now awaiting a 
            /// process, action or person to act on it.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been started, and is now awaiting a process, action or person to act on it.")]
            Pending = 3,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Expired</c>. 
            /// This workflow state occurs when a process or action has been started in which a person, 
            /// process or action acted on it, but then expired before further action was done.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been started in which a person, process or action acted on it, but then expired before further action was done.")]
            Expired = 4,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Rejected</c>. 
            /// This workflow state occurs when a process or action has been started, a process, action or 
            /// person acted on it, and then was approved by a superior of the process or action.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been started, a process, action or person acted on it, and then was approved by a superior of the process or action.")]
            Rejected = 5,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Failed</c>. 
            /// This workflow state occurs when a process or action has failed to complete and often times fatal.
            /// </summary>
            [Description("This workflow state occurs when a process or action has failed to complete and often times fatal.")]
            Failed = 6,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Approved</c>. 
            /// This workflow state occurs when a process or action has been started, a process, action or person 
            /// acted on it, and then was approved by a superior of the process or action.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been started, a process, action or person acted on it, and then was approved by a superior of the process or action.")]
            Approved = 7,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Completed</c>. 
            /// This workflow state occurs when a process or action has been started, a process, action or 
            /// person acted on it, and then was approved by a superior of the process or action.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been started, a process, action or person acted on it, and then was approved by a superior of the process or action.")]
            Completed = 8,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Sent</c>. 
            /// This workflow state occurs when a process or action has been sent - such as an email or 
            /// notification - and is awaiting to be received by the next action, proces or person
            /// in the workflow.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been sent - such as an email or notification - and is awaiting to be received by the next action, proces or person in the workflow.")]
            Sent = 9,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Received</c>. 
            /// This workflow state occurs when a process or action has been sent - such as an email or 
            /// notification - and is no longer awaiting to be received (because it has been received.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been sent - such as an email or notification - and is no longer awaiting to be received (because it has been received.")]
            Received = 10,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Under Review</c>. 
            /// This workflow state occurs when a process or action has been started, has been moved out of a 
            /// pending state, and is now awaiting a person, process or action to finish acting on it.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been started, has been moved out of a pending state, and is now awaiting a person, process or action to finish acting on it.")]
            UnderReview = 11,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Soft Delete</c>. 
            /// This workflow state occurs when a person, process or action has marked the record in hand for 
            /// deletion and should be stored for historical purposes.
            /// </summary>
            [Description("This workflow state occurs when a person, process or action has marked the record in hand for deletion and should be stored for historical purposes.")]
            SoftDelete = 12,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Hard Delete</c>. 
            /// This workflow state occurs when a person, process or action has marked the record in hand for 
            /// deletion and can be IsDeleted permanently.
            /// </summary>
            [Description("This workflow state occurs when a person, process or action has marked the record in hand for deletion and can be IsDeleted permanently.")]
            HardDelete = 13,

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Project Enum, of the type, <c>Workflow State Description</c>, the state being <c>Unknown</c>. 
            /// This workflow state occurs when a process or action has been initiated (but not necessarily 
            /// started), and has no real outcome or result that we can take action on. Did it Start? Did it 
            /// End? Completed? Who knows? That is why it is considered Unknown.
            /// </summary>
            [Description("This workflow state occurs when a process or action has been initiated (but not necessarily started), and has no real outcome or result that we can take action on. Did it Start? Did it End? Completed? Who knows? That is why it is considered Unknown.")]
            Unknown = 14,

        }

    }
}

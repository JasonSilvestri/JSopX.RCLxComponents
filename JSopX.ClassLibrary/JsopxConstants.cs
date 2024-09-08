using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

// NEW! Create Unsigned Friend Assemblies that can access the Internal properties
// we often use to protect sensitive data where a secure data store or vault isn't
// yet present to do similar.

// Read More on What I Did Below to Create Unsigned Assembly Friends:
//https://learn.microsoft.com/en-us/dotnet/standard/assembly/friend

// Also, we will want to modify the below when we decide to sign each assembly (and some should be signed
// sooner than not). However, if we sign Class Library, we need to also sign friends, and this 
// Library's friends are just about every every project. So, yeah.
//
// We need to wait until the collective projects are more mature before making this move.

// Read More on What I Need to Do Below to Create Signed Assembly Friends:
// https://learn.microsoft.com/en-us/dotnet/standard/assembly/create-signed-friend

// Also, below would be the static types for assembly names.
// However, a large part of why static constants are so important is
// in cases just like this, where it is rare to be able to most other
// structs, but yet, here we are, reducing static string use.

// So.... If We Never Created Static Constants....

//[assembly: InternalsVisibleTo("JSopX.OpenProjectX")]
//[assembly: InternalsVisibleTo("JSopX.BridgeTooFar")]
//[assembly: InternalsVisibleTo("JSopX.WebAPI")]
//[assembly: InternalsVisibleTo("JSopX.SharedResources")]
//[assembly: InternalsVisibleTo("JSopX.RCLxProper")]
//[assembly: InternalsVisibleTo("JSopX.RCLxAssets")]
//[assembly: InternalsVisibleTo("JSopX.RCLxComponents")]
//[assembly: InternalsVisibleTo("JSopX.AngularCore")]
//[assembly: InternalsVisibleTo("JSopX.ReactCore")]
//[assembly: InternalsVisibleTo("JSopX.VueCore")]
//[assembly: InternalsVisibleTo("JSopX.AspNetCore")]
//[assembly: InternalsVisibleTo("JSopX.BlazorServerCore")]
//[assembly: InternalsVisibleTo("JSopX.MauiHybridNetCore")]

// But We Took the Time to, so....
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.OpenProjectX)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.BridgeTooFar)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.WebAPI)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.SharedResources)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.RCLxProper)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.RCLxAssets)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.RCLxComponents)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.AngularCore)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.ReactCore)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.VueCore)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.AspNetCore)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.BlazorServerCore)]
[assembly: InternalsVisibleTo(Jsopx.ClassLibrary.JsopxConstants.WebAppDemoSettings.StronglyTypedAssemblyNames.MauiHybridNetCore)]

namespace Jsopx.ClassLibrary
{

    /// <summary>
    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class for handling all product information across 
    /// the jSilvestri.com BETA v 2024 JSopX™ Open Demo Collection Projects.
    /// <para>
    /// ⚠ IMPORTANT ⚠
    /// </para>
    /// <para>
    /// This project is currently in Phase <c>1 (one)</c> of <c>4 (four)</c>, where deliberate "minimum viable product" 
    /// decisions are made to demonstrate the project's evolution across phases. It is important to note that 
    /// storing sensitive data in variables (of most kinds) is not secure and should not be common practice.
    /// </para>
    /// <para>
    /// This project will not follow the common "for simplicity's sake" approach often justified by developers 
    /// when they provide code as a form of volunteering. Such practices go against the purpose of why I began 
    /// developing these cross-platform, cross-resource applications. It is concerning that such bad practices 
    /// are often encouraged across various projects and tech stacks, using both client-side and server-side 
    /// approaches.
    /// </para>
    /// <para>
    /// Using UserSecret files, app settings, and strongly typing static variables in your applications can 
    /// expose them to security risks. At a minimum, consider using a cloud secure vault or encryption when 
    /// re-using this code in your projects.
    /// </para>
    /// <para>
    /// One of the primary reasons for the existence of this class, as well as its elaborate uses, is to avoid 
    /// enforcing specific database uses, cloud storage, local storage solutions, and other decisions or 
    /// implementations that increase setup overhead. This project will increasingly use sealed classes, internal 
    /// declarations, and more secure practices as we progress through the phases.
    /// </para>
    /// </summary>
   
    public static class JsopxConstants
    {

        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
        /// legal requirements, across all projects included in the jSilvestri.com BETA v 2024 JSopX™ Open Demo 
        /// Collection projects, such as copyright branding, trademark branding, contact information
        /// and more.
        /// </summary>
        public static class JsopxLegalParts
        {
            public const string JsopxCopyRight = "©2024 Jason Silvestri";
            public const string JsopxCopyRightAndName = "Copyright © 2024 All Rights Reserved by Jason Silvestri";
            public const string JsopxCopyRightAndRightsName = "Copyright © 2024 Jason Silvestri. All Rights Reserved";
        }

        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
        /// brand requirements, across all projects included in the jSilvestri.com BETA v 2024 JSopX™ Demo 
        /// Collection projects.
        /// </summary>
        public static class JsopxBrand
        {
            public const string JsopxBrandName = "jSilvestri.com";
            public const string JsopxBrandNameAppDemos = "jSilvestri.com BETA v 2024 JSopX™ Demos";
            public const string JsopxBrandNameGitHubs = "jSilvestri.com GitHubs";
            public const string JsopxBrandNameEncoded = "jSilvestri.com";
            public const string JsopxBrandNameAndJasonX = "jSilvestri.com - featuring JSopX™ 2024 Web Application";
            public const string JsopxBrandNameAndJasonXEncoded = "jSilvestri.com - featuring JSopX&trade; 2024 Web Application";
        }

        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
        /// Open Demo Product information, across all projects included in the jSilvestri.com BETA v 2024 JSopX™ Open Demo 
        /// Collection projects.
        /// </summary>
        public static class JsopxAppProjects
        {

            /// <summary>
            /// Custom jSilvestri.com JSopX™ Demo App Constants class used to handle 
            /// all Open Demo Product versions, across all projects,
            /// included the jSilvestri 2024 JSopX™ Open Demo Collection projects.
            /// <para>
            /// ⚠ IMPORTANT ⚠
            /// </para>
            /// <para>
            /// These static constants will eventually be replaced with the versions produced
            /// by each application dynamically via version control. 
            /// </para>
            /// </summary>
            public static class ProductVersions
            {

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string Default = "v2024.0.1";

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JsopxMainProjectName = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JsopxAngularJsProject = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JsopxAspNetCoreProject = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JsopxBlazorProject = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JsopxReactJsProject = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JsopxVueProject = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JsopxMAUIProject = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JsopxClassLibraryProject = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JsopxWebApiProject = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JsopxSharedResourcesProject = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JSopxRazorClassAssetsLibraryProject = Default;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants property used to 
                /// show static product version display name.
                /// </summary>
                public const string JSopxRazorClassComponentsLibraryProject = Default;
            }

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
            /// Open Demo Product names, across all projects included in the jSilvestri.com BETA v 2024 JSopX™ Open Demo 
            /// Collection projects.
            /// </summary>
            public static class Names
            {

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Default</c> Product names.
                /// </summary>
                public static class Default
                {
                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Default</c> Product names.
                    /// </summary>
                    public const string OpenProjectX = "jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Collection Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Default</c> Product names.
                    /// </summary>
                    public const string BridgeTooFarProject = "JSopX™ Bridge Too Far Open Project EXperience";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string AngularCoreProject = "JSopX™ Angular Asp.NET Core Open Project EXperience";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string AspNetCoreProject = "JSopX™ Asp.NET Core Open Project EXperience";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string BlazorServerCoreProject = "JSopX™ Blazor Asp.NET Core Open Project EXperience";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string ReactCoreProject = "JSopX™ React Asp.NET Core Open Project EXperience";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string VueCoreProject = "JSopX™ Vue Asp.NET Core Open Project EXperience";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string MauiHybridCoreProject = "JSopX™ .NET MAUI Hybrid Open Project EXperience";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string WebApiProject = "JSopX™ Asp.NET Core WebAPI Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string ClassLibraryProject = "JSopX™ Asp.NET Core Class Library Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string SharedResourcesProject = "JSopX™ Asp.NET Core Shared Resources Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string RCLxProperProject = "JSopX™ Asp.NET Core (RCL) Razor Class Library Proper Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string RCLxAssetsProject = "JSopX™ Asp.NET Core (RCL) Razor Class Library Assets Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperience <c>Default</c> Product names.
                    /// </summary>
                    public const string RCLxComponentsProject = "JSopX™ Asp.NET Core (RCL) Razor Class Library Components Project";
                }


                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                /// </summary>
                public static class Short
                {
                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string OpenProjectX = "JSopX™ Jason Silvestri Open Project EXperiences Collection Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string BridgeTooFarProject = "JSopX™ Angular Asp.NET Core Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string AngularCoreProject = "JSopX™ Angular Asp.NET Core Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string AspNetCoreProject = "JSopX™ Asp.NET Core Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string BlazorServerCoreProject = "JSopX™ Blazor Core Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string ReactCoreProject = "JSopX™ React Core Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string VueCoreProject = "JSopX™ Vue Core Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string MauiHybridCoreProject = "JSopX™ MAUI Hybrid Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string WebApiProject = "JSopX™ Asp.NET Core WebAPI";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string ClassLibraryProject = "JSopX™ Class Library Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string SharedResourcesProject = "JSopX™ Shared Resources Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string RCLxProperProject = "JSopX™ (RCL) Razor Class Library Proper Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string RCLxAssetsProject = "JSopX™ (RCL) Razor Class Library Assets Project";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
                    /// jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences <c>Short</c> Product names.
                    /// </summary>
                    public const string RCLxComponentsProject = "JSopX™ (RCL) Razor Class Library Components Project";
                }

            }

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle all jSilvestri.com 2024
            /// Open Demo Product descriptions, across all projects included in the jSilvestri.com BETA v 2024 JSopX™ Open Demo 
            /// Collection projects.
            /// </summary>
            public static class Descriptions
            {

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class, used to handle the
                /// product <c>Default</c> descriptions of projects in the JSopX™ Open Demo Collection Project.
                /// </summary>
                public static class Default
                {
                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string OpenProjectX = "The jSilvestri.com BETA v 2024 JSopX™ Open Demo Collection Project is a comprehensive suite of demonstration projects designed to showcase the integration and usage of various back-end and front-end frameworks (i.e., Angular, Blazor, React, Vue, MAUI Hybrid, etc.) with ASP.NET Core 8 back-end, which includes a Web API, Class Libraries and Razor Libraries used as the same shared assets across all projects (by design). This collection serves as a learning resource and reference for developers looking to understand and implement modern web application architectures using these technologies.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string BridgeTooFarProject = "The JSopX™ Bridge Too Far Project is a project containing reusable .NET class libraries that provide common functionalities and utilities used across different web applications within the Open Project EXperiences Collection of Projects. This project aims to promote code reuse and maintainability by centralizing shared logic in a single location.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string ClassLibraryProject = "The JSopX™ Class Library Project is a project containing reusable .NET class libraries that provide common functionalities and utilities used across different web applications within the Open Project EXperiences Collection of Projects. This project aims to promote code reuse and maintainability by centralizing shared logic in a single location.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string SharedResourcesProject = "The JSopX™ Shared Resources Class Library Project is a project that contains shared resources such as images, styles, and scripts used across multiple web applications in the Open Project EXperiences Collection of Projects. This project aims to maintain consistency and avoid duplication of resources across different projects. It was originally created to show resources being shared across client-side and server-side projects, even though they are more traditionally used to share these resources in server-side .NET projects.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string RCLxProperProject = "The JSopX™ (RCL) Razor Class Library Proper Project is a project that contains shared resources such as images, styles, and scripts used across multiple client-side and server-side web applications in the Open Project EXperiences Collection of Projects. This project aims to maintain consistency and avoid duplication of resources across different projects more efficiently, and created to show resources being shared across the more modern client-side and server-side projects (i.e., Asp.NET Core, Blazor, Angular, React, Vue, etc.).";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string RCLxAssetsProject = "The JSopX™ (RCL) Razor Class Library Assets Project is a project that contains shared resources such as images, styles, and scripts used across multiple client-side and server-side web applications in the Open Project EXperiences Collection of Projects. This project aims to maintain consistency and avoid duplication of resources across different projects more efficiently, and created to show resources being shared across the more modern client-side and server-side projects (i.e., Asp.NET Core, Blazor, Angular, React, Vue, etc.).";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string RCLxComponentsProject = "The JSopX™ (RCL) Razor Class Library Razor Project is a project that contains shared resources specifically for Razor Components being used in our Blazor, and .NET MAUI Hybrid Projects. This is not intended for use in client-side and server-side assets sharing like the other class libraries in the Open Project EXperiences Collection of Projects (e.g., not intended for assets sharing with Angular, React, Vue, etc.). This project does aim to still maintain consistency and avoid duplication resources, but just with razor components and not assets directly.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string WebApiProject = "The JSopX™ Web API Project is a custom project that implements an ASP.NET Core 8 Web API, serving as the back-end for the various web applications in the Open Project EXperiences Collection of Projects. It provides RESTful API endpoints for data retrieval and manipulation, showcasing best practices in API development and integration with front-end frameworks.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string AspNetCoreProject = "The JSopX™ Asp.NET Core Open Project EXperiences is a demonstration project showcasing how to build a web application using ASP.NET Core 8 Web API. It highlights the integration of Asp.NET Core for the server-side, providing a comprehensive example of a modern web application server-side stack.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string AngularCoreProject = "The JSopX™ Angular Core Open Project EXperiences is a demonstration project showcasing how to build a web application using Angular and ASP.NET Core 8 Web API. It highlights the integration of Angular for the client-side with ASP.NET Core for the server-side, providing a comprehensive example of a modern web application stack.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string BlazorServerCoreProject = "The JSopX™ Blazor Server Core Open Project EXperiences is a demonstration project that illustrates how to construct a web application using Blazor Server and ASP.NET Core 8 Web API. This project highlights the use of Blazor for building interactive web UIs with C# and ASP.NET Core for providing powerful server-side capabilities.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string ReactCoreProject = "The JSopX™ React Core Open Project EXperiences is a demonstration project designed to illustrate how to create a web application using React and ASP.NET Core 8 Web API. This project exemplifies the combination of React for building dynamic user interfaces with ASP.NET Core for developing robust server-side APIs.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string VueCoreProject = "The JSopX™ Vue Core Open Project EXperiences is a demonstration project intended to demonstrate how to develop a web application using Vue and ASP.NET Core 8 Web API. It showcases the seamless integration of Vue for the front-end and ASP.NET Core for the back-end, offering a clear example of a full-stack web development approach.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Default</c> product description. 
                    /// </summary>
                    public const string MauiHybridCoreProject = "The JSopX™ .NET MAUI Hybrid Demo Project is a demonstration project intended to demonstrate how to develop a multi-platform application using Asp.NET Core Razor Components to construct and all-in-one solution to deploy your MAUI application as a Web application, a Windows and Mac Desktop application, and native mobile applications for Windows Phone, iPhone, Andriod and Samsung.";

                }

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class, used to handle the
                /// product <c>Short</c> descriptions of projects in the JSopX™ Open Demo Collection Project.
                /// </summary>
                public static class Short
                {
                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string OpenProjectX = "The jSilvestri.com BETA v 2024 JSopX™ Open Demo Collection Project is a comprehensive suite of demonstration projects designed to showcase the integration and usage of various back-end and front-end frameworks (i.e., Angular, Blazor, React, Vue, MAUI Hybrid, etc.) with ASP.NET Core 8 back-end, which includes a Web API, Class Libraries and Razor Libraries used as the same shared assets across all projects (by design).";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string BridgeTooFarProject = "The JSopX™ Bridge Too Far Project is a project containing reusable static assets, documentation, and other .NET class libraries that provide common functionalities and utilities used across different web applications within the Open Project EXperiences Collection of Projects.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string ClassLibraryProject = "The JSopX™ Class Library Project is a project containing reusable .NET class libraries that provide common functionalities and utilities used across different web applications within the Open Project EXperiences Collection of Projects.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string SharedResourcesProject = "The JSopX™ Shared Resources Class Library Project is a project that contains shared resources such as images, styles, and scripts used across multiple web applications in the Open Project EXperiences Collection of Projects.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string RCLxProperProject = "The JSopX™ (RCL) Razor Class Library Proper Project is a project that contains shared resources such as images, styles, and scripts used across multiple client-side and server-side web applications in the Open Project EXperiences Collection of Projects.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string RCLxAssetsProject = "The JSopX™ (RCL) Razor Class Library Assets Project is a project that contains shared resources such as images, styles, and scripts used across multiple client-side and server-side web applications in the Open Project EXperiences Collection of Projects.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string RCLxComponentsProject = "The JSopX™ (RCL) Razor Class Library Razor Project is a project that contains shared resources specifically for Razor Components being used in our Blazor, and .NET MAUI Hybrid Projects.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string WebApiProject = "The JSopX™ Web API Project is a custom project that implements an ASP.NET Core 8 Web API, serving as the back-end for ALL client-side and server-side web, desktop and mobile applications in the Open Project EXperiences Collection of Projects.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string AspNetCoreProject = "The JSopX™ Asp.NET Core Open Project EXperiences is a demonstration project showcasing how to build a web application using ASP.NET Core 8 Web API.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string AngularCoreProject = "The JSopX™ Angular Core Open Project EXperiences is a demonstration project showcasing how to build a web application using Angular and ASP.NET Core 8 Web API.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string BlazorServerCoreProject = "The JSopX™ Blazor Server Core Open Project EXperiences is a demonstration project that illustrates how to construct a web application using Blazor Server and ASP.NET Core 8 Web API.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string ReactCoreProject = "The JSopX™ React Core Open Project EXperiences is a demonstration project designed to illustrate how to create a web application using React and ASP.NET Core 8 Web API.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string VueCoreProject = "The JSopX™ Vue Core Open Project EXperiences is a demonstration project intended to demonstrate how to develop a web application using Vue and ASP.NET Core 8 Web API.";

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used for the <c>Short</c> product description. 
                    /// </summary>
                    public const string MauiHybridCoreProject = "The JSopX™ .NET MAUI Hybrid Demo Project is a demonstration project intended to demonstrate how to develop a multi-platform applications that deploy to the Web, to Windows and Mac Desktop application, and native mobile applications for Windows Phone, iPhone, Andriod and Samsung.";

                }
            }

            /// <summary>
            /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle Product GitHub SEO friendly URLs &amp;
            /// .git URLs.
            /// </summary>
            public static class GitHubUrls
            {
                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences root GitHub handle.
                /// </summary>
                public const string GitHubHandleName = "https://github.com/JasonSilvestri/";

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences root GitHub handle .git suffix.
                /// </summary>
                public const string GitHubRepoSuffix = ".git";

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle Product GitHub SEO friendly URLs (i.e., https://github.com/JasonSilvestri/JSopX.ClassLibrary).
                /// </summary>
                public static class SeoFriendlyUrls
                {

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string OpenXProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.OpenProjectX;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string BridgeTooFarProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.BridgeTooFar;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string ClassLibraryProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.ClassLibrary;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string WebApiProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.WebAPI;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string SharedResourcesProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.SharedResources;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string RCLxProperProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.RCLxProper;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string RCLxAssetsProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.RCLxAssets;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>                  
                    public const string RCLxComponentsProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.RCLxComponents;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string AspNetCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.AspNetCore;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string AngularCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.AngularCore;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string BlazorServerCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.BlazorServerCore;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string ReactCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.ReactCore;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string VueCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.VueCore;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub SEO friendly URL.
                    /// </summary>
                    public const string MauiHybridNetCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.MauiHybridNetCore;

                }

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle Product GitHub physical '.git' repository URL of the project (i.e., https://github.com/JasonSilvestri/JSopX.ClassLibrary.git).
                /// </summary>
                public static class DotGitUrls
                {

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string OpenXProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.OpenProjectX + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string BridgeTooFarProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.BridgeTooFar + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string ClassLibraryProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.ClassLibrary + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string WebApiProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.WebAPI + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string SharedResourcesProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.SharedResources + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string RCLxProperProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.RCLxProper + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string RCLxAssetsProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.RCLxAssets + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>                  
                    public const string RCLxComponentsProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.RCLxComponents + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string AspNetCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.AspNetCore + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string AngularCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.AngularCore + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string BlazorCoreServerProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.BlazorServerCore + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string ReactCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.ReactCore + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string VueCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.VueCore + GitHubRepoSuffix;

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constant used to handle Product GitHub Official Repository URL.
                    /// </summary>
                    public const string MauiHybridNetCoreProject = GitHubHandleName + WebAppDemoSettings.StronglyTypedAssemblyNames.MauiHybridNetCore + GitHubRepoSuffix;

                }

            }

        }

        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle JWT Token
        /// evaluation, but this is a test class. Will explain on next checkin.
        /// </summary>
        internal static class InternalWebAppDemoSettings
        {

            public const string JwtIssuer = "YourIssuer";
            public const string JwtAudience = "YourAudience";
            public const string JwtKey = "YourSuperSecretKey";
        }


        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle JWT Token
        /// evaluation, but this is a test class. Will explain on next checkin.
        /// </summary>
        sealed class SealedWebAppDemoSettings
        {

            public const string JwtIssuer = "YourIssuer";
            public const string JwtAudience = "YourAudience";
            public const string JwtKey = "YourSuperSecretKey";
        }


        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class used to handle JWT Token
        /// evaluation, but this is a test class. Will explain on next checkin.
        /// </summary>
        sealed class SealedInternalWebAppDemoSettings
        {
            internal static class InternalWebAppDemoSettings
            {

                public const string JwtIssuer = "YourIssuer";
                public const string JwtAudience = "YourAudience";
                public const string JwtKey = "YourSuperSecretKey";
            }
        }


        /// <summary>
        /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Project EXperiences Constants class for handling all product information across 
        /// the jSilvestri.com BETA v 2024 JSopX™ Open Demo Collection projects that could be considered sensitive info
        /// and extra steps taken to secure data as the applications evolve through the phases.
        /// <para>
        /// ⚠ IMPORTANT ⚠
        /// </para>
        /// <para>
        /// This project is currently in Phase <c>1</c> of <c>4</c>, where deliberate "minimum viable product" 
        /// decisions are made to demonstrate the project's evolution across phases. It is important to note that 
        /// storing sensitive data in variables (of most kinds) is not secure, and should not be common practice.
        /// </para>
        /// <para>
        /// Many of these constants will be redfined as <c>internal</c> propeties to secure their
        /// sensitivity, and already have most projects (assemblies) declared as friends that can
        /// access these future internal constants. Moreover, it is the best case until the projects
        /// call for, and have access to, something more secure, like an Azure Vault object, for example.
        /// </para>
        /// </summary>
        public static class WebAppDemoSettings
        {

            /// <summary>
            /// Custom jSilvestri.com Constant used to handle the JWT Authentication token Issuer, a property
            /// we will be using in the near future Phase of the application(s) release to handle 
            /// authentication.
            /// <para>
            /// ⚠ IMPORTANT ⚠
            /// </para>
            /// <para>
            /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
            /// ready release. It has been left as-is by design, to mimic minimum viable product business
            /// requirement. In other words, the app does not yet require it, but it will in final releases
            /// of the application where all applications call for the JWT authentication design 
            /// pattern for login and authentication, using the various projects that will use it
            /// for said authentication (i.e JSopX.Asp.NETCore, JSopX.BlazorServerCore, JSopX.AngularCore, JSopX.ReactCore, JSopX.VueCore, etc.)
            /// </para>
            /// </summary>
            public const string JwtIssuer = "YourIssuer";


            /// <summary>
            /// Custom jSilvestri.com Constant used to handle the JWT Authentication token Audience, a property
            /// we will be using in the near future Phase of the application(s) release to handle 
            /// authentication.
            /// <para>
            /// ⚠ IMPORTANT ⚠
            /// </para>
            /// <para>
            /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
            /// ready release. It has been left as-is by design, to mimic minimum viable product business
            /// requirement. In other words, the app does not yet require it, but it will in final releases
            /// of the application where all applications call for the JWT authentication design 
            /// pattern for login and authentication, using the various projects that will use it
            /// for said authentication (i.e JSopX.Asp.NETCore, JSopX.BlazorServerCore, JSopX.AngularCore, JSopX.ReactCore, JSopX.VueCore, etc.)
            /// </para>
            /// </summary>
            public const string JwtAudience = "YourAudience";

            /// <summary>
            /// Custom jSilvestri.com Constant used to handle the JWT Authentication token Key, a property
            /// we will be using in the near future Phase of the application(s) release to handle 
            /// authentication.
            /// <para>
            /// ⚠ IMPORTANT ⚠
            /// </para>
            /// <para>
            /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
            /// ready release. It has been left as-is by design, to mimic minimum viable product business
            /// requirement. In other words, the app does not yet require it, but it will in final releases
            /// of the application where all applications call for the JWT authentication design 
            /// pattern for login and authentication, using the various projects that will use it
            /// for said authentication (i.e JSopX.Asp.NETCore, JSopX.BlazorServerCore, JSopX.AngularCore, JSopX.ReactCore, JSopX.VueCore, etc.)
            /// </para>
            /// </summary>
            public const string JwtKey = "YourSuperSecretKey";


            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle all common
            /// string-based, strongly-typed, assembly names of projects.
            /// <para>
            /// ⚠ IMPORTANT ⚠
            /// </para>
            /// <para>
            /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
            /// ready release. 
            /// </para>
            /// </summary>  
            public static class StronglyTypedAssemblyNames
            {

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string OpenProjectX = "JSopX.OpenProjectX";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string BridgeTooFar = "JSopX.BridgeTooFar";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle string-based, strongly-typed, 
                /// assembly name of the project. This property is not used in the friend 
                /// assembly configurations above, but are used in other areas of this
                /// application and beyond.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string ClassLibrary = "JSopX.ClassLibrary";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string WebAPI = "JSopX.WebAPI";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string SharedResources = "JSopX.SharedResources";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string RCLxProper = "JSopX.RCLxProper";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string RCLxAssets = "JSopX.RCLxAssets";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string RCLxComponents = "JSopX.RCLxComponents";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string AngularCore = "JSopX.AngularCore";

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string ReactCore = "JSopX.ReactCore";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string VueCore = "JSopX.VueCore";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string AspNetCore = "JSopX.AspNetCore";


                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string BlazorServerCore = "JSopX.BlazorServerCore";

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle 
                /// string-based, strongly-typed, assembly name of the 
                /// project.
                /// <para>
                /// ⚠ IMPORTANT ⚠
                /// </para>
                /// <para>
                /// This property <c>MUST</c> be converted to an <c>internal</c> const before production
                /// ready release. It is currently defined as <c>public</c> by design, to mimic real-world early 
                /// product development (e.g., minimal viable product).
                /// </para>
                /// </summary>
                public const string MauiHybridNetCore = "JSopX.MauiHybridNetCore";

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle all common
            /// string-based Favorite Icon settings for Pages 
            /// (for all major devices).
            /// </summary>
            public static class FavoriteIcons
            {
                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Apple Icons for Pages.
                /// </summary>
                public static class AppleTouch
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Apple Icons Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "apple-touch-icon";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Apple Icons Sizes Link
                    /// Settings.
                    /// </summary>
                    public static class Sizes
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Sizes Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "180x180";

                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Apple Icons Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "/apple-touch-icon.png";

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons x 32 for Pages.
                /// </summary>
                public static class IconsX32
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 32 Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "icon";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 32 Types Link
                    /// Settings.
                    /// </summary>
                    public static class Types
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Types Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "image/png";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 32 Sizes Link
                    /// Settings.
                    /// </summary>
                    public static class Sizes
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Sizes Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "32x32";

                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 32 Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "/favicon-32x32.png";

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons x 16 for Pages.
                /// </summary>
                public static class IconsX16
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 16 Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "icon";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 16 Types Link
                    /// Settings.
                    /// </summary>
                    public static class Types
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Types Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "image/png";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 16 Sizes Link
                    /// Settings.
                    /// </summary>
                    public static class Sizes
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Sizes Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "16x16";

                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x 16 Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "/favicon-16x16.png";

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons x Manifest for Pages.
                /// </summary>
                public static class IconsXManifest
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x Manifest Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "manifest";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x Manifest Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "/site.webmanifest";

                    }
                }


                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons x MaskIcon for Pages.
                /// </summary>
                public static class IconsXMaskIcon
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x MaskIcon Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "mask-icon";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x MaskIcon Colors Link
                    /// Settings.
                    /// </summary>
                    public static class Colors
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Colors Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "#17699f";

                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons x MaskIcon Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "/safari-pinned-tab.svg";

                    }
                }


                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons Microsoft Applicaition for Pages.
                /// </summary>
                public static class IconsMicrosoftApplicaition
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons Microsoft Applicaition Meta Link
                    /// Settings.
                    /// </summary>
                    public static class Metas
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle all common
                        /// string-based Favorite Icon settings for Icons Microsoft 
                        /// Applicaition Meta Names Settings.
                        /// </summary>
                        public static class Names
                        {
                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds just the 
                            /// string-based Page Meta Name Setting for the Default Value.
                            /// </summary>
                            public const string Default = "msapplication-TileColor";
                        }


                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle all common
                        /// string-based Favorite Icon settings for Icons Microsoft 
                        /// Applicaition Meta Content Settings.
                        /// </summary>
                        public static class Content
                        {
                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds just the 
                            /// string-based Page Meta Name Setting for the Default Value.
                            /// </summary>
                            public const string Default = "#17699f";
                        }
                    }

                }


                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons  Theme Color Applicaition for Pages.
                /// </summary>
                public static class IconsThemeColors
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons  Theme Color Applicaition Meta Link
                    /// Settings.
                    /// </summary>
                    public static class Metas
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle all common
                        /// string-based Favorite Icon settings for Icons  Theme Color 
                        /// Applicaition Meta Names Settings.
                        /// </summary>
                        public static class Names
                        {
                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds just the 
                            /// string-based Page Meta Name Setting for the Default Value.
                            /// </summary>
                            public const string Default = "theme-color";
                        }


                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle all common
                        /// string-based Favorite Icon settings for Icons  Theme Color 
                        /// Applicaition Meta Content Settings.
                        /// </summary>
                        public static class Content
                        {
                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds just the 
                            /// string-based Page Meta Name Setting for the Default Value.
                            /// </summary>
                            public const string Default = "#17699f";
                        }
                    }

                }


                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for Icons Primary FavIcon for Pages.
                /// </summary>
                public static class IconsPrimaryFavIcon
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons Primary FavIcon Rel Link
                    /// Settings.
                    /// </summary>
                    public static class Rels
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Rel Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "icon";

                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Primary FavIcon Types Link
                    /// Settings.
                    /// </summary>
                    public static class Types
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Types Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "image/x-icon";

                    }

                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for Icons Primary FavIcon Href Link
                    /// Settings.
                    /// </summary>
                    public static class Href
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Href Link Setting for the Default Value.
                        /// </summary>
                        public const string Default = "favicon.ico";

                    }
                }

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle all common
            /// string-based Favorite Icon settings for META Tags Format Detection Applicaition for Pages.
            /// </summary>
            public static class FormatDetectionApplicaition
            {
                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for META Tags Format Detection Applicaition Meta Link
                /// Settings.
                /// </summary>
                public static class Metas
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for META Tags Format Detection 
                    /// Applicaition Meta Names Settings.
                    /// </summary>
                    public static class Names
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Meta Name Setting for the Default Value.
                        /// </summary>
                        public const string Default = "format-detection";
                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for META Tags Format Detection 
                    /// Applicaition Meta Content Settings.
                    /// </summary>
                    public static class Content
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Meta Name Setting for the Default Value.
                        /// </summary>
                        public const string Default = "telephone=no";
                    }
                }

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle all common
            /// string-based Favorite Icon settings for META Tags View Port for Pages.
            /// </summary>
            public static class ViewPort
            {
                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for META Tags View Port Meta Link
                /// Settings.
                /// </summary>
                public static class Metas
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for META Tags Format Detection 
                    /// Applicaition Meta Names Settings.
                    /// </summary>
                    public static class Names
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Meta Name Setting for the Default Value.
                        /// </summary>
                        public const string Default = "viewport";
                    }


                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Favorite Icon settings for META Tags Format Detection 
                    /// Applicaition Meta Content Settings.
                    /// </summary>
                    public static class Content
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Meta Name Setting for the Default Value.
                        /// </summary>
                        public const string Default = "width=device-width, height=device-height, initial-scale=1.0, maximum-scale=1.0, user-scalable=0";
                    }
                }

            }


            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle all common
            /// string-based Favorite Icon settings for META Tags Charset for Pages.
            /// </summary>
            public static class Charset
            {
                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Favorite Icon settings for META Tags Charset Meta Link
                /// Settings.
                /// </summary>
                public static class Metas
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constants class used to handle all common
                    /// string-based Charset.
                    /// </summary>
                    public static class Charset
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds just the 
                        /// string-based Page Meta Charset Default Value.
                        /// </summary>
                        public const string Default = "utf-8";
                    }

                }

            }


            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle common string-based 
            /// Protocol schemas, such as http, https, etc.
            /// </summary>      
            public static class Protocol
            {

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle the string-based
                /// protocol for SSL (i.e. https://). 
                /// </summary>
                public const string Https = "https://";

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle the string-based
                /// protocol for HTTP (i.e. http://). 
                /// </summary>
                public const string Http = "http://";

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle the string-based
                /// protocol for SSL, with no colons or slashes (i.e. https). 
                /// </summary>
                public const string HttpsNoColonsSlashes = "https";

                /// <summary>
                /// Custom jSilvestri.com Constant used to handle the string-based
                /// protocol for HTTP, with no colons or slashes (i.e. http). 
                /// </summary>
                public const string HttpNoColonsSlashes = "http";

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle common string-based 
            /// Root object of the application, like the common tilde location to establish Absolute URLs, 
            /// in addition to the DotDot Relative URLs, the DEV or UAT servers, and/or any other root 
            /// object we may want to use.
            /// </summary>      
            public static class Root
            {

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based known App Domain URLs "website domains" to use in 
                /// constructing URLs and URIs.
                /// </summary>
                public static class AppDomainUrls
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the 
                    /// public web domain URL. 
                    /// </summary>
                    public const string DefaultDomain = "www.jsilvestri.com";

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the 
                    /// public web domain URL. 
                    /// </summary>
                    public const string DefaultSubDomain = "jsilvestri.com";

                }

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Root Slug we use to construct the "Root" part of a 
                /// URL or URI.
                /// </summary>
                public static class Slugs
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the "~" Root
                    /// Slug, used to construct the "Root" part of a URL or URI. This Root
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today. The other Root Slug choices are to use in very specific 
                    /// server operations and/or localized testing cases. 
                    /// </summary>
                    public const string Tilde = "~/";

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the "./" Root
                    /// Slug, used to construct the "Root" part of a URL or URI. This Root
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today. The other Root Slug choices are to use in very specific 
                    /// server operations and/or localized testing cases. 
                    /// <para>
                    /// ATTN JasonXWebApp Developer ::
                    /// </para>
                    /// Remember, this is a relative path, and it assumes you are already 
                    /// in the root directory. For deeper drill downs, try the other relative
                    /// path choices.
                    /// </summary>
                    public const string DotForwardSlash = "./";

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Pipeline "Development Server" Root
                    /// Slug, used to construct the "Root" part of a URL or URI.
                    /// </summary>
                    public const string DevelopmentServerPipeline = AppDomainUrls.DefaultDomain;

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the None Pipeline "Staging Server" Root
                    /// Slug used to construct the "Root" part of a URL or URI. This specific version
                    /// uses SQLVM.
                    /// </summary>
                    public const string StageServerNoPipeline = AppDomainUrls.DefaultDomain;

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Pipeline "UAT Server" Root
                    /// Slug, used to construct the "Root" part of a URL or URI.
                    /// </summary>
                    public const string UATServerPipeline = AppDomainUrls.DefaultDomain;

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Pipeline "Production Server" Root
                    /// Slug, used to construct the "Root" part of a URL or URI.
                    /// </summary>
                    public const string ProductionServerPipeline = AppDomainUrls.DefaultSubDomain;

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Pipeline "Production Server" Root
                    /// Slug, used to construct the "Root" part of a URL or URI.
                    /// </summary>
                    public const string ProductionServerPipelineWWW = AppDomainUrls.DefaultDomain;

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the DefaultRoot
                    /// Slug, used to construct the "Root" part of a URL or URI. This Root
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today. The other Root Slug choices are to use in very specific 
                    /// server operations and/or localized testing cases. For now, it will
                    /// just be targeting the Tilde constant.
                    /// </summary>
                    public const string DefaultJsopxRoot = Tilde;
                }

            }


            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle common string-based 
            /// Port object of the application, like the common  location to establish 
            /// Absolute URLs, using localhost (i.e., localhost:44329). Please keep in mind
            /// that these ports are just the potential number integer to use (or not use).
            /// </summary>      
            public static class Ports
            {

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle all common
                /// string-based Root Slug we use to construct the "Port" part of a 
                /// URL or URI (i.e., 80, 443 - which if either, we should make this 
                /// value 0).
                /// </summary>
                public static class Slugs
                {
                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Port "80" value
                    /// Slug, used to construct the "Port" part of a URL or URI. This Port
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today.
                    /// <para>
                    /// ⚠ IMPORTANT ⚠
                    /// </para>
                    /// We DO NOT want to create a port value for URLs or URIs if the port value
                    /// is "80", because that is reserved. This value is more to check against in
                    /// -coming ports if anything.
                    /// </summary>
                    public const int port80 = 80;

                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Port "443" value
                    /// Slug, used to construct the "Port" part of a URL or URI. This Port
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today.
                    /// <para>
                    /// ⚠ IMPORTANT ⚠
                    /// </para>
                    /// We DO NOT want to create a port value for URLs or URIs if the port value
                    /// is "443", because that is reserved. This value is more to check against in
                    /// -coming ports if anything.
                    /// </summary>
                    public const int port443 = 443;


                    /// <summary>
                    /// Custom jSilvestri.com Constant used to handle the Port "443" value
                    /// Slug, used to construct the "Port" part of a URL or URI. This Port
                    /// Slug should be the default to use with Absolute URL Helpers we have
                    /// today.
                    /// <para>
                    /// ⚠ IMPORTANT ⚠
                    /// </para>
                    /// We DO NOT want to create a port value for URLs or URIs if the port value
                    /// is "443", because that is reserved. This value is more to check against in
                    /// -coming ports if anything.
                    /// </summary>
                    public const string portNone = "";

                }

            }

        }

        /// <summary>
        /// Custom jSilvestri.com Constants class used to handle all common
        /// string-based app Cards (i.e., your contact card on app, 
        /// Swagger card, license cards, etc).
        /// </summary>
        public static class AppCards
        {
            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle most common
            /// string-based properties of your contact card.
            /// </summary>
            public static class YourContactCards
            {

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds just your 
                /// string-based First Name.
                /// </summary>
                public const string FirstName = "Jason";

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds just your 
                /// string-based Last Name.
                /// </summary>
                public const string LastName = "Silvestri";

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds just your 
                /// string-based Full Name.
                /// </summary>
                public const string FullName = FirstName + " " + LastName;

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds just your 
                /// string-based Email.
                /// </summary>
                public const string Email = "therealjasonsilvestri@gmail.com";

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds just your 
                /// string-based primary URL (i.e., your blog, company website, etc.).
                /// </summary>
                public const string PrimaryUrl = "https://jsilvestri.com";

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle basic App license
            /// cards.
            /// </summary>
            public static class AppLicenseCards
            {
                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                /// card.
                /// </summary>
                public static class Mit
                {

                    /// <summary>
                    /// Custom jSilvestri.com Constants Property that holds 
                    /// string-based default Name Text for the MIT card.
                    /// </summary>
                    public const string Name = "MIT Licensed";

                    /// <summary>
                    /// Custom jSilvestri.com Constants Property that holds 
                    /// string-based default URL for the MIT card.
                    /// </summary>
                    public const string Url = "https://opensource.org/licenses/MIT";

                }

                /// <summary>
                /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                /// card.
                /// </summary>
                public static class AppTermsOfServices
                {

                    /// <summary>
                    /// Custom jSilvestri.com Constants Property that holds 
                    /// string-based default Name Text for the App card.
                    /// </summary>
                    public const string Name = "Terms of Service";

                    /// <summary>
                    /// Custom jSilvestri.com Constants Property that holds 
                    /// string-based default URL for the MIT card.
                    /// </summary>
                    public const string Url = "https://opensource.org/licenses/MIT";

                }

            }

            /// <summary>
            /// Custom jSilvestri.com Constants class used to handle basic App Swagger 
            /// cards that allow us a temp, static way, to configure Swagger for each 
            /// application with a working WebAPI which is then used to dynamically
            /// render CRUD services and operartions.
            /// </summary>
            public static class AppSwaggerCards
            {

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds 
                /// string-based default Name Text for the App card.
                /// </summary>
                public const string SwagVersion = "v1";

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds 
                /// string-based default Swagger JSON Endpoint.
                /// </summary>
                public const string SwagEndPointUri = "/swagger/v1/swagger.json";

                /// <summary>
                /// Custom jSilvestri.com Constants Property that holds 
                /// the true/false flag, indicating whether Swagger should be
                /// serializable using the legacy 2.0 standard for backwards 
                /// compatability or go for the new 3.0 standard.
                /// </summary>
                public const bool IsSwagSerializeAsV2 = true;

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class OpenProjectX
                {

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsopxAppVer = JsopxAppProjects.ProductVersions.JsopxMainProjectName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsopxAppProjects.Names.Short.OpenProjectX;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsopxAppProjects.Descriptions.Default.OpenProjectX;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsopxAppProjects.GitHubUrls.SeoFriendlyUrls.OpenXProject;

                    }

                }

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class ClassLibrary
                {

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsopxAppVer = JsopxAppProjects.ProductVersions.JsopxClassLibraryProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsopxAppProjects.Names.Short.ClassLibraryProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsopxAppProjects.Descriptions.Default.ClassLibraryProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsopxAppProjects.GitHubUrls.SeoFriendlyUrls.ClassLibraryProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class WebApi
                {


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsopxAppVer = JsopxAppProjects.ProductVersions.JsopxWebApiProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsopxAppProjects.Names.Short.WebApiProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsopxAppProjects.Descriptions.Default.WebApiProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsopxAppProjects.GitHubUrls.SeoFriendlyUrls.WebApiProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class SharedResources
                {
                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsopxAppVer = JsopxAppProjects.ProductVersions.JsopxSharedResourcesProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsopxAppProjects.Names.Short.SharedResourcesProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsopxAppProjects.Descriptions.Default.SharedResourcesProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsopxAppProjects.GitHubUrls.SeoFriendlyUrls.SharedResourcesProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class AngularCore
                {


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsopxAppVer = JsopxAppProjects.ProductVersions.JsopxAngularJsProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsopxAppProjects.Names.Short.AngularCoreProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsopxAppProjects.Descriptions.Default.AngularCoreProject;


                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsopxAppProjects.GitHubUrls.SeoFriendlyUrls.AngularCoreProject;

                    }

                }

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class BlazorServerCore
                {


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsopxAppVer = JsopxAppProjects.ProductVersions.JsopxBlazorProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsopxAppProjects.Names.Short.BlazorServerCoreProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsopxAppProjects.Descriptions.Default.BlazorServerCoreProject;


                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsopxAppProjects.GitHubUrls.SeoFriendlyUrls.BlazorServerCoreProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class MauiHybridNetCore
                {


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsopxAppVer = JsopxAppProjects.ProductVersions.JsopxMAUIProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsopxAppProjects.Names.Short.MauiHybridCoreProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsopxAppProjects.Descriptions.Default.MauiHybridCoreProject;


                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsopxAppProjects.GitHubUrls.SeoFriendlyUrls.MauiHybridNetCoreProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class ReactCore
                {


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsopxAppVer = JsopxAppProjects.ProductVersions.JsopxReactJsProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsopxAppProjects.Names.Short.ReactCoreProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsopxAppProjects.Descriptions.Default.ReactCoreProject;


                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsopxAppProjects.GitHubUrls.SeoFriendlyUrls.ReactCoreProject;

                    }
                }

                /// <summary>
                /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                /// </summary>
                public static class VueCore
                {


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class Contact
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Name = YourContactCards.FullName;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Email = YourContactCards.Email;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string PrimaryUrl = YourContactCards.PrimaryUrl;

                    }

                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class License
                    {

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic MIT App license
                        /// card.
                        /// </summary>
                        public static class Mit
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the MIT card.
                            /// </summary>
                            public const string Name = AppLicenseCards.Mit.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.Mit.Url;

                        }

                        /// <summary>
                        /// Custom jSilvestri.com Constants class used to handle basic App Terms license
                        /// card.
                        /// </summary>
                        public static class AppTermsOfServices
                        {

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default Name Text for the App card.
                            /// </summary>
                            public const string Name = AppLicenseCards.AppTermsOfServices.Name;

                            /// <summary>
                            /// Custom jSilvestri.com Constants Property that holds 
                            /// string-based default URL for the MIT card.
                            /// </summary>
                            public const string Url = AppLicenseCards.AppTermsOfServices.Url;

                        }

                    }


                    /// <summary>
                    /// Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Class Constant used for Swagger product card configuration. 
                    /// </summary>
                    public static class SwagDoc
                    {
                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagVersion = AppSwaggerCards.SwagVersion;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default swag card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string SwagEndPointUri = AppSwaggerCards.SwagEndPointUri;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that holds 
                        /// the true/false flag, indicating whether Swagger should be
                        /// serializable using the legacy 2.0 standard for backwards 
                        /// compatability or go for the new 3.0 standard.
                        /// </summary>
                        public const bool IsSwagSerializeAsV2 = AppSwaggerCards.IsSwagSerializeAsV2;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string JsopxAppVer = JsopxAppProjects.ProductVersions.JsopxVueProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Title = JsopxAppProjects.Names.Short.VueCoreProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string Description = JsopxAppProjects.Descriptions.Default.VueCoreProject;

                        /// <summary>
                        /// Custom jSilvestri.com Constants Property that shares a copy of
                        /// your default contact card through the product instances we
                        /// are currently configuring.
                        /// </summary>
                        public const string TermsOfService = JsopxAppProjects.GitHubUrls.SeoFriendlyUrls.VueCoreProject;

                    }
                }

            }

        }

    }
}

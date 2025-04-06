# <img src="https://github.com/JasonSilvestri/JSopX.BridgeTooFar/blob/master/JSopX.BridgeTooFar/doc-assets/jsopx-rcl-x-components-logo.svg" style="width: 28px; height: auto; margin-right:12px; margin-top:12px;!important;"> JSopX™ RCL x Components Project

The **JSopX™ RCL x Components Project**, _code named_, `JSopX.RCLxComponents` is a totally **FREE**, open-source, Razor Class Library, that evolved from the `SharedResources` Project, and is now the official _production-ready successor_ (by design). This Razor Class Library manages static assets with a more modern approach. It ensures that all projects benefit from a centralized, easily maintainable asset pipeline for development environments.

---

## **Use Latest Variant:**

> [!TIP]
> You are currently viewing the **"_Use Latest_" _Variant_** of the **JSopX™ RCL x Components Project**. 
> 
> For more details, see [Getting Started](#getting-started) _below_.

---

```bash
# For The Cool Kids: Clone JSopX.RCLxComponents Git Repository
$ git clone https://github.com/JasonSilvestri/JSopX.RCLxComponents.git
```

---

[`Home`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/README.md) » [`Introduction`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/) » [`Projects`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/) · · **`Use Latest`** · [`By-Phase`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/README.md) · [`From Scratch`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/RECREATEME.md) · · [`« Previous`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxProper/) [`Next »`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AspNetCore/)

---

## Table of Contents

  - [Overview](#overview)
  - [Prerequisites](#prerequisites)
  - [Getting Started](#getting-started)
  - [Step 1: Clone the Repository](#step-1-clone-the-repository)
  - [Step 2: Open the Solution](#step-2-open-the-solution)
  - [Step 3: Configure the Project](#step-3-configure-the-project)
  - [Step 4: Build and Run](#step-4-be-sure-to-build-and-run)
  - [Step 5: Project File Structure](#step-5-project-file-structure)
  - [Step 6: JSopX™ Project References & Dependencies](#step-6-jsopx-project-references--dependencies)
  - [Step 7: Usage](#step-7-usage)
  - [Step 8: Extended Usage](#step-8-extended-usage)
  - [Next Steps](#next-steps)

---

## Overview

The **JSopX™ RCL x Components Project**, _code named_, `JSopX.RCLxComponents` is a totally **FREE**, open-source, Razor Class Library, that evolved from the `SharedResources` Project, and is now the official _production-ready successor_ (by design). This Razor Class Library manages static assets with a more modern approach. It ensures that all projects benefit from a centralized, easily maintainable asset pipeline for development environments.

We initially create the project to simulate a [Shared Assets & Resources Projects](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxProjectsFamilies.md#2-shared-assets--resources-projects) that will need to be leveraged by the other new and existing client side and server side projects, which act as standards that conform to the initial [business requirements](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxEnterpriseBusinessRequirements.md) set forth by the fictional stakeholders.

As the project evolves through each [Lifecycle Phase](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Phases/ReadMe.md), we extend the application by creating new user interfaces, the integratation of standardized assets and resources commonly used across projects that comply to the stakeholder's brand standards we are tasked with creating, perform typical increase of security and documentation, while anticipating we'll face a near-future, seamless migration request of the project into our [JSopX.OpenProjectX](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.OpenProjectX/) Enterprise Application.

The Jason Silvestri Open Project EXperiences (JSopX™) Visual Studio Projects collectively form the backbone of the entire suite, each project serving a distinct yet complementary role. 

By aligning varied frameworks—ranging from [ASP.NET Core](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AspNetCore/README.md) to [Angular](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AngularCore/README.md), [Vue](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.VueCore/README.md), [React](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/README.md), [Blazor](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.BlazorServerCore/README.md), [MAUI](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.MauiHybridNetCore/README.md) and more, all using the same [Web API](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.WebAPI/README.md), [assets](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxProper/README.md), [documentation](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.BridgeTooFar/README.md), and [standards](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxDisciplinesRequiredForEnterpriseDevelopment.md)—these projects create a consistent development landscape where code can be shared, extended, and integrated seamlessly.

The result is an environment that transforms a patchwork of independent solutions into a cohesive enterprise ecosystem, making collaboration smoother and long-term maintenance more manageable. As you delve deeper, you’ll discover how each project type fits into this grand tapestry, ensuring uniform standards while preserving the flexibility needed to evolve and adapt.

---

## **Prerequisites**

Be sure each technology is installed, with Components versioning, if your goal is to continue exploring just the `JSopX.RCLxComponents` Project.

- [Visual Studio (v 17.13.5)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/Technologies/#visual-studio)
- [.NET Framework (v 9.0.1)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/Technologies/#net-framework)
- [ASP.NET Core (v 9.0.1)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/Technologies/#aspnet-core)

---

## **Getting Started**

Carefully _choose_ the variant approach below that fits your current objective:

---

### 1. **Continue Installing `JSopX.`RCLxComponents**:

- **[Continue](#step-1-clone-the-repository)** → **Continue** as **you were**, exploring and/or installing the `JSopX.RCLxComponents` _Using Latest_ Variant.  

---

### 2. **Use Different Variant**:

- **[Browse By-Phase](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/README.md)** → **Browse** **previous versions** of the application by **phases** using the `JSopX.RCLxComponents` _By-Phase_ Variant.   
- **[Start From Scratch](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/RECREATEME.md)** → **Create project** from scratch, step-by-step, using the `JSopX.RCLxComponents` _From Scratch_ Variant.
- **[Get All Projects](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.OpenProjectX/README.md)** → **Get all projects** instead, using the `JSopX.OpenProjectX` Enterprise Application.

---

## **Step 1: Clone the Repository**

_Clone_ the `JSopX.RCLxComponents` GitHub Repository if you plan to explore it independently from the rest of the projects.

Choose the approach below that fits your environment:  

- **[Bash](#step-11-using-bash)** → Ideal for **Linux, macOS, and Windows (WSL/Git Bash)** users.  
- **[PowerShell](#step-12-using-powershell)** → Best for **Windows** users.  
- **[Node.js](#step-13-using-nodejs-or-npm-degit)** → A lightweight option for developers using **JavaScript-based workflows**.  

---

### **Step 1.1: Using `Bash`:**
 
```bash

 # Using Bash: Clone JSopX.RCLxComponents Git Repository

 # 1. Navigate to the desired local directory where you plan to clone the repository
 cd path\to\local\repo\JasonSilvestri\JSopX.RCLxComponents

 # 2. Clone JSopX.RCLxComponents Git Repository       
 git clone https://github.com/JasonSilvestri/JSopX.RCLxComponents.git
    
```

[`Back to Top`](#table-of-contents)

---

### **Step: 1.2: Using `Powershell`:**

```powershell

 # Using PowerShell: Clone JSopX.RCLxComponents Git Repository

 # 1. Navigate to the desired local directory where you plan to clone the repository
 cd path\to\local\repo\JasonSilvestri\JSopX.RCLxComponents

 # 2. Clone JSopX.RCLxComponents Git Repository       
 git clone https://github.com/JasonSilvestri/JSopX.RCLxComponents.git

```

[`Back to Top`](#table-of-contents)

---

### **Step: 1.3: Using `Node.js` or `npm` (degit):**
 
```shell

 # Using Node.js / npm : Clone JSopX.RCLxComponents Git Repository
 # 1. Navigate to the desired local directory where you plan to clone the repository
 cd path\to\local\repo\JasonSilvestri\JSopX.RCLxComponents
    
 # 2. Using npx degit to clone without .git history
 npx degit https://github.com/JasonSilvestri/JSopX.RCLxComponents

```

[`Back to Top`](#table-of-contents)

---

## **Step 2: Open the Solution**

Working with the `JSopX.RCLxComponents` Project in Visual Studio is simple enough.

1. Launch **[Visual Studio (v 17.13.5)](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/Technologies/#visual-studio)**.
2. Open the solution file: `JSopX.RCLxComponents.sln`.

[`Back to Top`](#table-of-contents)

---

## **Step 3: Configure the Project**

> [!TIP]
>
> Latest versions of [Visual Studio](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/Technologies/#visual-studio) performs this step regularly, dropping and restoring project dependencies, nuget packages and other resources between builds automatically (*by design*). Still, it is good practice to at least be aware of the commands outlined in this step.
> 

---

### **Step: 3.1: Ensure Dependencies Are Restored:**

Ensure `JSopX.RCLxComponents` Project dependencies are restored:

```bash
 npm install
```

[`Back to Top`](#table-of-contents)

---

### **Step: 3.2: Verify Nuget Packages:**

Verify that all NuGet packages are up to date:

```bash
 dotnet restore
```
   
[`Back to Top`](#table-of-contents)

---

## **Step 4: Be Sure to Build and Run**

Building and Running the `JSopX.BridgeTooFar` Project in Visual Studio is also another simple task.

### **Step: 4.1: Build and Run**:

1. Build the solution in [Visual Studio](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/Technologies/#visual-studio).
2. Run the project:
   - Use the **IIS Express** profile for local development.

---

### **Step: 4.2: And Now Your Done**:

Assuming the `JSopX.BridgeTooFar` Project is running as expected, **you are now done** with the **installation** and **execution** of the project!

1. **Skip Remaining Steps**: 
   - Technically, you could skip to the [Next Steps](#next-steps) section if you are on a project-by-project installation mission.
2. **Conclude Remaining Steps**:
   - **Me personally?** I would continue on to the remaining steps _below_, starting at **[Step 5: Project Structure](#step-5-project-file-structure)**. There is just very useful information related to the project that I would find helpful.

[`Back to Top`](#table-of-contents)

---

## **Step 5: Project File Structure**

The `JSopX.RCLxComponents` Project in particular, contains several files and directories, all with their own functionality & purpose for existing. 

For brevity, samples will not have the complete file structure you get when installing, but there are some core files and directories that have special consideration you should get to know. 

---

### **Step: 5.1: Structured Project & Solution Considerations**:

All `JSopX™ projects` follow a consistent directory structure. 

1. I create a [Visual Studio](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/Technologies/#visual-studio) Solution Folder to house the primary `.sln` solution file.
2. I create a similar Server-Side Project Folder for `.csproj`, and related files.

A common, plain-text file folder structure of the `JSopX.RCLxComponents` Solution and Projects should look something like what follows:

```plaintext
# JSopX™ RCL x Components Solution and Projects

JSopX.RCLxComponents/                 # Root JSopX.RCLxComponents Visual Studio Solution folder.
├── JSopX.RCLxComponents.sln          # Visual Studio solution file for Angular Core.
├── PathConfig.targets            # Centralized MSBuild target configuration for project references.
├── JSopX.RCLxComponents/             # ASP.NET Core server-side application folder.
│   ├── JSopX.RCLxComponents.csproj   # Asp.NET Core Visual Studio Server Project configuration file.

```

There are a few reasons why I do this, but the primary reason is ensuring references are managed effectively and circular dependencies are avoided.

[`Back to Top`](#table-of-contents)

---

### **Step: 5.2: Structured File Tree**:

A common, plain-text file structure of the `JSopX.RCLxComponents` Project.

```plaintext
# JSopX™ RCL x Components Project

JSopX.RCLxComponents/                          # Root JSopX™ RCL x Components Project Visual Studio Solution folder.
├── .gitattributes                         # Git attributes file for repository metadata and configurations.
├── .gitignore                             # Specifies files and directories to ignore in version control.
├── JSopX.RCLxComponents.sln                   # Visual Studio solution '.sln' file for JSopX™ RCL x Components Project.
├── LICENSE.txt                            # Licensing information for the project.
├── PathConfig.targets                     # Centralized MSBuild target configuration for project references.
├── README.md                              # High-level project documentation.
├── JSopX.RCLxComponents/                      # ASP.NET Core server-side application folder.
│   ├── JSopX.RCLxComponents.csproj            # Asp.NET Core Visual Studio Server Project '.csproj' configuration file.


```

[`Back to Top`](#table-of-contents)

---

### **Step: 5.3: Structured Table**:

A table structure of the same `JSopX.RCLxComponents` Project, files and resources.

| File/Folder Name                        | Description                                                                 |
|:----------------------------------------|:-----------------------------------------------------------------------------|
| &nbsp;📁&nbsp;**JSopX.RCLxComponents**&nbsp;            | Root folder for the JSopX™ RCL x Components Project Visual Studio Solution.   |
| &nbsp;├&nbsp;📝&nbsp;`.gitattributes`&nbsp;                | Git attributes file for repository metadata and configurations.            |
| &nbsp;├&nbsp;📝&nbsp;`.gitignore`&nbsp;                    | Specifies files and directories to ignore in version control.              |
| &nbsp;├&nbsp;📝&nbsp;`JSopX.RCLxComponents.sln`&nbsp;        | Visual Studio solution `.sln` file for the JSopX™ RCL x Components Project.         |
| &nbsp;├&nbsp;📝&nbsp;`LICENSE.txt`&nbsp;                   | Licensing information for the project.                                     |
| &nbsp;├&nbsp;📝&nbsp;`PathConfig.targets`&nbsp;            | Centralized MSBuild target configuration for project references.           |
| &nbsp;├&nbsp;📝&nbsp;`README.md`&nbsp;                     | High-level project documentation.                                          |
| &nbsp;├&nbsp;📁&nbsp;**JSopX.RCLxComponents/**&nbsp;            | ASP.NET Core server-side application folder.                               |
| &nbsp;&nbsp;&nbsp;&nbsp;├&nbsp;📝&nbsp;`JSopX.RCLxComponents.csproj`&nbsp; | Asp.NET Core Visual Studio Server Project `.csproj` configuration file.                                 |

[`Back to Top`](#table-of-contents)

---

## **Step 6: JSopX™ Project References & Dependencies**

Most **JSopX™ Projects** leverage shared resources and code from other projects within the JSopX™ ecosystem. This ensures modularity, maintainability, and scalability.

The **`JSopX.RCLxComponents` Project** is one of the highest-level resource libraries, hence, it has almost no natural dependencies, but have the majority of the projects that rely on it.

1. **`JSopX.OpenProjectX`**:
   - The [Flagship Project](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxProjectsFamilies.md#1-flagship-projects) parent enterprise application solution.
   - **Explore GitHub**: [JSopX.OpenProjectX](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.OpenProjectX)

2. **`JSopX.AspNetCore`**:
   - An **Asp.NET Core** [Server-Side “Existing” Apps Examples](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxProjectsFamilies.md#4-server-side-existing-apps-examples) project, created to simulate an existing Asp.NET Core application we are now tasked with migrating into our enterprise application, adopting our standards, API and more.
   - **Explore GitHub**: [JSopX.AspNetCore](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AspNetCore)

3. **`JSopX.MauiHybridNetCore`**:
    - A **.NET MAUI Hyrbid** [Server-Side “Existing” Apps Examples](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxProjectsFamilies.md#4-server-side-existing-apps-examples) cross-platform applications, for desktop applications, native mobile applications, traditional web, while adopting our standards, API and more, and looking damn good doing it too.
    - **Explore GitHub**: [JSopX.MauiHybridNetCore](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.MauiHybridNetCore)

4. **`JSopX.BlazorServerCore`**:
    - A **Blazor Server .NET Core**  [Server-Side “Existing” Apps Examples](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxProjectsFamilies.md#4-server-side-existing-apps-examples) project, created to simulate an existing Asp.NET Core Blazor application we are now tasked with migrating into our enterprise application, adopting our standards, API and more.
    - **Explore GitHub**: [JSopX.BlazorServerCore](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.BlazorServerCore)

5. **`JSopX.AngularCore`**:
    - An **Angular Core** [Client-Side “Existing” Apps Examples](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxProjectsFamilies.md#5-client-side-existing-apps-examples) project, created to simulate an existing Angular Core application we are now tasked with migrating into our enterprise application, adopting our standards, API and more.
    - **Explore GitHub**: [JSopX.AngularCore](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AngularCore)

6. **`JSopX.ReactCore`**:
    - A **React Core** [Client-Side “Existing” Apps Examples](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxProjectsFamilies.md#5-client-side-existing-apps-examples) project, created to simulate an existing React Core application we are now tasked with migrating into our enterprise application, adopting our standards, API and more.
    - **Explore GitHub**: [JSopX.ReactCore](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore)
  
7. **`JSopX.VueCore`**:
    - A **Vue Core** [Client-Side “Existing” Apps Examples](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/JSopxProjectsFamilies.md#5-client-side-existing-apps-examples) created to simulate an existing Vue Core application we are now tasked with migrating into our enterprise application, adopting our standards, API and more.
    - **Explore GitHub**: [JSopX.VueCore](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.VueCore)
  
[`Back to Top`](#table-of-contents)

---

## **Step 7: Usage**

### **Step: 7.1: Referencing the `JSopX.`RCLxComponents Project**

1. **Add a project reference** to `JSopX.RCLxComponents` in each client-side and/or server-side projects that want to have consume the project's assets:
   - _Right-click_ on a project, such as [`JSopX.AngularCore`](#step-82-using-jsopxRCLxComponents-project-in-an-angular-project), [`JSopX.ReactCore`](#step-84-using-jsopxRCLxComponents-project-in-a-react-project), [`JSopX.VueCore`](#step-83-using-jsopxRCLxComponents-project-in-a-vue-project), [`JSopX.BlazorServerCore`](#step-81-using-jsopxRCLxComponents-project-in-a-blazor-project), etc.
   - Select **Add** > **Project Reference**.
   - Check `JSopX.RCLxComponents` and click **OK**.

[`Back to Top`](#table-of-contents)

---

## **Step 8: Extended Usage**

> [!TIP]
> These particular `Extended Usage` examples **are not** required to implement. They are just example extended usages for those of whom are new to projects like the `JSopX.RCLxComponents` Project.
>

---

### **Step: 8.1: Using `JSopX.`RCLxComponents Project in a Blazor Project**

**In [`JSopX.BlazorServerCore`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.BlazorServerCore/)**:

1. **Reference the JSopX™ RCL x Components Project**:
   - Add a reference to `JSopX.RCLxComponents` in [`JSopX.BlazorServerCore`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.BlazorServerCore/p1/v1).

2. **Use Static Files in `Razor` Components**:
   - Create a `Razor` component that wants to use the shared static files.
   
     ```razor
      @page "/example"
      @inject IWebHostEnvironment env

      <h3>Re-Using JSopX™ RCL x Components Project Assets Example Page</h3>

      <img src="@($"{env.WebRootPath}/doc-assets/jsopx-logo.svg")" alt="Reusing Official JSopX™ Logo in Blazor Server Core Application">
      <script src="@($"{env.WebRootPath}/doc-assets/js/script.js")"></script>
      <link rel="stylesheet" href="@($"{env.WebRootPath}/doc-assets/css/style.css")">
     ```

[`Back to Top`](#table-of-contents)

---

### **Step: 8.2: Using `JSopX.`RCLxComponents Project in an Angular Project**

**In [`JSopX.AngularCore`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AngularCore/)**:

1. **Copy Files Using a `Build Script`**:
   - Create a script to copy the shared resources from `JSopX.RCLxComponents` to the `assets` folder of the Angular project during the build process.

     ```json
      
      "scripts": {
          "postinstall": "npm run copy-rcl-x-components",
          "copy-rcl-x-components": "cp -r ../JSopX.RCLxComponents/* ./src/assets/"
      }
     ```

2. **Use Static Files in `Angular` Components**:
   - Reference the static files in your `Angular` components.

     ```html
      <!-- app.component.html -->
      <img src="assets/doc-assets/jsopx-logo.png" alt="Reusing Official JSopX™ Logo in Angular Application">
      <script src="assets/doc-assets/js/script.js"></script>
      <link rel="stylesheet" href="assets/doc-assets/css/style.css">
     ```

[`Back to Top`](#table-of-contents)

---

### **Step: 8.3: Using `JSopX.`RCLxComponents Project in a Vue Project**

**In [`JSopX.VueCore`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.VueCore/)**:

1. **Copy Files Using a Build Script**:
   - Create a script to copy the shared resources from `JSopX.RCLxComponents` to the `assets` folder of the Vue project during the build process.

      ```json
      
      "scripts": {
          "postinstall": "npm run copy-rcl-x-components",
          "copy-rcl-x-components": "cp -r ../JSopX.RCLxComponents/* ./public/assets/"
      }
      ```

2. **Use Static Files in `Vue` Components**:
   - Reference the static files in your `Vue` components.

      ```html
      <!-- App.vue -->
      <template>
          <div>
              <img src="assets/doc-assets/jsopx-logo.png" alt="Reusing Official JSopX™ Logo in Vue Application">
              <script src="assets/doc-assets/js/script.js"></script>
              <link rel="stylesheet" href="assets/doc-assets/css/style.css">
          </div>
      </template>
      ```

[`Back to Top`](#table-of-contents)

---

### **Step: 8.4: Using `JSopX.`RCLxComponents Project in a React Project**

**In [`JSopX.ReactCore`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.ReactCore/)**:

1. **Copy Files Using a Build Script**:
   - Create a script to copy the shared resources from `JSopX.RCLxComponents` to the `public` folder of the React project during the build process.

     ```json
     // package.json
     "scripts": {
         "postinstall": "npm run copy-rcl-x-components",
         "copy-rcl-x-components": "cp -r ../JSopX.RCLxComponents/* ./public/assets/"
     }
     ```

2. **Use Static Files in `React` Components**:
   - Reference the static files in your `React` components.

     ```javascript
      // App.js
      import React from 'react';

      function App() {
          return (
            <div>
              <img src="assets/doc-assets/jsopx-logo.png" alt="Reusing Official JSopX™ Logo in React Application">
              <script src="assets/doc-assets/js/script.js"></script>
              <link rel="stylesheet" href="assets/doc-assets/css/style.css">
            </div>
          );
      }
 
      export default App;
     ```

[`Back to Top`](#table-of-contents)

---

## **Next Steps**

Carefully choose the approach below that fits your current objective:

---

1. **[Continue](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AspNetCore/README.md)** → _Continue_ as **you were**, exploring and/or installing other projects like you did with **this project**. You'll move onto the next project, using the `JSopX.AspNetCore` _Using Latest_ Variant.  

---

1. **[Browse By-Phase](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/README.md)** → **Browse** **previous versions** of the application by **phases** using the `JSopX.RCLxComponents` _By-Phase_ Variant.   
2. **[Start From Scratch](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/RECREATEME.md)** → **Create project** from scratch, step-by-step, using the `JSopX.RCLxComponents` _From Scratch_ Variant.
3. **[Get All Projects](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.OpenProjectX/README.md)** → **Get all projects** instead, using the `JSopX.OpenProjectX` Enterprise Application.

---

[`Home`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/README.md) » [`Introduction`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/Introduction/) » [`Projects`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/) · · **`Use Latest`** · [`By-Phase`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/README.md) · [`From Scratch`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxComponents/p1/v1/RECREATEME.md) · · [`Back to Top`](#table-of-contents) · [`« Previous`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.RCLxProper/) [`Next »`](https://github.com/JasonSilvestri/JSopX.BridgeTooFar/tree/master/JSopX.BridgeTooFar/DocsOpenX/OpenProjects/jsopx.AspNetCore/)

---

##### [JSopX.com](https://www.jsopx.com/) | [Jason's Official Website](https://www.jsilvestri.com/) | [X](https://www.x.com/JasonSilvestri) | [LinkedIn](http://www.linkedin.com/in/JasonSilvestri) | [GitHub](https://github.com/JasonSilvestri) | [Gmail](mailto:therealjasonsilvestri@gmail.com) | [Phone : 508-851-9445](phoneto:508-851-9445)

###### Copyright © 2025 - All Rights Reserved by Jason Silvestri

# JSopX™ Class Library Asp.NET Core OpenX Project
### from the ﻿jSilvestri.com BETA v 2024 JSopX™ OpenX Demo Collection Project
### Phase 1
> [!IMPORTANT]
> This Project is in Phase 1 of 4. It should be treated as simply reference material for now. Conversely, Phase 2 is days away, and Phase 3 is only a week after that. Phase 3 Projects will be more mature, and action-packed with features, assets and more!

The `JSopX.ClassLibrary` application (i.e., jSilvestri.com BETA v 2024 JSopX™ Class Library) in specific, is a FREE, open-source, custom, reusable, jSilvestri.com BETA v 2024 JSopX™ Open Demo Collections ASP.NET Core 8 Class Library, designed to hold common constants, enums, and helper classes that can be shared across multiple projects. 

## Overview

The `jSilvestri.com BETA v 2024` mobile and web applications, developed for most smart phones, tablets and desktop computers, was created to showcase a wide range of skills to potential clients and employers, while providing helpful information to fellow developers, demos for interview talks, access to resumes, etc.

The `JSopX.ClassLibrary` application (i.e., jSilvestri.com BETA v 2024 JSopX™ Class Library) in specific, is a FREE, open-source, custom, reusable, jSilvestri.com BETA v 2024 JSopX™ Open Demo Collections ASP.NET Core 8 Class Library, designed to hold common constants, enums, and helper classes that can be shared across multiple projects. This library promotes code reuse, reduces duplication, and simplifies maintenance. 

Many applications in the `Custom jSilvestri.com BETA v 2024 JSopX™ Open Demo Collection`, such as the `Angular Web API Demo`, `Blazor Web API Demo`, `React Web API Demo`, and `Vue Web API Demo` applications will use this project to reference common features throughout the collective applications.


## Alerts

Please pay close attention to the alerts that appear in documentation that look like the following:

> [!NOTE]
> Useful information that users should know, even when skimming content.

> [!TIP]
> Helpful advice for doing things better or more easily.

> [!IMPORTANT]
> Key information users need to know to achieve their goal.

> [!WARNING]
> Urgent info that needs immediate user attention to avoid problems.

> [!CAUTION]
> Advises about risks or negative outcomes of certain actions.

### Prerequisites

The JSopX™ OpenX `JSopX.ClassLibrary`Project requires at least the following technologies to run as expected.

- [jSilvestri.com BETA v 2024 JSopX™ OpenX Collection Project](https://github.com/JasonSilvestri/JSopX.OpenXDemoCollection)
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [ASP.NET Core 8 Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [Visual Studio or Visual Studio Code 2022 (v 17.10.3) or higher](https://visualstudio.microsoft.com/)
 

### Corequisites

Just about every project from the [jSilvestri.com BETA v 2024 JSopX™ OpenX Collection Project](https://github.com/JasonSilvestri/JSopX.OpenXDemoCollection) uses this `JSopX.ClassLibrary` Project. 

I encourage all who visit to dive in as much as you like, perform peer reviews, engage, and have fun! Conversely, to ensure all apps run as expected, you will need to know some of the following technologies:

- [ASP.NET Core 8 Documentation](https://learn.microsoft.com/en-us/aspnet/core/)
- [.NET Core Blazor 8 Documentation](https://learn.microsoft.com/en-us/aspnet/core/blazor/)
- [.NET Core MAUI 8 Documentation](https://learn.microsoft.com/en-us/dotnet/maui/)
- [Angular CLI 18.0.3 Documentation](https://angular.io/cli)
- [React 18.2.0 Documentation](https://reactjs.org/docs/getting-started.html)
- [Vue 3.4.21 Documentation](https://vuejs.org/guide/introduction.html)
- [Vite 5.2.8 Documentation](https://vitejs.dev/)
- [Node 20.14.0 Documentation](https://nodejs.org/en/docs/)
- [npm 10.8.1 Documentation](https://docs.npmjs.com/)

### Postrequisites

If you have no interest in reviewing the documentation on the technologies from above - I totally get! However, you should at least check your machine to know if you have the above technologies or higher in order for the project(s) to work as expected.

- **ASP.NET Core 8:**

    ```bash
    dotnet --version
    ```

- **.NET Core Blazor 8:**

    ```bash
    dotnet --list-sdks
    ```

- **.NET Core MAUI 8:**

    ```bash
    dotnet --list-sdks
    ```

- **Angular CLI: 18.0.3**

    ```bash
    ng version
    ```

- **React 18.2.0**

    ```bash
    npm list react
    ```

- **Vue 3.4.21**

    ```bash
    npm list vue
    ```

- **Vite 5.2.8**

    ```bash
    npm list vite
    ```

- **Node 20.14.0**

    ```bash
    node -v
    ```

- **npm 10.8.1**

    ```bash
    npm -v
    ```

## VS Project & Solution Structure
The JSopX™ OpenX `JSopX.ClassLibrary` class library, is a shared library, and one of serveral projects that make up all apps in the [Official jSilvestri.com BETA v 2024 JSopX™ OpenX Collection Project](https://github.com/JasonSilvestri/JSopX.OpenXDemoCollection). It is worth just skimming through them below if you have a sec.

**The solution includes the following projects:**

- **[Official jSilvestri.com BETA v 2024 JSopX™ OpenX Collection Project](https://github.com/JasonSilvestri/JSopX.OpenXDemoCollection)**: The main `JSopX.OpenXDemoCollection` solution. This soluton includes all projects described below, but doesn't have any major function outside having a place where all projects can be consumed at once. In fact, all projects below were also designed to have their own, independent repositories, which can be downloaded and/or run alone (respectfully).

**The JSopX™ OpenX Shared Projects:**

The following JSopX™ Projects are used to share common resources and information across all other projects.

1. **[JSopX™ Web API Project](https://github.com/JasonSilvestri/JSopX.WebApi)**: The `JsopxWebAPI` Project, is an ASP.NET Core Web API project with JWT authentication and generic CRUD operations.
2. **[JSopX™ Class Library Project](https://github.com/JasonSilvestri/JSopX.ClassLibrary)**: The `JSopX.ClassLibrary` class library, is a shared library, containing constants, DTOs, and helper classes. 
3. **[JSopX™ Shared Resources Project](https://github.com/JasonSilvestri/JSopX.SharedResources)**: The `JSopX.SharedResources` shared recources library, containing common HTML, CSS, JS, Images and other reuseable theming objects across projects in a more traditional way.
4. **[JSopX™ Razor Class Library Assets Project](https://github.com/JasonSilvestri/JSopX.RazorClassLibraryAssets)**: The `JSopX.RazorClassLibraryAssets` shared recources library, containing common HTML, CSS, JS, Images and other reuseable theming objects across projects in a more traditional way.
5. **[JSopX™ Razor Class Library Components Project](https://github.com/JasonSilvestri/JSopX.RazorClassLibraryComponents)**: The `JSopX.RazorClassLibraryComponents` shared recources library, containing common HTML, CSS, JS, Images and other reuseable theming objects across projects in a more traditional way.

**The JSopX™ OpenX Projects that access the Asp.NET Core WebAPI:**

The following Projects are different front-end and back-end technologies, such as Angular, React & Vue, backed by Asp.NET Core back-end (for security purposes). Nonetheless, these different Web API Demos & technology access the same primary Web API for CRUD operations. I consider myself still in Discovery with the latest versions of these technologies, but that is all part of the game.

- **[JSopX™ Asp.NET Core OpenX Project](https://github.com/JasonSilvestri/JSopX.AspNetCoreOpX)**: An Asp.NET Core Client-Side and Server-Side Server .NET Core Web API project.
- **[JSopX™ Blazor Asp.NET Core OpenX Project](https://github.com/JasonSilvestri/JSopX.BlazorServerCoreOpX)**: A Blazor and Asp.NET Core OpenX Project Client-Side and Server-Side .NET Core Web API project.
- **[JSopX™ Angular Core OpenX Project](https://github.com/JasonSilvestri/JSopX.AngularCoreOpX)**: An Angular and Asp.NET Core OpenX Project Client-Side and Server-Side .NET Core Web API project.
  - **JsopxAngularCoreOpX.Server**: The server-side .NET Core Web API project.
  - **jsopxangularcoreopx.client**: The client-side Angular project.
- **[JSopX™ React Core OpenX Project](https://github.com/JasonSilvestri/JSopX.ReactCoreOpX)**: A React and Asp.NET Core OpenX Project Client-Side and Server-Side .NET Core Web API project.
  - **JsopxReactCoreOpX.Server**: The server-side .NET Core Web API project.
  - **jsopxreactcoreopx.client**: The client-side React project.
- **[JSopX™ Vue Core OpenX Project](https://github.com/JasonSilvestri/JSopX.VueCoreOpX)**: A Vue and Asp.NET Core OpenX Project Client-Side and Server-Side .NET Core Web API project.
  - **JsopxVueCoreOpX.Server**: The server-side .NET Core Web API project.
  - **jsopxvuecoreopx.client**: The client-side Vue project.
- **[JSopX™ MAUI Hybrid OpenX Project](https://github.com/JasonSilvestri/JSopX.OpenXDemoCollection)**: The flagship .NET MAUI Hybrid Muti-Platform Application of the jSilvestri.com BETA v 2024 JSopX™ OpenX Collection Project, which deploys to the Web, Windows & Mac Desktop, and native Windows, iPhone, Andriod, and Samsug mobile application.

## JSopX™ Class Library OpenX Project Structure

The project is organized into the following structure:

### Constants

- **JsopxConstants.cs**: Contains constant values used across the application, such as JWT settings.

### Enums

- **JsopxEnums.cs**: Defines enums for user roles within the application.

### Helpers

- **JwtHelper.cs**: Provides methods for generating and validating JWT tokens.

## Getting Started

### Installation

1. **Clone the repository**:

    ```bash
    git clone https://github.com/JasonSilvestri/JSopX.ClassLibrary.git
    ```

2. **Open the solution in Visual Studio**:

    - Open `JSopX.ClassLibrary.sln` in Visual Studio.

3. **Build the project**:

    - Right-click on the solution in Solution Explorer and select `Build Solution`.

### Usage

#### Adding the JSopX™ Class Library to Other Projects

1. **Add Project Reference**:

    - In the solution that requires the common library, right-click on the project in Solution Explorer.
    - Select `Add` > `Reference`.
    - Check the box for `JSopX.ClassLibrary` and click `OK`.

2. **Use the Common Code**:

    - You can now use the constants, enums, and helpers from the `JSopX.ClassLibrary` in your other projects.

#### Example Usage

**Using Constants**:

```csharp
using JSopX.ClassLibrary.JsopxConstants;

public class ExampleService
{
    public void PrintJwtSettings()
    {
        Console.WriteLine($"Issuer: {JsopxConstants.WebAppDemoSettings.JwtIssuer}");
        Console.WriteLine($"Audience: {JsopxConstants.WebAppDemoSettings.JwtAudience}");
        Console.WriteLine($"Key: {JsopxConstants.WebAppDemoSettings.JwtKey}");
    }
}
```

---

## Using Shared Resources in Client Projects

### Reference the Shared Resources Project

1. **Add a project reference** to `JsxSharedResources` in each client project:
    - Right-click on the client project (e.g., `JsxAngularWebApiDemo`, `JsxReactWebApiDemo`, `JsxVueWebApiDemo`, `JsxBlazorWebApiDemo`).
    - Select **Add** > **Project Reference**.
    - Check `JsxSharedResources` and click **OK**.

### Example: Blazor Project

**In `JsxBlazorWebApiDemo`**:

1. **Reference the Shared Resources Project**:
    - Add a reference to `JsxSharedResources` in `JsxBlazorWebApiDemo`.

2. **Use Static Files in Razor Components**:
    - Create a Razor component that uses the shared static files.

    ```razor
    @page "/example"
    @inject IWebHostEnvironment env

    <h3>Example Page</h3>

    <img src="@($"{env.WebRootPath}/images/logo.png")" alt="Logo">
    <script src="@($"{env.WebRootPath}/JavaScript/script.js")"></script>
    <link rel="stylesheet" href="@($"{env.WebRootPath}/CSS/style.css")">
    ```

### Example: Angular Project

**In `JsxAngularWebApiDemo`**:

1. **Copy Files Using a Build Script**:
    - Create a script to copy the shared resources from `JsxSharedResources` to the `assets` folder of the Angular project during the build process.

    ```json
    
    "scripts": {
        "postinstall": "npm run copy-shared-resources",
        "copy-shared-resources": "cp -r ../JsxSharedResources/* ./src/assets/"
    }
    ```

2. **Use Static Files in Angular Components**:
    - Reference the static files in your Angular components.

    ```html
    <!-- app.component.html -->
    <img src="assets/images/logo.png" alt="Logo">
    <script src="assets/JavaScript/script.js"></script>
    <link rel="stylesheet" href="assets/CSS/style.css">
    ```

### Example: Vue Project

**In `JsxVueWebApiDemo`**:

1. **Copy Files Using a Build Script**:
    - Create a script to copy the shared resources from `JsxSharedResources` to the `assets` folder of the Vue project during the build process.

    ```json
    
    "scripts": {
        "postinstall": "npm run copy-shared-resources",
        "copy-shared-resources": "cp -r ../JsxSharedResources/* ./public/assets/"
    }
    ```

2. **Use Static Files in Vue Components**:
    - Reference the static files in your Vue components.

    ```html
    <!-- App.vue -->
    <template>
        <div>
            <img src="assets/images/logo.png" alt="Logo">
            <script src="assets/JavaScript/script.js"></script>
            <link rel="stylesheet" href="assets/CSS/style.css">
        </div>
    </template>
    ```

### Example: React Project

**In `JsxReactWebApiDemo`**:

1. **Copy Files Using a Build Script**:
    - Create a script to copy the shared resources from `JsxSharedResources` to the `public` folder of the React project during the build process.

    ```json
    // package.json
    "scripts": {
        "postinstall": "npm run copy-shared-resources",
        "copy-shared-resources": "cp -r ../JsxSharedResources/* ./public/assets/"
    }
    ```

2. **Use Static Files in React Components**:
    - Reference the static files in your React components.

    ```javascript
    // App.js
    import React from 'react';

    function App() {
        return (
            <div>
                <img src="assets/images/logo.png" alt="Logo" />
                <script src="assets/JavaScript/script.js"></script>
                <link rel="stylesheet" href="assets/CSS/style.css" />
            </div>
        );
    }

    export default App;
    ```


### Conclusion

This area of the guide provides a basic overview of setting up the `JsxSharedResources` project to manage shared static resources and using these resources in various client projects (`JsxAngularCoreWebApiDemo`, `JsxReactCoreWebApiDemo`, `JsxVueCoreWebApiDemo`, and `JsxBlazorServerCoreWebApiDemo`). Follow the instructions to ensure your projects can consistently and efficiently utilize shared resources.

---

# Option 2: All-in-One Approach for Static Resources

This guide provides an overview of how to create an All-in-One approach to manage and share static resources (HTML, CSS, JS, fonts, images, etc.) across various server-side and client-side projects including ASP.NET Core, Blazor, React, Vue, and Angular.

## 1. Create a Shared Static Resources Project

### Steps

1. **Create a Razor Class Library for Static Resources:**

    **File Structure:**
    ```
    /src
      /MyApp.SharedResources
        /MyApp.SharedResources.csproj
        /wwwroot
          /css
            /styles.css
          /js
            /scripts.js
          /fonts
            /my-font.ttf
          /images
            /logo.png
          /index.html
    ```

2. **Configure the Project File:**

    **`MyApp.SharedResources.csproj`:**
    ```xml
    <Project Sdk="Microsoft.NET.Sdk.Razor">
      <PropertyGroup>
        <TargetFramework>net8.0</TargetFramework>
        <RazorLangVersion>8.0</RazorLangVersion>
      </PropertyGroup>
      <ItemGroup>
        <Content Include="wwwroot\**\*" CopyToOutputDirectory="PreserveNewest" />
      </ItemGroup>
    </Project>
    ```

## 2. Reference Shared Resources in ASP.NET Core Project

### Steps

1. **Add Project Reference:**

    **File Structure:**
    ```
    /src
      /MyApp.Api
        /MyApp.Api.csproj
      /MyApp.SharedResources
    ```

2. **Configure the Project File:**

    **`MyApp.Api.csproj`:**
    ```xml
    <Project Sdk="Microsoft.NET.Sdk.Web">
      <PropertyGroup>
        <TargetFramework>net8.0</TargetFramework>
      </PropertyGroup>
      <ItemGroup>
        <ProjectReference Include="..\MyApp.SharedResources\MyApp.SharedResources.csproj" />
      </ItemGroup>
    </Project>
    ```

3. **Configure Startup:**

    **`Startup.cs` (or `Program.cs` for minimal hosting model):**
    ```csharp
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // Serve static files from the shared resources
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(env.ContentRootPath, "wwwroot")),
                RequestPath = "/shared"
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
    ```

## 3. Reference Shared Resources in Client-Side Projects

### React

1. **Create a React Project:**

    ```bash
    npx create-react-app my-app-react
    cd my-app-react
    ```

2. **Fetch Static Files:**

    Modify `public/index.html` to load static resources from the ASP.NET Core backend.

    **`my-app-react/public/index.html`:**
    ```html
    <!DOCTYPE html>
    <html lang="en">
    <head>
      <meta charset="UTF-8">
      <link rel="stylesheet" href="https://localhost:5001/shared/css/styles.css">
    </head>
    <body>
      <div id="root"></div>
      <script src="https://localhost:5001/shared/js/scripts.js"></script>
    </body>
    </html>
    ```

### Vue

1. **Create a Vue Project:**

    ```bash
    npm init vue@3 my-app-vue
    cd my-app-vue
    ```

2. **Fetch Static Files:**

    Modify `public/index.html` to load static resources from the ASP.NET Core backend.

    **`my-app-vue/public/index.html`:**
    ```html
    <!DOCTYPE html>
    <html lang="en">
    <head>
      <meta charset="UTF-8">
      <link rel="stylesheet" href="https://localhost:5001/shared/css/styles.css">
    </head>
    <body>
      <div id="app"></div>
      <script src="https://localhost:5001/shared/js/scripts.js"></script>
    </body>
    </html>
    ```

### Angular

1. **Create an Angular Project:**

    ```bash
    ng new my-app-angular
    cd my-app-angular
    ```

2. **Fetch Static Files:**

    Modify `index.html` to load static resources from the ASP.NET Core backend.

    **`my-app-angular/src/index.html`:**
    ```html
    <!DOCTYPE html>
    <html lang="en">
    <head>
      <meta charset="UTF-8">
      <link rel="stylesheet" href="https://localhost:5001/shared/css/styles.css">
    </head>
    <body>
      <app-root></app-root>
      <script src="https://localhost:5001/shared/js/scripts.js"></script>
    </body>
    </html>
    ```

3. **Configure HTTP Client Module:**

    Add `HttpClientModule` to `app.module.ts` to ensure API requests work.

    **`my-app-angular/src/app/app.module.ts`:**
    ```typescript
    import { BrowserModule } from '@angular/platform-browser';
    import { NgModule } from '@angular/core';
    import { HttpClientModule } from '@angular/common/http';
    import { AppComponent } from './app.component';

    @NgModule({
      declarations: [
        AppComponent
      ],
      imports: [
        BrowserModule,
        HttpClientModule
      ],
      providers: [],
      bootstrap: [AppComponent]
    })
    export class AppModule { }
    ```

## 4. Testing and Verification

### Testing Static Resource Access

- **Verify Static Files in ASP.NET Core:**

    Access static files from the backend, e.g., `https://localhost:5001/shared/css/styles.css`, to ensure the resources are served correctly.

- **Verify Static Files in Client-Side Projects:**

    Check the network tab in browser developer tools to ensure that static files are fetched correctly from the ASP.NET Core backend.

### Example Directory Structures

- **ASP.NET Core Project:**
    ```
    /src
      /MyApp.Api
        /wwwroot
          /css
            /styles.css
          /js
            /scripts.js
          /fonts
            /my-font.ttf
          /images
            /logo.png
          /index.html
    ```

- **Client-Side Projects:**
    - **React:** `public/index.html`
    - **Vue:** `public/index.html`
    - **Angular:** `src/index.html`

---
# Creating .NET 8 Class Libraries, Razor Libraries, Packs, NuGet Packages & More

This guide provides an overview of how to create and utilize .NET 8 Class Libraries, Razor Libraries, Packs, and NuGet Packages across ASP.NET Core, Blazor, React, Vue, and Angular projects.

## 1. Creating .NET 8 Class Libraries

### Steps

1. **Create the Class Library Project:**

    ```bash
    dotnet new classlib -n MyApp.SharedLib
    ```

2. **Add Business Logic to the Class Library:**

    **`MyApp.SharedLib/StringHelper.cs`:**
    ```csharp
    namespace MyApp.SharedLib.Utilities
    {
        public static class StringHelper
        {
            public static string ToTitleCase(string input)
            {
                if (string.IsNullOrWhiteSpace(input)) return input;
                return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
            }
        }
    }
    ```

3. **Create a Razor Class Library Project (for UI Components):**

    ```bash
    dotnet new razorclasslib -n MyApp.UIComponents
    ```

4. **Add Razor Components:**

    **`MyApp.UIComponents/Components/HelloWorld.razor`:**
    ```razor
    <h3>Hello, world!</h3>
    ```

5. **Pack and Publish the Libraries (Optional):**

    ```bash
    dotnet pack -c Release
    dotnet nuget push MyApp.SharedLib.1.0.0.nupkg -k <YOUR_API_KEY> -s https://api.nuget.org/v3/index.json
    ```

## 2. Using .NET 8 Class Libraries in Blazor Projects

### Steps

1. **Create a Blazor WebAssembly Project:**

    ```bash
    dotnet new blazorwasm -n MyApp.Blazor
    ```

2. **Add Project References:**

    **`MyApp.Blazor/MyApp.Blazor.csproj`:**
    ```xml
    <Project Sdk="Microsoft.NET.Sdk.BlazorWebAssembly">
      <PropertyGroup>
        <TargetFramework>net8.0</TargetFramework>
      </PropertyGroup>
      <ItemGroup>
        <ProjectReference Include="..\MyApp.SharedLib\MyApp.SharedLib.csproj" />
        <ProjectReference Include="..\MyApp.UIComponents\MyApp.UIComponents.csproj" />
      </ItemGroup>
    </Project>
    ```

3. **Use Shared Library and Razor Components:**

    **`MyApp.Blazor/Pages/Index.razor`:**
    ```razor
    @page "/"
    @using MyApp.SharedLib.Utilities
    @using MyApp.UIComponents.Components

    <h3>@StringHelper.ToTitleCase("hello, world!")</h3>
    <HelloWorld />
    ```

## 3. Using .NET 8 Class Libraries in React Projects

### Steps

1. **Create a React Project:**

    ```bash
    npx create-react-app my-app-react
    cd my-app-react
    ```

2. **Fetch Data from ASP.NET Core API:**

    **`my-app-react/src/App.js`:**
    ```javascript
    import React, { useState, useEffect } from 'react';
    import axios from 'axios';

    function App() {
      const [titleCase, setTitleCase] = useState('');

      useEffect(() => {
        axios.get('https://localhost:5001/api/sample/titlecase?input=hello, world!')
          .then(response => setTitleCase(response.data));
      }, []);

      return (
        <div>
          <h3>{titleCase}</h3>
        </div>
      );
    }

    export default App;
    ```

## 4. Using .NET 8 Class Libraries in Vue Projects

### Steps

1. **Create a Vue Project:**

    ```bash
    npm init vue@3 my-app-vue
    cd my-app-vue
    ```

2. **Fetch Data from ASP.NET Core API:**

    **`my-app-vue/src/App.vue`:**
    ```html
    <template>
      <div>
        <h3>{{ titleCase }}</h3>
      </div>
    </template>

    <script>
    import axios from 'axios';

    export default {
      data() {
        return {
          titleCase: ''
        };
      },
      mounted() {
        axios.get('https://localhost:5001/api/sample/titlecase?input=hello, world!')
          .then(response => this.titleCase = response.data);
      }
    };
    </script>
    ```

## 5. Using .NET 8 Class Libraries in Angular Projects

### Steps

1. **Create an Angular Project:**

    ```bash
    ng new my-app-angular
    cd my-app-angular
    ```

2. **Fetch Data from ASP.NET Core API:**

    **`my-app-angular/src/app/app.component.ts`:**
    ```typescript
    import { HttpClient } from '@angular/common/http';
    import { Component, OnInit } from '@angular/core';

    @Component({
      selector: 'app-root',
      template: '<h3>{{ titleCase }}</h3>',
    })
    export class AppComponent implements OnInit {
      titleCase: string = '';

      constructor(private http: HttpClient) {}

      ngOnInit() {
        this.http.get<string>('https://localhost:5001/api/sample/titlecase?input=hello, world!')
          .subscribe(data => this.titleCase = data);
      }
    }
    ```

    **`my-app-angular/src/app/app.module.ts`:**
    ```typescript
    import { BrowserModule } from '@angular/platform-browser';
    import { NgModule } from '@angular/core';
    import { HttpClientModule } from '@angular/common/http';
    import { AppComponent } from './app.component';

    @NgModule({
      declarations: [
        AppComponent
      ],
      imports: [
        BrowserModule,
        HttpClientModule
      ],
      providers: [],
      bootstrap: [AppComponent]
    })
    export class AppModule { }
    ```

---

# Option 3: All-in-One Approach for Static Resources

This guide provides an overview of how to create an All-in-One approach to manage and share static resources (HTML, CSS, JS, fonts, images, etc.) across various server-side and client-side projects including ASP.NET Core, Blazor, React, Vue, and Angular.

## 1. Create a Shared Static Resources Project

### Steps

1. **Create a Razor Class Library for Static Resources:**

    **File Structure:**
    ```
    /src
      /MyApp.SharedResources
        /MyApp.SharedResources.csproj
        /wwwroot
          /css
            /styles.css
          /js
            /scripts.js
          /fonts
            /my-font.ttf
          /images
            /logo.png
          /index.html
    ```

2. **Configure the Project File:**

    **`MyApp.SharedResources.csproj`:**
    ```xml
    <Project Sdk="Microsoft.NET.Sdk.Razor">
      <PropertyGroup>
        <TargetFramework>net8.0</TargetFramework>
        <RazorLangVersion>8.0</RazorLangVersion>
      </PropertyGroup>
      <ItemGroup>
        <Content Include="wwwroot\**\*" CopyToOutputDirectory="PreserveNewest" />
      </ItemGroup>
    </Project>
    ```

## 2. Reference Shared Resources in ASP.NET Core Project

### Steps

1. **Add Project Reference:**

    **File Structure:**
    ```
    /src
      /MyApp.Api
        /MyApp.Api.csproj
      /MyApp.SharedResources
    ```

2. **Configure the Project File:**

    **`MyApp.Api.csproj`:**
    ```xml
    <Project Sdk="Microsoft.NET.Sdk.Web">
      <PropertyGroup>
        <TargetFramework>net8.0</TargetFramework>
      </PropertyGroup>
      <ItemGroup>
        <ProjectReference Include="..\MyApp.SharedResources\MyApp.SharedResources.csproj" />
      </ItemGroup>
    </Project>
    ```

3. **Configure Startup:**

    **`Startup.cs` (or `Program.cs` for minimal hosting model):**
    ```csharp
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            // Serve static files from the shared resources
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
                    Path.Combine(env.ContentRootPath, "wwwroot")),
                RequestPath = "/shared"
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
    ```

## 3. Reference Shared Resources in Client-Side Projects

### React

1. **Create a React Project:**

    ```bash
    npx create-react-app my-app-react
    cd my-app-react
    ```

2. **Fetch Static Files:**

    Modify `public/index.html` to load static resources from the ASP.NET Core backend.

    **`my-app-react/public/index.html`:**
    ```html
    <!DOCTYPE html>
    <html lang="en">
    <head>
      <meta charset="UTF-8">
      <link rel="stylesheet" href="https://localhost:5001/shared/css/styles.css">
    </head>
    <body>
      <div id="root"></div>
      <script src="https://localhost:5001/shared/js/scripts.js"></script>
    </body>
    </html>
    ```

### Vue

1. **Create a Vue Project:**

    ```bash
    npm init vue@3 my-app-vue
    cd my-app-vue
    ```

2. **Fetch Static Files:**

    Modify `public/index.html` to load static resources from the ASP.NET Core backend.

    **`my-app-vue/public/index.html`:**
    ```html
    <!DOCTYPE html>
    <html lang="en">
    <head>
      <meta charset="UTF-8">
      <link rel="stylesheet" href="https://localhost:5001/shared/css/styles.css">
    </head>
    <body>
      <div id="app"></div>
      <script src="https://localhost:5001/shared/js/scripts.js"></script>
    </body>
    </html>
    ```

### Angular

1. **Create an Angular Project:**

    ```bash
    ng new my-app-angular
    cd my-app-angular
    ```

2. **Fetch Static Files:**

    Modify `index.html` to load static resources from the ASP.NET Core backend.

    **`my-app-angular/src/index.html`:**
    ```html
    <!DOCTYPE html>
    <html lang="en">
    <head>
      <meta charset="UTF-8">
      <link rel="stylesheet" href="https://localhost:5001/shared/css/styles.css">
    </head>
    <body>
      <app-root></app-root>
      <script src="https://localhost:5001/shared/js/scripts.js"></script>
    </body>
    </html>
    ```

3. **Configure HTTP Client Module:**

    Add `HttpClientModule` to `app.module.ts` to ensure API requests work.

    **`my-app-angular/src/app/app.module.ts`:**
    ```typescript
    import { BrowserModule } from '@angular/platform-browser';
    import { NgModule } from '@angular/core';
    import { HttpClientModule } from '@angular/common/http';
    import { AppComponent } from './app.component';

    @NgModule({
      declarations: [
        AppComponent
      ],
      imports: [
        BrowserModule,
        HttpClientModule
      ],
      providers: [],
      bootstrap: [AppComponent]
    })
    export class AppModule { }
    ```

## 4. Testing and Verification

### Testing Static Resource Access

- **Verify Static Files in ASP.NET Core:**

    Access static files from the backend, e.g., `https://localhost:5001/shared/css/styles.css`, to ensure the resources are served correctly.

- **Verify Static Files in Client-Side Projects:**

    Check the network tab in browser developer tools to ensure that static files are fetched correctly from the ASP.NET Core backend.

### Example Directory Structures

- **ASP.NET Core Project:**
    ```
    /src
      /MyApp.Api
        /wwwroot
          /css
            /styles.css
          /js
            /scripts.js
          /fonts
            /my-font.ttf
          /images
            /logo.png
          /index.html
    ```

- **Client-Side Projects:**
    - **React:** `public/index.html`
    - **Vue:** `public/index.html`
    - **Angular:** `src/index.html`


## Phase 1 of 4: Planned Evolution of jSilvestri.com BETA v 2024 JSopX™ Open Demo Collection Project

Depending on when you visit this demo application, it may look very different from your previous visit. I am not talking about common checkins to improve the applications. I am talking about noticable, planned, development that will shape each application in accordance to the grand design. In other words, the variability is intentional. 

The purpose of this project, and its associated projects, is to showcase my basic skills in the technologies I am currently exploring in 2024. By leveraging my 20 years of experience in full stack development and solution architecting, I aim to address areas often overlooked in typical online examples, such as security, object-oriented coding, and the transformation of existing assets, templates, and projects into custom creative designs that support specific objectives.

The target technologies and project structures include **Asp.NET Core**, **AngularJS**, **Blazor**, **Vue**, **ReactJS**, and **.NET MAUI Blazor Hybrid**, all of which access the same Web API and shared projects using ASP.NET Core 8 and Visual Studio 2022 (or higher).

### Source Control Strategies

There are typically two primary ways to handle source control for multiple projects:

1. **Monorepo**: Storing all projects within a single GitHub repository. This approach simplifies managing dependencies and integrations between projects and ensures consistency across the solution.
2. **Multi-repo**: Creating separate GitHub repositories for each project. This approach provides greater modularity and allows each project to evolve independently, which can be beneficial if projects have different development cycles or teams.

We will use a combination of both approaches. This hybrid method allows potential clients, employers, and fellow developers to download and run the applications they are most interested in as standalone projects (i.e., _AngularJS_, _Vue_, _ReactJS_, or _Blazor_), all accessing the same Web API project using ASP.NET Core 8 and Visual Studio 2022 (_or higher_), each with their own project and solution. Additionally, this approach ensures we can also create a project and solution that includes all applications, facilitating easy transitions between tiers for various needs (i.e., the _jSilvestri.com BETA v 2024 Web API Demo Collection Project_).

### Project Development Steps - Phase 1:

While this workflow may change, the steps I am taking to conclude all aspects of the project development are as follows:

1. **Add a Class Library**: Add a new ASP.NET Core Class Library project and solution. This project will serve as the common place where we share the most common class and interface parts we want to use across all applications, such as Constants, Enums, Helpers, etc.
   
2. **Add a Web API Project**: Add a new ASP.NET Core Web API project and solution. This project will serve as the backend API that the frontend projects will communicate with.

3. **Add a Shared Assets Project**: Add a new ASP.NET Core project and solution that will handle common, static, assets and resources, shared across all applications. This project will serve as the resource project with all HTML, CSS, JS, Images and other creative all projects will use to carry the same theme, look and feel across applications. For now, all projects will use the basic, out-of-the-box vanilla assets.

4. **Add Frontend Projects**:
   - Add separate projects and solutions for AngularJS, Vue, ReactJS, and Blazor. We will initially choose the appropriate project templates provided by Visual Studio.
   - For AngularJS, Vue, and ReactJS, we will consider creating separate ASP.NET Core Web Application projects and choosing the respective frontend frameworks (i.e., _Angular_, _Vue.js_, _React.js_) during project creation.
   - For Blazor, we will create a Blazor WebAssembly or Blazor Server project, depending on your preference. If I have bandwidth, I may also create a Blazor Hybrid Project, which is relatively new to the scene.

5. **Setup Communication**:
   - Each frontend project (_AngularJS_, _Vue_, _ReactJS_, _Blazor_, etc.) will make HTTP requests to the Web API project to fetch data or perform operations. For the first iteration of data, we will use some static weather data. 

6. **Configure Routes**:
   - We will define appropriate routes in our Web API project to handle incoming requests from the frontend projects.
   - We will implement controllers and actions to handle these routes and interact with our data layer.

7. **Web API Shared Models and Services**:
   - We will consider creating shared models and services that can be used across both the Web API project and the frontend projects. This will help in maintaining consistency and reducing duplication of code.

8. **Authentication and Authorization (Optional)**:
   - Implement authentication and authorization mechanisms in Web API project if required (final version should).

9. **Testing and Debugging**:
   - Test the communication between the frontend projects and the Web API project.
   - Debug any issues that arise during development.

10. **Deployment**:
    - Deploy the Web API project and frontend projects to the desired hosting environment. Ensure that all projects are configured correctly for production.

11. **Continuous Integration and Continuous Deployment (CI/CD)**:
    - Set up CI/CD pipelines to automate the build and deployment process for your solution.


### Project Development Steps - Phase 2:

While this workflow may change, the steps I am taking to conclude all aspects of the project development are as follows:

1. **Update Class Library**: Update ASP.NET Core Class Library project and solution parts we want to use across all applications, such as Constants, Enums, Helpers, etc.
   
2. **Update Web API Project**: Update ASP.NET Core Web API project and solution. This project will serve as the backend API that the frontend projects will communicate with.

3. **Update Shared Assets Project**: Update new ASP.NET Core project and solution that will handle common, static, assets and resources, shared across all applications. This project will serve as the resource project with all HTML, CSS, JS, Images and other creative all projects will use to carry the same theme, look and feel across applications.

4. **Add All Frontend Projects, Assets Projects & Web API to jSilvestri.com BETA v 2024 JSopX™ Open Demo Collection Project Solutions**:
   - Clone all projects and add them to the jSilvestri.com BETA v 2024 JSopX™ Open Demo Collection Project project for full access and testing of all projects in one, unified, location.

5. **Setup Communication**:
   - Each frontend project (_AngularJS_, _Vue_, _ReactJS_, _Blazor_, etc.) will make HTTP requests to the Web API project to fetch data or perform operations. The final version will access real-time weather data from one or more weather APIs available today.
   - Ensure that CORS (_Cross-Origin Resource Sharing_) is properly configured in the Web API project to allow requests from the frontend projects.

6. **Configure Routes**:
   - We will define appropriate routes in our Web API project to handle incoming requests from the frontend projects.
   - We will implement controllers and actions to handle these routes and interact with our data layer.

7. **Shared Models and Services**:
   - We will consider creating shared models and services in their own project, as opposed to housing them in the Web API project that can be used across both the Web API project and the frontend projects. This will help in maintaining consistency and reducing duplication of code.
   - An eventual version of this approach will leverage a structure where we have specific repositories for each service along with a generic repository to handle common CRUD operations, following a design pattern like the Repository Pattern.

8. **Authentication and Authorization (Optional)**:
   - We will use JWT (_JSON Web Tokens_) for authentication and role-based authorization.

9. **Testing and Debugging**:
   - Test the communication between the frontend projects and the Web API project.
   - Debug any issues that arise during development.

10. **Deployment**:
    - Deploy the Web API project and frontend projects to the desired hosting environment. Ensure that all projects are configured correctly for production.

11. **Continuous Integration and Continuous Deployment (CI/CD)**:
    - Set up CI/CD pipelines to automate the build and deployment process for your solution.

**Copyright © 2024 - All Rights Reserved by Jason Silvestri**

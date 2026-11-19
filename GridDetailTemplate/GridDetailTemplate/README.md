# Blazor Grid - DetailTemplate

## Overview
This sample demonstrates a three-level hierarchical DataGrid in a .NET 8 Blazor application using the Syncfusion Blazor DataGrid. The parent Grid displays Well information and uses a DetailTemplate to render related Well Origins. Each Well Origin can be expanded further to display associated Wellbore and Completion information through additional nested Grids. The sample showcases Sticky Headers in nested Grids, Paging, Filtering, Sorting, and Resizing. It also illustrates the behavior of Sticky Headers within hierarchical DetailTemplate scenarios and demonstrates the recommended approach of using independent scrollable regions for child Grids.

## Key Features

- Uses the Syncfusion Blazor DataGrid as the primary data presentation component.
- Demonstrates a three-level hierarchy using nested DetailTemplates.
- Displays Well, Well Origin, Wellbore, and Completion information using related datasets.
- Supports expanding and collapsing hierarchy rows across multiple levels.
- Demonstrates Sticky Header behavior in nested Grid scenarios.
- Uses fixed-height child Grids to create independent scrollable regions.
- Supports Paging in the parent Grid.
- Supports Filtering, Sorting, and Column Resizing.
- Uses realistic Oil & Gas business data to simulate a real-world application.
- Demonstrates recommended handling of nested DetailTemplate scenarios.

## Prerequisites

- .NET 8 SDK
- Visual Studio, Visual Studio Code, or another .NET-compatible IDE

## How to Run the Project

### Visual Studio

1. Open `GridDetailTemplate.slnx`.
2. Restore the NuGet packages.
3. Build the solution.
4. Run the application and open the home page.
5. Expand a Well record to view Well Origins.
6. Expand a Well Origin record to view Wellbore and Completion information.
7. Scroll within the child Grids to observe Sticky Header behavior.


### Visual Studio Code

1. Open the repository folder in Visual Studio Code.
2. Open the integrated terminal and navigate to the project directory.
3. Restore the NuGet packages and start the application:

```sh
dotnet restore
dotnet run
```

Open the local URL printed by `dotnet run`. The configured HTTP launch profile uses `http://localhost:5153`.

## Support and Feedback

- For general Syncfusion product questions, visit the [Syncfusion Community Forum](https://www.syncfusion.com/forums) or [Syncfusion Support](https://www.syncfusion.com/support).
- For Blazor DataGrid documentation, see the [Syncfusion Blazor DataGrid documentation](https://blazor.syncfusion.com/documentation/datagrid/getting-started).
- To report an issue specific to this sample, open an issue in the repository where the sample is hosted.

## License

This is a Syncfusion sample project provided to demonstrate product usage. Review the [Syncfusion license terms](https://www.syncfusion.com/sales/pricing?category=ui-components) before using Syncfusion components in your own applications.
